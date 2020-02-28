CREATE TABLE Employees (
    employeeId INT IDENTITY(1,1) NOT NULL,
    Name varchar(200) NOT NULL,
    SecondName varchar(200) NOT NULL,
    PhoneNumber varchar(200),
    description varchar(500),
    createdAt DATETIME2 NOT NULL,
    Salary dec(4,2),
    employeeTypeId int NOT NULL,
    FOREIGN KEY (employeeTypeId) REFERENCES EmployeeType(employeeTypeId)
);