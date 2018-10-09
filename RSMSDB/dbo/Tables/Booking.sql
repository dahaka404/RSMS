CREATE TABLE [dbo].[Booking] (
    [ID]               UNIQUEIDENTIFIER NOT NULL,
    [Contact_Name]     VARCHAR (100)    NOT NULL,
    [Date_Time]        DATETIME         NOT NULL,
    [Party_Number]     INT              NOT NULL,
    [Special_Occasion] BIT              CONSTRAINT [DF_Booking_Special_Occasion] DEFAULT ((0)) NOT NULL,
    [Other_Details]    VARCHAR (100)    NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([ID] ASC)
);

