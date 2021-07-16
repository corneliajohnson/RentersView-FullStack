USE [master]

IF db_id('RentersView') IS NULL
  CREATE DATABASE [RentersView]
GO

USE [RentersView]
GO


DROP TABLE IF EXISTS [UserProfile]
DROP TABLE IF EXISTS [Request];
DROP TABLE IF EXISTS [Message];
DROP TABLE IF EXISTS [Property];
DROP TABLE IF EXISTS [Payment];
DROP TABLE IF EXISTS [LeaseType];
GO


CREATE TABLE [UserProfile] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Image] nvarchar(255),
  [FirstName] nvarchar(255) NOT NULL,
  [LastName] nvarchar(255) NOT NULL,
  [Email] nvarchar(255) NOT NULL,
  [Phone] nvarchar(255),
  [FirebaseId] integer NOT NULL,
  [IsLandlord] bit DEFAULT 1 NOT NULL,
  [LandlordId] integer,
  [DateCreated] datetime NOT NULL

  CONSTRAINT UQ_FirebaseId UNIQUE(FirebaseId),
  CONSTRAINT UQ_Email UNIQUE(Email)
)
GO

CREATE TABLE [Property] (
  [Id] integer PRIMARY KEY IDENTITY,
  [UserProfileId] integer NOT NULL,
  [Street] nvarchar(255) NOT NULL,
  [City] nvarchar(255) NOT NULL,
  [State] nvarchar(255) NOT NULL,
  [Zip] integer NOT NULL,
  [LeaseStartDate] date,
  [LeaseEndDate] date,
  [RentAmount] decimal,
  [SecurityDeposit] decimal,
  [LeaseTerm] nvarchar(255),
  [LeaseTypeId] integer NOT NULL,
  [Image] nvarchar(255),
  [DateCreated] datetime NOT NULL,
  [CurrentTenantId] integer
)
GO

CREATE TABLE [Request] (
  [Id] integer PRIMARY KEY IDENTITY,
  [PropertyId] integer NOT NULL,
  [Synopsis] nvarchar(255) NOT NULL,
  [Price] decimal,
  [Contractor] nvarchar(255),
  [Complete] bit DEFAULT 0 NOT NULL,
  [Note] nvarchar(500),
  [DateCompleted] datetime,
  [DateAdded] datetime NOT NULL
)
GO

CREATE TABLE [Message] (
  [Id] integer PRIMARY KEY IDENTITY,
  [TenantId] integer NOT NULL,
  [LandlordId] integer NOT NULL,
  [Text] nvarchar(500) NOT NULL,
  [Date] datetime NOT NULL
)
GO

CREATE TABLE [Payment] (
  [Id] integer PRIMARY KEY IDENTITY,
  [UserProfileId] integer NOT NULL,
  [Date] datetime NOT NULL,
  [PaymentAmount] decimal NOT NULL
)
GO

CREATE TABLE [LeaseType] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Type] nvarchar(255) NOT NULL
)
GO

ALTER TABLE [LeaseType] ADD FOREIGN KEY ([Id]) REFERENCES [Property] ([LeaseTypeId])
GO

ALTER TABLE [Request] ADD FOREIGN KEY ([PropertyId]) REFERENCES [Property] ([Id])
GO

ALTER TABLE [Property] ADD FOREIGN KEY ([UserProfileId]) REFERENCES [UserProfile] ([Id])
GO

ALTER TABLE [Message] ADD FOREIGN KEY ([TenantId]) REFERENCES [UserProfile] ([Id])
GO

ALTER TABLE [Message] ADD FOREIGN KEY ([LandlordId]) REFERENCES [UserProfile] ([Id])
GO

ALTER TABLE [Payment] ADD FOREIGN KEY ([UserProfileId]) REFERENCES [UserProfile] ([Id])
GO
