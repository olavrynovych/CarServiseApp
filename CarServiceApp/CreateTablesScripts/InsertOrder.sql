USE Car_Service
GO
CREATE PROCEDURE InsertOrder(
@employeeId INT,
@customerId INT,
@appointmentDate DATETIME,
@orderDetails VARCHAR(500),
@issuesWithCar VARCHAR(500),

@id int output
)

as
BEGIN
	insert into Orders (employeeId, customerId, appointmentDate, orderDetails, issuesWithCar, createdAt) 
VALUES
	(@employeeId, @customerId, @appointmentDate, @orderDetails, @issuesWithCar, getdate())
	SET @id=SCOPE_IDENTITY()
	SELECT @id
END
