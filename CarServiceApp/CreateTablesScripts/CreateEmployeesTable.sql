CREATE TABLE Employees (
    employeeId INT IDENTITY(1,1) NOT NULL,
    employeeName varchar(200),
    employeeSecondName varchar(200),
    employeePhone varchar(200),
    description varchar(500),
    createdAt DATETIME2 NOT NULL
);