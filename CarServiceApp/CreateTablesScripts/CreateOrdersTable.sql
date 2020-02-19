CREATE TABLE Orders (
    orderId INT IDENTITY(1,1) NOT NULL,
    employeeId INT NOT NULL,
	customerId INT NOT NULL,
	appointmentDate DATETIME,
	orderDetails varchar(300),
	issuesWithCar varchar(300),
	createdAt DATETIME2 NOT NULL,
	PRIMARY KEY (orderId),
	FOREIGN KEY (customerId) REFERENCES dbo.Customers(customerId),
	FOREIGN KEY (employeeId) REFERENCES dbo.Employees(employeeId)
      
);