CREATE TABLE [dbo].[ConferenceRoom] (
      [Id]           INT            NOT NULL
        CONSTRAINT [PK_ConferenceRoom_Id] PRIMARY KEY
    , [Name]         NVARCHAR(4000) NOT NULL
    , [BuildingName] NVARCHAR(4000) NOT NULL
    , [Phone]        VARCHAR(8000)  NOT NULL
    , [IsAVCapable]  BIT            NOT NULL
    , [Capacity]     INT            NOT NULL
)
;
