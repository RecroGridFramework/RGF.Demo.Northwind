
RGF.CMD.Import.Update Northwind/RecroDict_Str_Northwind-1.1.json
GO

UPDATE [RecroGrid].[RecroGrid_Framework] SET ConfigValue='1.1' WHERE ConfigName='Northwind'
GO
