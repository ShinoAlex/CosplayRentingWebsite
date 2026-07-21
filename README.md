# 🎭 CosRent - Cosplay Costume Rental & Marketplace

A modern web application that allows users to **rent** or **purchase** cosplay costumes through a secure and user-friendly platform.

Built with **ASP.NET Core** using **Clean Architecture**, the project focuses on scalability, maintainability, and best software engineering practices.

---

## 📖 Overview

Finding high-quality cosplay costumes can be expensive and inconvenient. CosRent provides a marketplace where users can:

- Rent costumes for events, conventions, or photoshoots.
- Purchase new or second-hand costumes.
- Browse costumes by category, character, anime, game, movie, and size.
- Manage bookings and orders online.

The goal is to reduce the cost of cosplay while making costumes more accessible to the community.

---

## ✨ Features

### 👤 Authentication & Authorization
- JWT Authentication
- Role-based Authorization
- User Registration & Login
- Profile Management

### 👘 Costume Management
- Browse available costumes
- Search and filter costumes
- View costume details
- Upload costume images
- Manage inventory

### 🛒 Shopping
- Shopping Cart
- Purchase costumes
- Rental booking
- Order history

### 📅 Rental System
- Select rental period
- Availability checking
- Rental status tracking
- Return management

### ⭐ Reviews
- Rate purchased/rented costumes
- Customer reviews
- Seller ratings

### 💳 Payments *(Planned)*
- VNPay
- Stripe
- Payment history

### 🔔 Notifications *(Planned)*
- Booking confirmation
- Rental reminders
- Order updates

---

# 🏛 Architecture

The project follows **Clean Architecture** to separate business logic from infrastructure.

```
src
│
├── CosRent.API              # Presentation Layer
├── CosRent.Application      # Business Logic
├── CosRent.Domain           # Entities & Interfaces
├── CosRent.Infrastructure   # Database & External Services
└── CosRent.Persistence      # Entity Framework Core
```

### Layers

### Domain
- Entities
- Enums
- Value Objects
- Domain Interfaces

### Application
- CQRS
- Use Cases
- DTOs
- Validation
- Business Rules

### Infrastructure
- Entity Framework Core
- Repository Implementation
- JWT Services
- Email Services
- File Storage

### API
- RESTful API
- Authentication
- Authorization
- Swagger

---

# 🛠 Tech Stack

## Backend

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- JWT Authentication
- AutoMapper
- FluentValidation
- MediatR
- Swagger

## Database

- SQL Server

## Architecture

- Clean Architecture
- Repository Pattern
- Dependency Injection
- CQRS
- SOLID Principles

---

# 📂 Project Structure

```
CosRent/
│
├── src/
│   ├── CosRent.API/
│   ├── CosRent.Application/
│   ├── CosRent.Domain/
│   ├── CosRent.Infrastructure/
│   └── CosRent.Persistence/
│
├── tests/
│
└── README.md
```

---

# 🚀 Getting Started

## Prerequisites

- .NET 8 SDK
- SQL Server
- Visual Studio 2022 / VS Code

---

## Clone Repository

```bash
git clone https://github.com/yourusername/CosRent.git

cd CosRent
```

---

## Configure Database

Update your `appsettings.json`

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=CosRent;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

## Apply Migrations

```bash
dotnet ef database update
```

---

## Run the Application

```bash
dotnet run
```

Swagger will be available at

```
https://localhost:5001/swagger
```

---

# 🗃 Database Design

Main entities include:

- Users
- Roles
- Costumes
- Categories
- Rental Orders
- Purchase Orders
- Order Items
- Reviews
- Payments
- Images

---

# 📌 Future Improvements

- AI-powered costume recommendation
- Wishlist
- Chat between buyer and seller
- Real-time notifications
- QR code for rental check-in/out
- Admin dashboard
- Analytics
- Cloud image storage
- Docker deployment
- CI/CD with GitHub Actions

---

# 🧪 Testing

Planned:

- xUnit
- Moq
- Integration Testing
- API Testing

---

# 📸 Screenshots

Coming soon.

---

# 📜 API Documentation

Swagger UI

```
/swagger
```

---

# 🤝 Contributing

Contributions are welcome!

1. Fork the repository
2. Create a new branch

```bash
git checkout -b feature/awesome-feature
```

3. Commit changes

```bash
git commit -m "Add awesome feature"
```

4. Push

```bash
git push origin feature/awesome-feature
```

5. Open a Pull Request

---

# 📄 License

This project is licensed under the MIT License.

---

# 👨‍💻 Author

Developed as a portfolio project to demonstrate:

- ASP.NET Core
- Clean Architecture
- RESTful API
- Entity Framework Core
- SQL Server
- Authentication & Authorization
- Software Design Principles

If you found this project useful, consider giving it a ⭐ on GitHub!
