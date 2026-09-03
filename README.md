# RaceDay Event Management System

## System Description

RaceDay is an event management system designed to manage sporting and racing events. The system allows organisers to create and manage events, define event categories, manage participant enrolments, record race results, and provide route and event image information.

Participants can browse upcoming events, view event information, enrol in available categories, manage their profiles, and view their results and performance history.

This repository contains the planning and database artefacts for Part 1 of the RaceDay project.

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

**YouTube video:** [    ]

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
