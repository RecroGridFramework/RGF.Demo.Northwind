
RgfCmd.InitialCreate.ExecuteSQLFile Northwind.sql
/

RgfCmd.InitialCreate.Import Northwind/RecroDict_Str_Northwind.json
/

RgfCmd.InitialCreate.Import oracle_RecroGrid_Entity_1.json
/

RgfCmd.InitialCreate.Import Northwind/Northwind_Menu.json
/

INSERT INTO RECROTRACK_TABLE (TABLENAME, TABLEKEYS, ENABLED) SELECT 'Products', 'ProductID', '1' FROM dual WHERE NOT EXISTS (SELECT 1 FROM RECROTRACK_TABLE WHERE TABLENAME = 'Products' AND TABLEKEYS = 'ProductID');
/
