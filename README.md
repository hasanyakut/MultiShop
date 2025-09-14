MultiShop, .NET 6 tabanlı mikroservis mimarisi kullanılarak geliştirilmiş kapsamlı bir e-ticaret platformudur. Proje şu ana bileşenlerden oluşuyor:
🏗️ Mikroservisler:
Identity Server - Kimlik doğrulama ve yetkilendirme
Catalog Service - Ürün ve kategori yönetimi (MongoDB)
Basket Service - Sepet işlemleri (Redis)
Order Service - Sipariş yönetimi (Clean Architecture + CQRS)
Discount Service - İndirim yönetimi (Dapper)
Cargo Service - Kargo yönetimi (Entity Framework)
🛠️ Teknoloji:
.NET 6 - Ana framework
ASP.NET Core Web API - RESTful API
Entity Framework Core - SQL Server ORM
MongoDB - NoSQL veritabanı
Redis - Bellek içi veri deposu
IdentityServer4 - OAuth 2.0/OpenID Connect
JWT Authentication - Token tabanlı kimlik doğrulama
AutoMapper, MediatR, Serilog - Ek kütüphaneler
📁 Mimari Özellikler:
Mikroservis mimarisi
Clean Architecture (Order servisi)
CQRS pattern (Order servisi)
Repository pattern
Dependency Injection
JWT tabanlı güvenlik
