USE Car_Service
GO
CREATE PROCEDURE InsertCustomer(
@customerName VARCHAR(200),
@customerSecondName VARCHAR(200),
@customerPhone VARCHAR(200),
@description VARCHAR(500),

@id int output
)

as
BEGIN
	insert into Customers (customerName, customerSecondName, customerPhone, description, createdAt) 
VALUES
	(@customerName, @customerSecondName, @customerPhone, @description, getdate())
	SET @id=SCOPE_IDENTITY()
	SELECT @id
END
