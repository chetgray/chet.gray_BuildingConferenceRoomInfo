﻿USE [BuildingConferenceRoomInfo];
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'db_executor')
BEGIN
    CREATE ROLE [db_executor];
END
GO

GRANT EXECUTE ON SCHEMA :: [dbo] TO [db_executor];
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'BuildingConferenceRoomInfo_User')
BEGIN
    CREATE USER [BuildingConferenceRoomInfo_User] FOR LOGIN [BuildingConferenceRoomInfo_User];
END
GO

EXEC sp_addrolemember N'db_executor', N'BuildingConferenceRoomInfo_User';
GO
