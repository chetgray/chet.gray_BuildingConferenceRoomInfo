CREATE TABLE [dbo].[ConferenceRoom] (
      [Id]           INT            NOT NULL
        CONSTRAINT [PK_ConferenceRoom_Id] PRIMARY KEY
    , [Name]         NVARCHAR(4000) NULL
    , [BuildingName] NVARCHAR(4000) NULL
    , [Phone]        VARCHAR(8000)  NULL
    , [IsAVCapable]  BIT            NULL
    , [Capacity]     INT            NULL
)
;
