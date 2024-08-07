
--Syntax:
--RgfCmd {.IfVersion([name:value])} {.SetVersion([name:value])} { .InitialCreate } { .Info | .ExecuteSQLFile | .Import{ .Replace | .Update } } FileName
--delimiter:
-- Oracle: /
-- PostgreSQL: /*$$*/
-- SQL Server: GO

--IfVersion: version check and execute only if true
--SetVersion: set version number
--Info: write information to the log
--InitialCreate: only runs on the first initialization
--ExecuteSQLFile: execute native SQL
--Import: RGF import (Entities, RGF Menu, RecroDic, RecroSec)
-- Replace: overwrite
-- Update: modify

Examples:

--Execute native SQL statement:
CREATE VIEW [v_employee] AS SELECT e1.*, (CONCAT(e1.FirstName, ' ', e1.LastName)) AS EmployeeName FROM [Employees] e1
GO

--Logging to the log file
RgfCmd.Info "Initializing the Northwind database"
GO

--Run the script only on the first initialization of RecroGridFramework
RgfCmd.InitialCreate.ExecuteSQLFile import-1.0.sql
GO

--Execute SQL file if the "Northwind" version number is equal to 1.0
RgfCmd.IfVersion(Northwind:1.0).ExecuteSQLFile import-1.1.sql
GO

--Import after the first initialization of RGF:
RgfCmd.InitialCreate.Import rgf_entity.json
GO

--Set the version number of "Northwind" to 1.0:
RgfCmd.SetVersion(Northwind:1.0)
GO

--Import if the "Northwind" version number is null
RgfCmd.IfVersion(Northwind:null).Import.Update rgf_entity-1.0.json
GO

--Import if the "Northwind" version number is equal to 1.0
RgfCmd.IfVersion(Northwind:1.0).Import.Update rgf_entity-1.1.json
GO
