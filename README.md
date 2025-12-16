# Mini Learning Management System

## Overview
A simple full-stack learning management dashboard built with ASP.NET Core Web API and a lightweight frontend.

## Backend
- ASP.NET Core Web API
- RESTful endpoints
- In-memory data storage
- Swagger (OpenAPI)
- Dependency Injection
- Unit tests using xUnit

### API Endpoints
- GET /api/courses
- POST /api/courses
- POST /api/enrolments
- GET /api/enrolments/report

## Frontend
- Plain HTML, CSS, JavaScript
- Fetch API for backend communication
- Displays courses and enrolment report

## Notes
- Data is stored in memory and resets on application restart
- CORS is enabled for development purposes

## How to Run
1. Run the API project using Visual Studio 2022
2. Open the frontend using Live Server (VS Code)
3. Use Swagger to create courses and enrolments


## Bonus
- Mocked AWS SDK integration (S3) to demonstrate external service abstraction
- Frontend report showing total students per course
- Responsive UI styling using plain CSS


