-- Ensure that the database is created if it doesn't exist (if applicable)
-- CREATE DATABASE [PopNGoDB];
USE [PopNGoDB];

CREATE TABLE [PG_User] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [ASPNETUserID] NVARCHAR(255) NOT NULL
);

CREATE TABLE [FavoriteEvents] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [BookmarkListID] INT NOT NULL,
  [EventID] INT NOT NULL
);

CREATE TABLE [BookmarkList] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [UserID] INT NOT NULL,
  [Title] NVARCHAR(128) NOT NULL
);

CREATE TABLE [EventHistory] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [UserID] INT NOT NULL,
  [EventID] INT NOT NULL,
  [ViewedDate] DATETIME NOT NULL
);

CREATE TABLE [Event] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [ApiEventID] NVARCHAR(255) NOT NULL,
  [EventDate] DATETIME,
  [EventName] NVARCHAR(255),
  [EventDescription] NVARCHAR(MAX),
  [EventLocation] NVARCHAR(255),
  [EventImage] NVARCHAR(MAX),
  [VenuePhoneNumber] NVARCHAR(255),
  [VenueName] NVARCHAR(255),
  [VenueRating] DECIMAL(2, 1),
  [VenueWebsite] NVARCHAR(255)
);

CREATE TABLE [TicketLink] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [EventID] INT NOT NULL,
  [Source] NVARCHAR(255),
  [Link] NVARCHAR(255)
);

CREATE TABLE [Tag] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [Name] NVARCHAR(255) NOT NULL,
  [BackgroundColor] NVARCHAR(255) NOT NULL,
  [TextColor] NVARCHAR(255) NOT NULL
);

CREATE TABLE [ScheduledNotification] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [UserID] INT NOT NULL,
  [Time] DATETIME NOT NULL,
  [Type] NVARCHAR(255) NOT NULL
);

CREATE TABLE [ItineraryDaySection] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [ItineraryTitle] NVARCHAR(255),
  [ItineraryDate] DATETIME NOT NULL
);

CREATE TABLE [ItineraryChecklist] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [ItineraryDaySectionId] INT NOT NULL,
  [ItineraryHeader] NVARCHAR(255) NOT NULL
);

CREATE TABLE [ItineraryChecklistItem] (
  [ID] INT PRIMARY KEY IDENTITY(1, 1),
  [ItineraryChecklistId] INT NOT NULL,
  [ItemDescription] NVARCHAR(255) NOT NULL
);

-- Add Foreign Key constraints
ALTER TABLE [ItineraryChecklist] ADD CONSTRAINT FK_ItineraryChecklist_ItineraryDaySection FOREIGN KEY ([ItineraryDaySectionId]) REFERENCES [ItineraryDaySection]([ID]);
ALTER TABLE [ItineraryChecklistItem] ADD CONSTRAINT FK_ItineraryChecklistItem_ItineraryChecklist FOREIGN KEY ([ItineraryChecklistId]) REFERENCES [ItineraryChecklist]([ID]);

ALTER TABLE [EventHistory] ADD CONSTRAINT FK_EventHistory_UserID FOREIGN KEY ([UserID]) REFERENCES [PG_User]([ID]);
ALTER TABLE [EventHistory] ADD CONSTRAINT FK_EventHistory_EventID FOREIGN KEY ([EventID]) REFERENCES [Event]([ID]);

ALTER TABLE [FavoriteEvents] ADD CONSTRAINT FK_FavoriteEvents_EventID FOREIGN KEY ([EventID]) REFERENCES [Event]([ID]);
ALTER TABLE [FavoriteEvents] ADD CONSTRAINT FK_FavoriteEvents_BookmarkListID FOREIGN KEY ([BookmarkListID]) REFERENCES [BookmarkList]([ID]);

ALTER TABLE [TicketLink] ADD CONSTRAINT FK_TicketLink_EventID FOREIGN KEY ([EventID]) REFERENCES [Event]([ID]);

ALTER TABLE [ScheduledNotification] ADD CONSTRAINT FK_ScheduledNotification_UserID FOREIGN KEY ([UserID]) REFERENCES [PG_User]([ID]);
