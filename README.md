# WMI Web API

This is a simple ASP.NET Core Web API project that serves a World Manufacturer Identifier (WMI) file.

## Getting Started

### Prerequisites

.NET 5.0 SDK

### Installing

1. Clone the repo
   `git clone https://github.com/wnikzad/honda-wmi-api`
2. Open the project in VS Code
3. Build and run the project:

`dotnet build`
`dotnet run`

### Usage

GET /api/hondaWmi: Returns a list of Honda WMI data.
GET /api/hondaWmi/{id}: Returns a single Honda WMI data based on the provided ID.

### Developer note

For CorsPolicy, I have allowed access from http://localhost:3000. If you are using a different port or env variable, please modify this.
