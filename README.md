# Unit Conversion API

## Overview

Unit Conversion API is a RESTful ASP.NET Core Web API that converts numerical values between different units of measurement.

Currently supported conversion categories:

* Length
* Weight/Mass
* Temperature

The application is designed using Clean Architecture principles and follows SOLID design principles to ensure maintainability, scalability, and testability.

---

## Features

* Convert values between multiple units
* RESTful API design
* Swagger/OpenAPI documentation
* Dependency Injection
* Strategy Pattern implementation
* Unit Testing support
* Extensible architecture for future unit categories
* Production-ready project structure

---

## Technology Stack

* ASP.NET Core 8
* C#
* Swagger / OpenAPI
* xUnit
* Dependency Injection
* Clean Architecture

---

## Solution Structure

```text
UnitConversionAPI
│
├── src
│   ├── UnitConversion.API
│   ├── UnitConversion.Application
│   ├── UnitConversion.Domain
│   └── UnitConversion.Infrastructure
│
├── tests
│   └── UnitConversion.Tests
│
└── README.md
```

### Project Responsibilities

| Project                       | Responsibility                         |
| ----------------------------- | -------------------------------------- |
| UnitConversion.API            | Controllers, Middleware, Configuration |
| UnitConversion.Application    | DTOs, Interfaces, Contracts            |
| UnitConversion.Domain         | Business Models, Enums, Common Classes |
| UnitConversion.Infrastructure | Conversion Logic Implementations       |
| UnitConversion.Tests          | Unit Tests                             |

---

## Supported Units

### Length

* Meter
* Kilometer
* Foot

### Weight

* Kilogram
* Gram
* Pound

### Temperature

* Celsius
* Fahrenheit
* Kelvin

---

## API Endpoint

### Convert Units

**POST**

```http
/api/conversion
```

### Request

```json
{
  "category": "Length",
  "fromUnit": "Meter",
  "toUnit": "Foot",
  "value": 10
}
```

### Response

```json
{
  "originalValue": 10,
  "fromUnit": "Meter",
  "toUnit": "Foot",
  "convertedValue": 32.81
}
```

---

## Running the Application

### Prerequisites

Install:

* .NET 8 SDK
* Visual Studio 2022 / VS Code

Verify installation:

```bash
dotnet --version
```

---

### Clone Repository

```bash
git clone <repository-url>
```

Navigate to project:

```bash
cd UnitConversionAPI
```

---

### Restore Packages

```bash
dotnet restore
```

---

### Build Solution

```bash
dotnet build
```

---

### Run Application

```bash
dotnet run --project src/UnitConversion.API
```

---

## Swagger

Swagger UI is configured as the default landing page.

Open:

```text
https://localhost:5001
```

or

```text
https://localhost:<port>
```

Swagger provides interactive API documentation and allows testing endpoints directly from the browser.

---

## Running Tests

Navigate to solution root and execute:

```bash
dotnet test
```

Example test coverage:

* Length conversions
* Weight conversions
* Temperature conversions
* Invalid unit validations

---

## Design Decisions

### Clean Architecture

The application is organized into separate layers to improve maintainability and separation of concerns.

### SOLID Principles

The design follows SOLID principles to improve extensibility and reduce coupling.

### Strategy Pattern

Each conversion category is implemented using a dedicated strategy.

Examples:

* LengthConversionStrategy
* WeightConversionStrategy
* TemperatureConversionStrategy

This allows new conversion categories to be added without modifying existing code.

### Dependency Injection

ASP.NET Core Dependency Injection is used to register services and strategies.

### Unit Testing

Business logic is isolated from controllers, making the application easy to test.

---

## Future Enhancements

Possible future improvements:

* Database-driven unit management
* Redis caching
* API Versioning
* Authentication & Authorization
* Audit Logging
* Admin UI for managing units
* Support for hundreds or thousands of units
* Docker support
* CI/CD pipeline integration

---

## Author

Balkrushna Khambe

Senior .NET Developer
