
RgfCmd.InitialCreate.ExecuteSQLFile Northwind.sql
GO

RgfCmd.InitialCreate.ExecuteSQLFile 1.0/import-1.0.sql
GO

RgfCmd.IfVersion(Northwind:1.0).ExecuteSQLFile 1.1/import-1.1.sql
GO

RgfCmd.IfVersion(Northwind:1.1).ExecuteSQLFile 1.2/import-1.2.sql
GO
