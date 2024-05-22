
RgfCmd.Import Northwind/RecroDict_Str_Northwind.json
GO

RgfCmd.Import mssql_rgf_entity_1.json
GO

INSERT INTO [RecroGrid].[Recrotrack_Table] (TableName,TableKeys,[Enabled]) select 'Products','ProductID','1' WHERE NOT EXISTS (SELECT * FROM [RecroGrid].[Recrotrack_Table] WHERE TableName='Products')
GO

RgfCmd.SetVersion(Northwind:1.0)
GO
