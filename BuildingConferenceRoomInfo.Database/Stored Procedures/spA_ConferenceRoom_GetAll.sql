CREATE PROCEDURE [dbo].[spA_ConferenceRoom_GetAll]
AS

SELECT
      [ConferenceRoom].[Id]           AS [ConferenceRoomId]
    , [ConferenceRoom].[Name]         AS [ConferenceRoomName]
    , [ConferenceRoom].[BuildingName] AS [ConferenceRoomBuildingName]
    , [ConferenceRoom].[Phone]        AS [ConferenceRoomPhone]
    , [ConferenceRoom].[IsAVCapable]  AS [ConferenceRoomIsAVCapable]
    , [ConferenceRoom].[Capacity]     AS [ConferenceRoomCapacity]
FROM
    [ConferenceRoom]
;

RETURN 0
;
