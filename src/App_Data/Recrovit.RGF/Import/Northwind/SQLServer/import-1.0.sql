
RgfCmd.InitialCreate.Import Northwind/RecroDict_Str_Northwind.json
GO

RgfCmd.InitialCreate.Import mssql_recroGrid_entity_1.json
GO

RgfCmd.InitialCreate.Import Northwind/northwind_menu.json
GO

INSERT INTO [RecroGrid].[Recrotrack_Table] (TableName,TableKeys,[Enabled]) select 'Products','ProductID','1' WHERE NOT EXISTS (SELECT * FROM [RecroGrid].[Recrotrack_Table] WHERE TableName='Products')
GO

RgfCmd.InitialCreate.SetVersion(Northwind:1.0)
GO
