USE Car_Service
GO
CREATE or alter PROCEDURE SelectOrdersForMainView


AS
BEGIN


	SELECT customerName + ' ' + customerSecondName AS[Full Customer Name],
	employeeName + ' ' + employeeSecondName+' - ' + dbo.EmployeeType.employeeType AS[Full Employee Name and Position],
	appointmentDate as [Appointment Date], 
	orderDetails as [Order Details], 
	issuesWithCar as [Issues With Car], 
	dbo.Orders.createdAt as [Created]

FROM dbo.Orders inner join dbo.Employees on dbo.Employees.employeeId = dbo.Orders.employeeId 
inner join dbo.Customers on dbo.Orders.customerId= dbo.Customers.customerId
inner join dbo.EmployeeType on dbo.EmployeeType.employeeTypeId=dbo.Employees.employeeTypeId


END
GO