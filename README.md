# MSFD Full Stack Solution

## Overview

A modern, educational full-stack web application built with ASP.NET Core and Blazor WebAssembly, demonstrating complete architecture with a backend API and interactive frontend interface. This project is built for the Microsoft Back-End Development course as part of the Full-Stack Certification track and demonstrates modern full-stack development concepts including RESTful API design, CORS configuration, Blazor WebAssembly component architecture, async/await patterns, third-party API integration, and responsive UI design.

## Technologies Used

| Layer | Technology |
|-------|-----------|
| **Backend** | C#, ASP.NET Core 9.0 |
| **Frontend** | C#/Razor, Blazor WebAssembly, Bootstrap 5 |
| **Libraries** | Markdig (Markdown), HttpClient |
| **APIs** | GitHub REST API |

## Getting Started

### Prerequisites
- .NET 9.0 SDK or later
- A modern web browser

### Installation & Running

```bash
# Clone repository
git clone https://github.com/boricua007/MSFD_FullStackSolution.git
cd MSFD_FullStackSolution

# Build solution
dotnet build

# Terminal 1 - Start Backend
dotnet run --project MSFD_BackEndApp

# Terminal 2 - Start Frontend
dotnet run --project MSFD_FrontEndApp
```

### Access the Application
- **Frontend**: http://localhost:5014
- **API**: http://localhost:5205/products
- **Home**: http://localhost:5014/
- **Products**: http://localhost:5014/fetch
- **About**: http://localhost:5014/about

## Project Structure

```
MSFD_FullStackSolution/
├── MSFD_BackEndApp/
│   ├── Program.cs           # API endpoint configuration
│   └── appsettings.json
│
├── MSFD_FrontEndApp/
│   ├── Pages/
│   │   ├── Home.razor       # Home page
│   │   ├── Products.razor   # Product table
│   │   └── About.razor      # GitHub profile display
│   ├── Layout/
│   │   ├── MainLayout.razor # Master layout
│   │   └── NavMenu.razor    # Navigation
│   └── wwwroot/             # Static assets
│
└── README.md
```

## API Endpoints

### GET /products
Returns all available products in JSON format.

**Response:**
```json
[
  { "id": 1, "name": "Laptop", "price": 999.99 },
  { "id": 2, "name": "Phone", "price": 699.99 },
  { "id": 3, "name": "Tablet", "price": 449.99 }
]
```

**Test with cURL:**
```bash
curl http://localhost:5205/products
```

## Key Features

- **RESTful API** - ASP.NET Core Web API serving product data
- **Interactive UI** - Blazor WebAssembly with Bootstrap styling
- **Product Catalog** - Display products with ID, Name, and Price
- **GitHub Integration** - Display your GitHub profile avatar and README without redirecting
- **CORS Support** - Cross-origin requests handled securely
- **Markdown Rendering** - Beautiful markdown-to-HTML conversion using Markdig

## Usage

### Viewing Products
1. Navigate to http://localhost:5014/
2. Click on "Products" in the navigation menu
3. View the product table with ID, Name, and Price columns


### Testing the API
```bash
# Get all products
curl http://localhost:5205/products

# Using PowerShell
Invoke-RestMethod -Uri http://localhost:5205/products
```

## Key Concepts Demonstrated

**Backend**
- RESTful API design with MapGet endpoints
- CORS policy configuration
- Service configuration and dependency injection

**Frontend**
- Blazor component architecture
- HttpClient for API communication
- Async/await patterns with OnInitializedAsync
- Error handling and loading states
- JSON serialization/deserialization

**Integration**
- GitHub API integration (user data & README fetching)
- Markdown processing with Markdig
- Cross-origin request handling
- Third-party API consumption

## About

.NET 9.0 Full Stack Web Application built for the Microsoft Back-End Development course as part of the Microsoft Full-Stack Certification track. This comprehensive educational project demonstrates real-world full-stack development patterns and best practices.

**Author**: [@boricua007](https://github.com/boricua007)  
**Version**: 1.0.0  
**Last Updated**: January 17, 2026  
**Repository**: [MSFD_FullStackSolution](https://github.com/boricua007/MSFD_FullStackSolution)
