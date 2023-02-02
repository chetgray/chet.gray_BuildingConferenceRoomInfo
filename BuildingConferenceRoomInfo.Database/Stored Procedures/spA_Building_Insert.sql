CREATE PROCEDURE [dbo].[spA_Building_Insert] @buildingName NVARCHAR(4000)
    , @buildingAddressStreet NVARCHAR(4000)
    , @buildingAddressCity NVARCHAR(4000)
    , @buildingAddressState NVARCHAR(4000)
    , @buildingAddressZip VARCHAR(8000)
    , @buildingAddressCountry NVARCHAR(4000)
    , @buildingMainPhone VARCHAR(8000)
    , @buildingFloorCount INT
    , @buildingConferenceRoomCount INT
AS
DECLARE @buildingId INT;

INSERT INTO [Building] (
    [Name]
    , [AddressStreet]
    , [AddressCity]
    , [AddressState]
    , [AddressZip]
    , [AddressCountry]
    , [MainPhone]
    , [FloorCount]
    , [ConferenceRoomCount]
    )
VALUES (
    @buildingName
    , @buildingAddressStreet
    , @buildingAddressCity
    , @buildingAddressState
    , @buildingAddressZip
    , @buildingAddressCountry
    , @buildingMainPhone
    , @buildingFloorCount
    , @buildingConferenceRoomCount
    );

SELECT @buildingId = @@IDENTITY;

IF OBJECT_ID('tempdb..#__suppress_results_Building_Insert') IS NULL
BEGIN
    SELECT [Building].[Id] AS [BuildingId]
        , [Building].[Name] AS [BuildingName]
        , [Building].[AddressStreet] AS [BuildingAddressStreet]
        , [Building].[AddressCity] AS [BuildingAddressCity]
        , [Building].[AddressState] AS [BuildingAddressState]
        , [Building].[AddressZip] AS [BuildingAddressZip]
        , [Building].[AddressCountry] AS [BuildingAddressCountry]
        , [Building].[MainPhone] AS [BuildingMainPhone]
        , [Building].[FloorCount] AS [BuildingFloorCount]
        , [Building].[ConferenceRoomCount] AS [BuildingConferenceRoomCount]
    FROM [Building]
    WHERE [Building].[Id] = @buildingId;
END

RETURN 0
