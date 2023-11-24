
RGF.CMD.ExecuteSQLFile Northwind.sql
GO

RGF.CMD.Import.Replace Northwind/RecroDict_Str_Northwind.json
GO

RGF.CMD.Import.Replace mssql_RecroGrid_Entity_1.json
GO

RGF.CMD.Import Northwind/Northwind_Menu.json
GO

IF NOT EXISTS (SELECT * FROM [RecroGrid].[Recrotrack_Table] WHERE TableName='Products')
BEGIN
	INSERT INTO [RecroGrid].[Recrotrack_Table] (TableName,TableKeys,[Enabled]) VALUES ('Products','ProductID','1');
END
GO
