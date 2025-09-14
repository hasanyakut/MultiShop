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


