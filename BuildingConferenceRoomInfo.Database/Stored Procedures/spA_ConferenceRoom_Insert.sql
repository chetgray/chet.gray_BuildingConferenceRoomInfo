CREATE PROCEDURE [dbo].[spA_ConferenceRoom_Insert] @conferenceRoomName NVARCHAR(4000)
    , @conferenceRoomBuildingName NVARCHAR(4000)
    , @conferenceRoomPhone VARCHAR(8000)
    , @conferenceRoomIsAVCapable BIT
    , @conferenceRoomCapacity INT
AS
DECLARE @conferenceRoomId INT;

INSERT INTO [ConferenceRoom] (
    [Name]
    , [BuildingName]
    , [Phone]
    , [IsAVCapable]
    , [Capacity]
    )
VALUES (
    @conferenceRoomName
    , @conferenceRoomBuildingName
    , @conferenceRoomPhone
    , @conferenceRoomIsAVCapable
    , @conferenceRoomCapacity
    );

SELECT @conferenceRoomId = @@IDENTITY;

IF OBJECT_ID('tempdb..#__suppress_results_ConferenceRoom_Insert') IS NULL
BEGIN
    SELECT [ConferenceRoom].[Id] AS [ConferenceRoomId]
        , [ConferenceRoom].[Name] AS [ConferenceRoomName]
        , [ConferenceRoom].[BuildingName] AS [ConferenceRoomBuildingName]
        , [ConferenceRoom].[Phone] AS [ConferenceRoomPhone]
        , [ConferenceRoom].[IsAVCapable] AS [ConferenceRoomIsAVCapable]
        , [ConferenceRoom].[Capacity] AS [ConferenceRoomCapacity]
    FROM [ConferenceRoom]
    WHERE [ConferenceRoom].[Id] = @conferenceRoomId;
END

RETURN 0
