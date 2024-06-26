
RgfCmd.Info Init.Northwind-1.1.sql
GO

IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_employee]'))
	DROP VIEW [v_employee]
GO

CREATE VIEW [v_employee] as
    SELECT 
           (Concat(e1.FirstName, ' ', e1.LastName)) as EmployeeName,
           (select count(*) from orders where EmployeeID=e1.EmployeeID) as OrdersCount,
		   e1.*
    FROM Employees e1
GO

RgfCmd.Import.Update rgf_entity-1.1.json
GO

RgfCmd.SetVersion(Northwind:1.1)
GO
