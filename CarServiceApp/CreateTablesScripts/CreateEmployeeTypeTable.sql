CREATE TABLE EmployeeType (
    employeeTypeId INT IDENTITY(1,1) NOT NULL,
    	employeeType varchar(20) NOT NULL,
		createdAt DATETIME2 NOT NULL,
	PRIMARY KEY (employeeTypeId),
	  
);

insert into EmployeeType values ('Trainee', GETDATE())
insert into EmployeeType values ('Junior Mechanic', GETDATE())
insert into EmployeeType values ('Mechanic', GETDATE())
insert into EmployeeType values ('Experienced Mechanic', GETDATE())