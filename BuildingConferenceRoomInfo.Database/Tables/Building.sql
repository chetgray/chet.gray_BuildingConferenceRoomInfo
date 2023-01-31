CREATE TABLE [dbo].[Building] (
      [Id]                  INT            NOT NULL
        CONSTRAINT [PK_Building_Id] PRIMARY KEY
    , [Name]                NVARCHAR(4000) NOT NULL
    , [AddressStreet]       NVARCHAR(4000) NOT NULL
    , [AddressCity]         NVARCHAR(4000) NOT NULL
    , [AddressState]        NVARCHAR(4000) NOT NULL
    , [AddressZip]          VARCHAR(8000)  NOT NULL
    , [AddressCountry]      NVARCHAR(4000) NOT NULL
    , [MainPhone]           VARCHAR(8000)  NOT NULL
    , [FloorCount]          INT            NOT NULL
    , [ConferenceRoomCount] INT            NOT NULL
)
;
