
RgfCmd.InitialCreate.ExecuteSQLFile Northwind.sql
GO

RgfCmd.InitialCreate.ExecuteSQLFile import-1.0.sql
GO

RgfCmd.IfVersion(Northwind:1.0).ExecuteSQLFile import-1.1.sql
GO
