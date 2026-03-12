# Questionnaire Management System

A web application for creating questionnaires, collecting answers, and generating reports.

This project is built using ASP.NET Core, React, and PostgreSQL with a Clean Architecture approach.

---

# Project Overview

The system allows users to:

- Create and manage questionnaires
- Define different types of questions
- Share questionnaires with others
- Collect answers from respondents
- Generate reports from collected data
- Control data privacy and access levels

---

# Tech Stack

## Backend
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- JWT Authentication

## Frontend
- React
- Axios
- React Router

## Architecture
- Clean Architecture
- Domain-driven design principles

---

# Features

## Authentication
- User registration
- User login
- JWT-based authentication

## Questionnaire Management
Users can:

- Create questionnaires
- Add multiple questions
- Define question types:
  - Text
  - Number
  - Single Choice
  - Multiple Choice

## Privacy Control

Each questionnaire has a privacy type:

- Private → Only the creator can view submitted answers
- Public → All authenticated users can access answers and use them in reports

## Access Levels

Each questionnaire has an access level that controls who can open and submit it:

- Creator Only
- Authenticated Users
- Public by Shared Link
- Public by QR Code

---

# System Architecture

The project follows Clean Architecture with four layers:

src/

API/  
Application/  
Domain/  
Infrastructure/

### Domain
Contains:
- Entities
- Enums
- Business rules

### Application
Contains:
- Use cases
- DTOs
- Interfaces
- Business logic

### Infrastructure
Contains:
- Database access
- Entity Framework configuration
- Repository implementations

### API
Contains:
- Controllers
- Authentication
- Middleware
- API endpoints

---

# Database

Database used:

PostgreSQL

Main tables:

- Users
- Questionnaires
- Questions
- QuestionOptions
- Subjects
- Answers

---

# Project Setup

## 1. Clone Repository

git clone https://github.com/your-username/your-repository.git

cd your-repository

---

## 2. Run Backend

dotnet restore

dotnet run --project QuestionnaireApp.API

---

## 3. Configure Database

Update the connection string in:

QuestionnaireApp.API/appsettings.json

Example:

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=questionnairedb;Username=postgres;Password=postgres"
}

---

## 4. Run Database Migration

dotnet ef database update --project QuestionnaireApp.Infrastructure --startup-project QuestionnaireApp.API

---

# Future Improvements

- PDF report generation
- QR code generator for public questionnaires
- Dashboard analytics
- Export to Excel
- Role-based access control

---

# License

This project is open-source and available under the MIT License.

---

# Author

Davood