CREATE PROCEDURE [dbo].[spA_Building_GetAll]
AS

SELECT
      [Building].[Id]                  AS [BuildingId]
    , [Building].[Name]                AS [BuildingName]
    , [Building].[AddressStreet]       AS [BuildingAddressStreet]
    , [Building].[AddressCity]         AS [BuildingAddressCity]
    , [Building].[AddressState]        AS [BuildingAddressState]
    , [Building].[AddressZip]          AS [BuildingAddressZip]
    , [Building].[AddressCountry]      AS [BuildingAddressCountry]
    , [Building].[MainPhone]           AS [BuildingMainPhone]
    , [Building].[FloorCount]          AS [BuildingFloorCount]
    , [Building].[ConferenceRoomCount] AS [BuildingConferenceRoomCount]
FROM
    [Building]
;

RETURN 0
;
