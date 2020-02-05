DROP  DATABASE IF EXISTS Ecommerce;
CREATE DATABASE Ecommerce;
USE Ecommerce;
/*Create three tables two tables joined via linking table*/
/*Create Products table */
CREATE TABLE Products(
			 ProductId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
             Price DOUBLE NOT NULL,
			`Name` VARCHAR(255) NOT NULL,
             Image VARCHAR(250) NOT NULL
);
CREATE INDEX IX_Products_Name ON Products (`Name`);
/*Order*/
CREATE TABLE Orders(
			 OrderId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
			`Date` DATETIME NOT NULL
);
CREATE INDEX IX_Orders_Date ON Orders(Date);
/*Joining Table taht joins two tables such as Product and Orders*/
CREATE TABLE OrderProduct(
			 OrderProductId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
			 ProductId INT NOT NULL,
             OrderId INT NOT NULL,
             CONSTRAINT fk_Products_ProductId FOREIGN KEY (ProductId) REFERENCES Products(ProductId) ON DELETE CASCADE,
             CONSTRAINT fk_Orders_OrderId FOREIGN KEY (OrderId) REFERENCES Orders(OrderId) ON DELETE CASCADE
             
);
CREATE INDEX IX_OrderProduct_OrderProductId ON OrderProduct(OrderProductId);

/*Populate DataBase with data*/
/*There are four different products*/
INSERT INTO Products
			VALUES
            (1,30,"Sumsung","https://picsum.photos/200"),
            (2,20,"Panasonic","https://picsum.photos/300"),
			(3,10,"Nokia","https://picsum.photos/200"),
            (4,25,"Sony","https://picsum.photos/300");
/*THere are four different orders*/
INSERT INTO Orders
			VALUES
            (1,'2009-09-12'),
            (2,'2020-01-23'),
            (3,'2019-03-28'),
            (4,'2018-07-03');
INSERT INTO OrderProduct
			VALUES
            (1,1,4), /*Product Sumsung order number four: Price 30$* (one order with one product)*/
            /*Products Nokia and Sony and order number two: Price 35$ (one order with two products)*/
            (2,4,2), 
            (3,3,2),  
            /*Products Sumsung and Sumsung and different order numbers*/
            (4,1,3),
            (5,1,2),
            /*One order one product*/
            (6,3,1);
/*Lets make query to check our relationship*/
/*Print all product's name and price   based on order #2*/
SELECT Products.`Name`,Price FROM Products 
					RIGHT JOIN OrderProduct Using(ProductId)
                    RIGHT JOIN Orders Using(OrderId)
                    WHERE OrderId=2;
/*Print all orders for specific product(Sumsung)*/
SELECT `Name`,Price,`Date` FROM Products 
						   JOIN OrderProduct Using(ProductId)
						   JOIN Orders Using(OrderId)
						   WHERE `Name`='Sumsung';
            

            
            