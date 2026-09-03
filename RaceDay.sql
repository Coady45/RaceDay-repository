-- RaceDay Database Script
USE master;
GO
IF DB_ID('RaceDay') IS NOT NULL DROP DATABASE RaceDay;
GO
CREATE DATABASE RaceDay;
GO
USE RaceDay;
GO

CREATE TABLE Users (
 UserId INT IDENTITY(1,1) PRIMARY KEY,
 Email NVARCHAR(255) NOT NULL UNIQUE,
 PasswordHash NVARCHAR(255) NOT NULL,
 FirstName NVARCHAR(100) NOT NULL,
 LastName NVARCHAR(100) NOT NULL,
 Role NVARCHAR(20) NOT NULL CHECK (Role IN ('Organiser','Participant')),
 CreatedAt DATETIME2 NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Events (
 EventId INT IDENTITY(1,1) PRIMARY KEY,
 OrganiserId INT NOT NULL,
 Title NVARCHAR(200) NOT NULL,
 Description NVARCHAR(MAX) NULL,
 EventDate DATETIME2 NOT NULL,
 Location NVARCHAR(200) NOT NULL,
 Status NVARCHAR(20) NOT NULL DEFAULT 'Upcoming'
   CHECK (Status IN ('Upcoming','Completed','Cancelled')),
 CreatedAt DATETIME2 NOT NULL DEFAULT GETDATE(),
 CONSTRAINT FK_Events_Organiser FOREIGN KEY (OrganiserId) REFERENCES Users(UserId)
);

CREATE TABLE Categories (
 CategoryId INT IDENTITY(1,1) PRIMARY KEY,
 EventId INT NOT NULL,
 Name NVARCHAR(100) NOT NULL,
 DistanceKm DECIMAL(6,2) NOT NULL,
 MaxParticipants INT NULL,
 CONSTRAINT FK_Categories_Event FOREIGN KEY (EventId) REFERENCES Events(EventId) ON DELETE CASCADE
);

CREATE TABLE Routes (
 RouteId INT IDENTITY(1,1) PRIMARY KEY,
 EventId INT NOT NULL UNIQUE,
 Description NVARCHAR(MAX) NULL,
 MapUrl NVARCHAR(500) NULL,
 TotalDistanceKm DECIMAL(6,2) NULL,
 CONSTRAINT FK_Routes_Event FOREIGN KEY (EventId) REFERENCES Events(EventId) ON DELETE CASCADE
);

CREATE TABLE EventImages (
 ImageId INT IDENTITY(1,1) PRIMARY KEY,
 EventId INT NOT NULL,
 ImageUrl NVARCHAR(500) NOT NULL,
 Caption NVARCHAR(200) NULL,
 UploadedAt DATETIME2 NOT NULL DEFAULT GETDATE(),
 CONSTRAINT FK_EventImages_Event FOREIGN KEY (EventId) REFERENCES Events(EventId) ON DELETE CASCADE
);

CREATE TABLE Enrolments (
 EnrolmentId INT IDENTITY(1,1) PRIMARY KEY,
 ParticipantId INT NOT NULL,
 CategoryId INT NOT NULL,
 EnrolmentDate DATETIME2 NOT NULL DEFAULT GETDATE(),
 Status NVARCHAR(20) NOT NULL DEFAULT 'Registered'
   CHECK (Status IN ('Registered','Cancelled','Completed')),
 CONSTRAINT FK_Enrolments_Participant FOREIGN KEY (ParticipantId) REFERENCES Users(UserId),
 CONSTRAINT FK_Enrolments_Category FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId),
 CONSTRAINT UQ_Participant_Category UNIQUE (ParticipantId,CategoryId)
);

CREATE TABLE Results (
 ResultId INT IDENTITY(1,1) PRIMARY KEY,
 EnrolmentId INT NOT NULL UNIQUE,
 FinishTime TIME(0) NULL,
 Position INT NULL,
 Notes NVARCHAR(500) NULL,
 RecordedAt DATETIME2 NOT NULL DEFAULT GETDATE(),
 CONSTRAINT FK_Results_Enrolment FOREIGN KEY (EnrolmentId) REFERENCES Enrolments(EnrolmentId)
);

INSERT INTO Users (Email,PasswordHash,FirstName,LastName,Role) VALUES
('thabo.organiser@raceday.co.za','HASHED_PWD_1','Thabo','Molefe','Organiser'),
('lerato.organiser@raceday.co.za','HASHED_PWD_2','Lerato','Nkosi','Organiser'),
('sipho.runner@email.com','HASHED_PWD_3','Sipho','Dlamini','Participant'),
('ayanda.walker@email.com','HASHED_PWD_4','Ayanda','Mabaso','Participant');

INSERT INTO Events (OrganiserId,Title,Description,EventDate,Location,Status) VALUES
(1,'Soweto Marathon 2026','Iconic race through Soweto','2026-11-01 06:00','Soweto, Johannesburg','Upcoming'),
(1,'Cape Town Cycle Tour Fun Ride','Community cycling event','2027-03-15 07:00','Cape Town','Upcoming'),
(2,'Durban Beachfront 10K','Flat seaside road race','2027-05-20 06:30','Durban','Upcoming');

INSERT INTO Categories (EventId,Name,DistanceKm,MaxParticipants) VALUES
(1,'42.2 km Marathon',42.20,15000),(1,'21.1 km Half',21.10,8000),
(2,'109 km Cycle',109.00,20000),(2,'42 km Fun Ride',42.00,5000),
(3,'10 km Run',10.00,3000),(3,'5 km Walk',5.00,2000);

INSERT INTO Routes (EventId,Description,MapUrl,TotalDistanceKm) VALUES
(1,'Classic Soweto route via Vilakazi Street','https://maps.example/soweto',42.20),
(2,'Scenic peninsula route','https://maps.example/ctct',109.00),
(3,'Beachfront promenade out-and-back','https://maps.example/durban',10.00);

INSERT INTO Enrolments (ParticipantId,CategoryId,Status) VALUES
(3,1,'Registered'),(3,5,'Registered'),(4,6,'Registered'),(4,2,'Registered');

INSERT INTO Results (EnrolmentId,FinishTime,Position,Notes) VALUES
(1,'03:45:12',1250,'Strong finish'),(2,'00:48:30',312,NULL);

PRINT 'RaceDay database created and seeded successfully.';
GO
