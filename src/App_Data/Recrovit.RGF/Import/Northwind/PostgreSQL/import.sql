
RgfCmd.InitialCreate.ExecuteSQLFile Northwind.sql
/*$$*/

RgfCmd.InitialCreate.Import Northwind/RecroDict_Str_Northwind.json
/*$$*/

RgfCmd.InitialCreate.Import pgsql_RecroGrid_Entity_1.json
/*$$*/

RgfCmd.InitialCreate.Import Northwind/Northwind_Menu.json
/*$$*/

INSERT INTO recrotrack_table (tablename,tablekeys,enabled) select 'Products','ProductID','1' where NOT EXISTS (SELECT * FROM recrotrack_table WHERE tablename = 'Products');
/*$$*/
