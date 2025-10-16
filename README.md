# DynamicProfileAPI

A simple RESTful API built with ASP.NET Core that returns profile information along with a dynamic cat fact fetched from the external Cat Facts API.

This project demonstrates consuming third-party APIs, returning dynamic JSON responses, and handling errors gracefully.

# Features

* Fetches a new cat fact on every request
* Returns current UTC timestamp in ISO 8601 format
* Handles API errors gracefully (with fallback message)
* Uses HttpClient and dependency injection for clean architecture
* Well-structured and easy to extend

# API Endpoint
GET /me

Response Example:

{
  "status": "success",
  "user": {
    "name": "Oluwadamimola Adedeji",
    "email": "damimolaadedeji@gmail.com",
    "stack": "C# / .NET"
  },
  "timestamp": "2025-10-16T10:23:45Z",
  "fact": "Cats sleep for 70% of their lives."
}

# Setup Instructions
* Clone the repository
git clone https://github.com/Oluwadamimola/DynamicProfileAPI.git
cd DynamicProfileAPI

* Install dependencies

Make sure you have the .NET 8 SDK installed.
Then run:
dotnet restore

* Run the project locally
dotnet run

# Dependencies

Microsoft.AspNetCore.App (default framework)

System.Net.Http

System.Text.Json

Swashbuckle.AspNetCore 

To install Swagger manually : dotnet add package Swashbuckle.AspNetCore

# Testing the API

You can test your API using:

Swagger UI 