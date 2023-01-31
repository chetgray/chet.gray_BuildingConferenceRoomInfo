CREATE TABLE [dbo].[Building] (
      [Id]                  INT            NOT NULL
        CONSTRAINT [PK_Building_Id] PRIMARY KEY
    , [Name]                NVARCHAR(4000) NULL
    , [AddressStreet]       NVARCHAR(4000) NULL
    , [AddressCity]         NVARCHAR(4000) NULL
    , [AddressState]        NVARCHAR(4000) NULL
    , [AddressZip]          VARCHAR(8000)  NULL
    , [AddressCountry]      NVARCHAR(4000) NULL
    , [MainPhone]           VARCHAR(8000)  NULL
    , [FloorCount]          INT            NULL
    , [ConferenceRoomCount] INT            NULL
)
;
