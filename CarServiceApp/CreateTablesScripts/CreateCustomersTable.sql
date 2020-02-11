CREATE TABLE Customers (
    customerId INT PRIMARY KEY,
    customerName varchar(200),
    customerSecondName varchar(200),
    customerPhone varchar(200),
    description varchar(500),
    createdAt DATETIME2 NOT NULL
);