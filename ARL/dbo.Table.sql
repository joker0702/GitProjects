CREATE TABLE [dbo].[LogbookData]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Callsign] NCHAR(10) NULL, 
    [Name] NCHAR(30) NULL, 
    [QTH] NCHAR(30) NULL, 
    [Frequenzy] NCHAR(20) NULL, 
    [Mode] NCHAR(6) NULL, 
    [QSO Date] DATE NULL, 
    [Time On] DATETIME NULL, 
    [Time Off] DATETIME NULL
)
