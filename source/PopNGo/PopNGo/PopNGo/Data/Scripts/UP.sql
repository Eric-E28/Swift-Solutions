-- CREATE DATABASE [PopNGoDB];

-- USE [PopNGoDB];

CREATE TABLE [PG_User] (
  [ID] INTEGER PRIMARY KEY IDENTITY(1, 1),
  [ASPNETUserID] NVARCHAR(255) NOT NULL
);

CREATE TABLE [EventHistory] (
  [ID] INTEGER PRIMARY KEY IDENTITY(1, 1),
  [UserID] INTEGER NOT NULL,
  [EventID] INTEGER NOT NULL,
  [ViewedDate] DATETIME NOT NULL
);

CREATE TABLE [Event] (
  [ID] INTEGER PRIMARY KEY IDENTITY(1, 1),
  [EventID] NVARCHAR(255) NOT NULL,
  [EventDate] DATETIME NOT NULL,
  [EventName] NVARCHAR(255) NOT NULL,
  [EventDescription] NVARCHAR(255) NOT NULL,
  [EventLocation] NVARCHAR(255) NOT NULL
);

ALTER TABLE [EventHistory] ADD CONSTRAINT FK_EventHistory_UserID FOREIGN KEY ([UserID]) REFERENCES [PG_User] ([ID]);
ALTER TABLE [EventHistory] ADD CONSTRAINT FK_EventHistory_EventID FOREIGN KEY ([EventID]) REFERENCES [Event] ([ID]);