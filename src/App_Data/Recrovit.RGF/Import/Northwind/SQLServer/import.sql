
RgfCmd.InitialCreate.ExecuteSQLFile Northwind.sql
GO

RgfCmd.InitialCreate.Import Northwind/northwind_menu.json
GO

RgfCmd.IfVersion(Northwind:null).ExecuteSQLFile 1.0/import-1.0.sql
GO

RgfCmd.IfVersion(Northwind:1.0).ExecuteSQLFile 1.1/import-1.1.sql
GO

RgfCmd.IfVersion(Northwind:1.1).ExecuteSQLFile 1.2/import-1.2.sql
GO

RgfCmd.IfVersion(Northwind:1.2).ExecuteSQLFile 1.3/import-1.3.sql
GO

RgfCmd.IfVersion(Northwind:1.3).ExecuteSQLFile 1.4/import-1.4.sql
GO
