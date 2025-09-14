# MultiShop - E-Commerce Microservices Platform

A comprehensive e-commerce platform built with .NET 6 microservices architecture, featuring multiple independent services for different business domains.

## 🏗️ Architecture Overview

MultiShop follows a microservices architecture pattern with the following key components:

- **Identity Server**: Centralized authentication and authorization using IdentityServer4
- **Catalog Service**: Product and category management with MongoDB
- **Basket Service**: Shopping cart functionality with Redis
- **Order Service**: Order processing with Clean Architecture (CQRS + MediatR)
- **Discount Service**: Coupon and discount management with SQL Server
- **Cargo Service**: Shipping and logistics management with SQL Server

## 🚀 Services

### 1. Identity Server (`MultiShop.IdentityServer`)
- **Technology**: ASP.NET Core 6, IdentityServer4, Entity Framework Core
- **Database**: SQL Server
- **Purpose**: Centralized authentication and authorization
- **Features**:
  - User registration and login
  - JWT token generation
  - OAuth2/OpenID Connect support
  - Google authentication integration

### 2. Catalog Service (`MultiShop.Catalog`)
- **Technology**: ASP.NET Core 6, MongoDB, AutoMapper
- **Database**: MongoDB
- **Purpose**: Product and category management
- **Features**:
  - Product CRUD operations
  - Category management
  - Product details and images
  - JWT authentication

### 3. Basket Service (`MultiShop.Basket`)
- **Technology**: ASP.NET Core 6, Redis
- **Database**: Redis
- **Purpose**: Shopping cart functionality
- **Features**:
  - Add/remove items from cart
  - Update quantities
  - Session-based cart management
  - JWT authentication

### 4. Order Service (`MultiShop.Order.*`)
- **Technology**: ASP.NET Core 6, Clean Architecture, CQRS, MediatR
- **Database**: SQL Server
- **Purpose**: Order processing and management
- **Architecture**: 
  - Domain Layer: Core business entities
  - Application Layer: Use cases and business logic
  - Infrastructure Layer: Data persistence
  - Presentation Layer: Web API
- **Features**:
  - Order creation and management
  - Order details tracking
  - Address management

### 5. Discount Service (`MultiShop.Discount`)
- **Technology**: ASP.NET Core 6, Entity Framework Core
- **Database**: SQL Server
- **Purpose**: Coupon and discount management
- **Features**:
  - Coupon creation and validation
  - Discount rate management
  - Coupon expiration handling

### 6. Cargo Service (`MultiShop.Cargo.*`)
- **Technology**: ASP.NET Core 6, Entity Framework Core, N-Tier Architecture
- **Database**: SQL Server
- **Purpose**: Shipping and logistics management
- **Architecture**:
  - Entity Layer: Domain models
  - Data Access Layer: Repository pattern
  - Business Layer: Business logic
  - DTO Layer: Data transfer objects
  - Web API Layer: REST endpoints
- **Features**:
  - Cargo company management
  - Customer information
  - Cargo tracking
  - Operation management

## 🛠️ Technology Stack

- **.NET 6**: Core framework
- **ASP.NET Core Web API**: RESTful services
- **Entity Framework Core**: ORM for SQL Server
- **MongoDB**: NoSQL database for catalog service
- **Redis**: In-memory cache for basket service
- **IdentityServer4**: Authentication and authorization
- **AutoMapper**: Object mapping
- **MediatR**: CQRS implementation
- **Swagger/OpenAPI**: API documentation
- **JWT Bearer Authentication**: Token-based security

## 📁 Project Structure

```
MultiShop/
├── IdentityServer/
│   └── MultiShop.IdentityServer/          # Identity and authentication service
├── Services/
│   ├── Basket/
│   │   └── MultiShop.Basket/             # Shopping cart service
│   ├── Catalog/
│   │   └── MultiShop.Catalog/            # Product catalog service
│   ├── Cargo/
│   │   ├── Multishop.Cargo.EntityLayer/  # Domain entities
│   │   ├── MultiShop.Cargo.BusinessLayer/ # Business logic
│   │   ├── MultiShop.Cargo.DataAccessLayer/ # Data access
│   │   ├── MultiShop.Carge.DtoLayer/     # Data transfer objects
│   │   └── MultiShop.Cargo.WebApi/       # Web API
│   ├── Discount/
│   │   └── MultiShop.Discount/           # Discount and coupon service
│   └── Order/
│       ├── Core/
│       │   ├── MultiShop.Order.Domain/   # Domain layer
│       │   └── MultiShop.Order.Application/ # Application layer
│       ├── Infrastructure/
│       │   └── MultiShop.Order.Persistence/ # Infrastructure layer
│       └── Presentation/
│           └── MultiShop.Order.WebApi/   # Presentation layer
└── MultiShop.sln                         # Solution file
```

## 🚀 Getting Started

### Prerequisites

- .NET 6 SDK
- SQL Server (for Identity, Order, Discount, and Cargo services)
- MongoDB (for Catalog service)
- Redis (for Basket service)

### Installation

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd MultiShop
   ```

2. **Update connection strings** in `appsettings.json` files for each service:
   - Identity Server: Update SQL Server connection string
   - Catalog Service: Update MongoDB connection string
   - Basket Service: Update Redis connection string
   - Order Service: Update SQL Server connection string
   - Discount Service: Update SQL Server connection string
   - Cargo Service: Update SQL Server connection string

3. **Run database migrations**
   ```bash
   # For Identity Server
   cd IdentityServer/MultiShop.IdentityServer
   dotnet ef database update

   # For Order Service
   cd Services/Order/Presentation/MultiShop.Order.WebApi
   dotnet ef database update

   # For Discount Service
   cd Services/Discount/MultiShop.Discount
   dotnet ef database update

   # For Cargo Service
   cd Services/Cargo/MultiShop.Cargo.WebApi
   dotnet ef database update
   ```

4. **Start the services**
   ```bash
   # Start Identity Server (Port 5001)
   cd IdentityServer/MultiShop.IdentityServer
   dotnet run

   # Start Catalog Service (Port 5002)
   cd Services/Catalog/MultiShop.Catalog
   dotnet run

   # Start Basket Service (Port 5003)
   cd Services/Basket/MultiShop.Basket
   dotnet run

   # Start Order Service (Port 5004)
   cd Services/Order/Presentation/MultiShop.Order.WebApi
   dotnet run

   # Start Discount Service (Port 5005)
   cd Services/Discount/MultiShop.Discount
   dotnet run

   # Start Cargo Service (Port 5006)
   cd Services/Cargo/MultiShop.Cargo.WebApi
   dotnet run
   ```

### API Documentation

Each service provides Swagger documentation available at:
- Identity Server: `http://localhost:5001/swagger`
- Catalog Service: `http://localhost:5002/swagger`
- Basket Service: `http://localhost:5003/swagger`
- Order Service: `http://localhost:5004/swagger`
- Discount Service: `http://localhost:5005/swagger`
- Cargo Service: `http://localhost:5006/swagger`

## 🔐 Authentication

The platform uses JWT-based authentication with IdentityServer4:

1. Register/login through the Identity Server
2. Obtain JWT token
3. Use the token in Authorization header for protected endpoints
4. Token format: `Bearer <your-jwt-token>`

## 🏛️ Architecture Patterns

- **Microservices**: Each service is independently deployable
- **Clean Architecture**: Order service follows Clean Architecture principles
- **CQRS**: Command Query Responsibility Segregation in Order service
- **Repository Pattern**: Data access abstraction
- **N-Tier Architecture**: Cargo service uses traditional N-Tier pattern
- **Domain-Driven Design**: Business logic centered around domain models

## 📊 Database Schema

- **Identity Database**: User management and authentication
- **Catalog Database (MongoDB)**: Products, categories, and product details
- **Basket Database (Redis)**: Shopping cart sessions
- **Order Database**: Orders, order details, and addresses
- **Discount Database**: Coupons and discount rules
- **Cargo Database**: Shipping companies, customers, and operations

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🆘 Support

If you have any questions or need help, please open an issue in the repository.

---

**Note**: This is a learning project demonstrating microservices architecture with .NET 6. Make sure to configure your database connections and security settings appropriately for production use.
