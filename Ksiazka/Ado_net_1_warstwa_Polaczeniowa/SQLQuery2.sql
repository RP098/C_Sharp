﻿CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustId] INT NOT NULL, 
    [CarId] INT NOT NULL
)