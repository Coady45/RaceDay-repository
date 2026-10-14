# RaceDay Event Management System

## System Description

RaceDay is an event management system developed using
ASP.NET Core Web API, C#, Entity Framework Core, and SQL Server.

The system allows organisers to manage events and participants
to register for events. It provides API endpoints for managing
event information and participant registrations.

This repository contains the planning and database for part 1 together with ASP.NET Core web API implementation developed for part 2 of raceday project

## User Roles

### Organiser

The Organiser is responsible for managing sporting events and their information.

Organisers can:

* Create events.
* Update and delete their own events.
* Create and manage event categories.
* View participant enrolments for their events.
* Record participant results.
* Manage event route information.
* Add event image information.

### Participant

The Participant uses the system to participate in sporting events.

Participants can:

* Browse upcoming events.
* View event details and categories.
* Enrol in an event category.
* View their own enrolments.
* Cancel their own enrolments.
* Manage their profile.
* View their results and performance history.

## Part 1 Documentation

The `/docs` folder contains the required planning and database artefacts for Part 1.

### Section A – Entity Relationship Diagram

The ERD contains seven entities:

* Users
* Events
* Categories
* Routes
* EventImages
* Enrolments
* Results

The ERD shows the primary keys, foreign keys, relationships, and cardinality between the entities.

### Section B – API Endpoint Plan

The API Endpoint Plan defines the planned endpoints for:

* Authentication
* User Profiles
* Events
* Categories
* Event Enrolments
* Results
* Routes
* Event Images

The API is planned for implementation in Part 2 using ASP.NET Core Web API.

### Section C – SQL Database Script

The `RaceDay.sql` script creates the RaceDay SQL Server database, tables, relationships, constraints, and sample seed data.

The script can be executed in SQL Server Management Studio (SSMS).

## GitHub Actions CI

The project uses GitHub Actions to automatically check that the required Part 1 documentation files are present in the `/docs` folder.

![GitHub Actions Successful](github-actions-success.png)

## Part 1 Walkthrough Video

The unlisted YouTube video demonstrates:

1. The ERD design and relationship decisions.
2. The API endpoint plan and endpoint choices.
3. The RaceDay SQL script.
4. Running the SQL script in SQL Server Management Studio.
5. The resulting database tables and sample data.

**YouTube video:** [   https://youtu.be/J-bIkpJVFRc?si=OQuWKwOulMwtzUYm ]

## Project Structure

```text
RaceDay/
│
├── .github/
│   └── workflows/
│       └── docs-check.yml
│
├── docs/
│   ├── RaceDay_ERD.png
│   ├── RaceDay_ERD.pdf
│   ├── API_Endpoint_Plan.md
│   └── RaceDay.sql
│
├── github-actions-success.png
└── README.md
```

## Part 1 Status

* [x] Section A – ERD
* [x] Section B – API Endpoint Plan
* [x] Section C – SQL Database Script
* [ ] GitHub Actions workflow
* [ ] CI screenshot
* [ ] Unlisted YouTube walkthrough
* [ ] Minimum 20 meaningful commits
      # Part 2 – ASP.NET Core Web API

## Project Overview

Part 2 implements the RaceDay system using ASP.NET Core Web API,
C#, Entity Framework Core, and Microsoft SQL Server.

The API provides functionality for managing users, sporting
events, categories, participant enrolments, results, routes,
and event images.

## Technologies Used

- C#
- ASP.NET Core Web API
- Entity Framework Core
- Microsoft SQL Server
- Swagger
- Git and GitHub
- GitHub Actions
- Unit Testing

## Part 2 Features

The API implementation includes the following features:

- User registration and authentication.
- Role-based access for Organisers and Participants.
- Event management.
- Category management.
- Participant enrolments.
- Results management.
- Route information.
- Event image information.

Only retain features that you have actually implemented.

## Database Configuration

RaceDay uses Microsoft SQL Server for data storage.

The application uses Entity Framework Core to interact
with the database.

Before running the application, configure the database
connection in appsettings.json.

Do not publish database passwords or other private credentials.

## How to Run the Application

1. Open the RaceDay solution in Visual Studio 2022.
2. Ensure the required .NET SDK is installed.
3. Configure the SQL Server database connection.
4. Ensure the database is available.
5. Build the solution.
6. Run the application.
7. Open the Swagger page to explore and test the API.

## Testing

The project includes automated tests to check the application's
functionality.

Tests can be executed using Visual Studio Test Explorer
or the dotnet test command.

## Part 2 GitHub Actions

GitHub Actions automates the build and testing process
for the application.

The workflow runs when changes are pushed to GitHub.

## Part 2 Demonstration Video

YouTube video: [  ]

The demonstration will show the running application,
project structure, API endpoints, authentication,
and automated tests     


RaceDay/
│
├── .github/
│   └── workflows/
│
├── docs/
│   ├── RaceDay_ERD.pdf
│   ├── API_Endpoint_Plan.md
│   └── RaceDay.sql
│
├── Controllers/
├── Models/
├── Data/
├── DTOs/
├── Tests/
├── Program.cs
├── appsettings.json
└── README.md
