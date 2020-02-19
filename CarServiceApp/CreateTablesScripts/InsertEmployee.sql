USE Car_Service
GO
CREATE PROCEDURE InsertEmployee(
@employeeName VARCHAR(200),
@employeeSecondName VARCHAR(200),
@employeePhone VARCHAR(200),
@description VARCHAR(500),

@id int output
)

as
BEGIN
	insert into Employees (employeeName, employeeSecondName, employeePhone, description, createdAt) 
VALUES
	(@employeeName, @employeeSecondName, @employeePhone, @description, getdate())
	SET @id=SCOPE_IDENTITY()
	SELECT @id
END
