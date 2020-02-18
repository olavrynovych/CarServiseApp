CREATE TABLE Customers (
    customerId INT IDENTITY(1,1) NOT NULL,
    customerName varchar(200),
    customerSecondName varchar(200),
    customerPhone varchar(200),
    description varchar(500),
    createdAt DATETIME2 NOT NULL
);