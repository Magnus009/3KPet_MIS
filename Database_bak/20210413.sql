IF OBJECT_ID ('dbo.ProductInventory') IS NOT NULL
	DROP TABLE dbo.ProductInventory
GO

CREATE TABLE dbo.ProductInventory
	(
	BatchNo        INT NOT NULL,
	ProductID      NVARCHAR (10) NOT NULL,
	TotalQTY       INT,
	Stocks         INT,
	Price          NUMERIC (18, 2),
	ExpirationDate DATETIME,
	CreatedDate    DATETIME,
	UpdatedDate    DATETIME,
	DeletedDate    DATETIME,
	UpdatedBy      VARCHAR (10),
	PRIMARY KEY (ProductID, BatchNo)
	)
GO


INSERT INTO dbo.ProductInventory (BatchNo, ProductID, TotalQTY, Stocks, Price, ExpirationDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'PI21030001', 10, 0, 500, '2021-12-13 14:47:38', '2021-04-13 14:54:18.913', '2021-04-13 14:54:18.913', NULL, '')
GO

