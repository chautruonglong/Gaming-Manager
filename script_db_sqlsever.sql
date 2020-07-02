CREATE DATABASE [GamingManager]
GO

USE [GamingManager]
GO

CREATE TABLE [Account] (
	[username] nchar(50) PRIMARY KEY,
	[password] nchar(50),
	[group] int
)

CREATE TABLE [Food] (
	[food_id] nchar(50) PRIMARY KEY,
	[name] nvarchar(50),
	[image] varbinary(MAX),
	[cost] float
)

CREATE TABLE [ComputerClient] (
	[ipv4] nchar(50) PRIMARY KEY,
	[number] int
)

CREATE TABLE [HistoryUsed] (
	[history_id] nchar(50) PRIMARY KEY,
	[time] datetime,
	[username] nchar(50) FOREIGN KEY  REFERENCES [Account] ON UPDATE CASCADE ON DELETE CASCADE,
	[ipv4] nchar(50) FOREIGN KEY  REFERENCES [ComputerClient] ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE [HistoryFood] (
	[history_id] nchar(50) PRIMARY KEY,
	[time] datetime,
	[food_id] nchar(50) FOREIGN KEY  REFERENCES [Food] ON UPDATE CASCADE ON DELETE CASCADE,
	[username] nchar(50) FOREIGN KEY  REFERENCES [Account] ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE [Timer] (
	[timer_id] nchar(50) PRIMARY KEY,
	[time_left] int,
	[money_left] float,
	[username] nchar(50) FOREIGN KEY  REFERENCES [Account] ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE [DetailAccount] (
	[detail_id] nchar(50) PRIMARY KEY,
	[name] nvarchar(50),
	[phone] nchar(20),
	[age] int,
	[cmnd] int,
	[username] nchar(50) FOREIGN KEY  REFERENCES [Account] ON UPDATE CASCADE ON DELETE CASCADE
)

-------------------------------------------------------------------

insert into [Account] values ('admin', 'admin', 1)
insert into [DetailAccount] values ('DA1', 'admin', '999999999', 0, 0, 'admin')
insert into [Timer] values ('T1', 9999999, 9999999, 'admin')
