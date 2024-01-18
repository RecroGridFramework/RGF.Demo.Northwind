
RGF.CMD.InitialCreate.ExecuteSQLFile Northwind.sql
GO

RGF.CMD.InitialCreate.Import Northwind/RecroDict_Str_Northwind.json
GO

INSERT INTO [RecroGrid].[RecroGrid_Framework] (ConfigName,ConfigValue) select 'Northwind', '1.0' WHERE NOT EXISTS (SELECT * FROM [RecroGrid].[RecroGrid_Framework] WHERE ConfigName='Northwind')
GO

RGF.CMD.InitialCreate.Import mssql_RecroGrid_Entity_1.json
GO

RGF.CMD.InitialCreate.Import Northwind/Northwind_Menu.json
GO

IF NOT EXISTS (SELECT * FROM [RecroGrid].[Recrotrack_Table] WHERE TableName='Products')
BEGIN
	INSERT INTO [RecroGrid].[Recrotrack_Table] (TableName,TableKeys,[Enabled]) VALUES ('Products','ProductID','1');
END
GO

RGF.CMD.ExecuteSQLFile.Version{Northwind:1.0} import-1.1.sql
GO
