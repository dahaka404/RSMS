CREATE TABLE [dbo].[Table_Booking] (
    [Booking_ID] UNIQUEIDENTIFIER NOT NULL,
    [Table_ID]   UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [FK_Table_Booking_Booking] FOREIGN KEY ([Booking_ID]) REFERENCES [dbo].[Booking] ([ID]),
    CONSTRAINT [FK_Table_Booking_Table] FOREIGN KEY ([Table_ID]) REFERENCES [dbo].[Table] ([ID]), 
    PRIMARY KEY ([Booking_ID], [Table_ID])
);

