
RGF.CMD.InitialCreate.ExecuteSQLFile Northwind.sql
/

RGF.CMD.InitialCreate.Import Northwind/RecroDict_Str_Northwind.json
/

RGF.CMD.InitialCreate.Import oracle_RecroGrid_Entity_1.json
/

RGF.CMD.InitialCreate.Import Northwind/Northwind_Menu.json
/

INSERT INTO RECROTRACK_TABLE (TABLENAME, TABLEKEYS, ENABLED) SELECT 'Products', 'ProductID', '1' FROM dual WHERE NOT EXISTS (SELECT 1 FROM RECROTRACK_TABLE WHERE TABLENAME = 'Products' AND TABLEKEYS = 'ProductID');
/
