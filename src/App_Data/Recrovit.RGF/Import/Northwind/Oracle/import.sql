
RGF.CMD.InitialCreate.ExecuteSQLFile Northwind.sql
/

RGF.CMD.InitialCreate.Import Northwind/RecroDict_Str_Northwind.json
/

RGF.CMD.InitialCreate.Import oracle_RecroGrid_Entity_1.json
/

RGF.CMD.InitialCreate.Import Northwind/Northwind_Menu.json
/

INSERT INTO RECROTRACK_TABLE (TABLENAME,TABLEKEYS,ENABLED) VALUES ('Products','ProductID','1');
/
