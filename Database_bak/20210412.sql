SELECT TH.VisitDate, TH.TransactionID, PR.Product 'ProductName', PR.QTY 'ProductQTY',
VX.Vaccine, VX.QTY 'VXQTY', T.TRDescription 'Treatment', 
TH.ProductAmount, TH.ServicesAmount, TH.DiscountedAmount, TH.TotalAmount FROM TransactionHeader TH
INNER JOIN TransactionDetails TD ON TH.TransactionID = TD.TransactionID
LEFT JOIN Treatments T ON TD.Treatment = T.TRID
LEFT JOIN (
	SELECT PP.TransactionID, P.ProductID, P.Description 'Product', PP.QTY, PP.TotatlPrice FROM PurschasedProducts PP
	INNER JOIN Products P ON PP.ProductID = P.ProductID
	AND P.TypeID <> 2
) AS PR ON TD.TransactionID = PR.TransactionID
LEFT JOIN (
	SELECT PP.TransactionID, P.ProductID, P.Description 'Vaccine', PP.QTY, PP.TotatlPrice FROM PurschasedProducts PP
	INNER JOIN Products P ON PP.ProductID = P.ProductID
	AND P.TypeID = 2
) AS VX ON TD.TransactionID = VX.TransactionID


IF OBJECT_ID ('dbo.ProductInventory') IS NOT NULL
	DROP TABLE dbo.ProductInventory
GO

CREATE TABLE dbo.ProductInventory
	(
	BatchNo        INT NOT NULL,
	ProductID      NVARCHAR (10) NOT NULL,
	TotalQTY       INT NULL,
	Stocks         INT NULL,
	Price          NUMERIC (18, 2) NULL,
	ExpirationDate DATETIME NULL,
	CreatedDate    DATETIME NULL,
	UpdatedDate    DATETIME NULL,
	DeletedDate    DATETIME NULL,
	UpdatedBy      VARCHAR (10) NULL,
	PRIMARY KEY (ProductID, BatchNo)
	)
GO

INSERT INTO dbo.ProductInventory (BatchNo, ProductID, TotalQTY, Stocks, Price, ExpirationDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'PI21030002', 12, 11, 1000, NULL, '2021-03-26 10:41:58.633', '2021-03-26 10:41:58.633', NULL, '')
GO

INSERT INTO dbo.ProductInventory (BatchNo, ProductID, TotalQTY, Stocks, Price, ExpirationDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'PI21030003', 10, 9, 1000, NULL, '2021-03-26 10:42:22.373', '2021-03-26 10:42:22.373', NULL, '')
GO

INSERT INTO dbo.ProductInventory (BatchNo, ProductID, TotalQTY, Stocks, Price, ExpirationDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'PI21030004', 10, 10, 1300, NULL, '2021-03-26 10:42:35.36', '2021-03-26 11:04:56.57', NULL, '')
GO

INSERT INTO dbo.ProductInventory (BatchNo, ProductID, TotalQTY, Stocks, Price, ExpirationDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'PI21030005', 10, 10, 500, NULL, '2021-03-26 10:42:43.79', '2021-03-26 10:42:43.79', NULL, '')
GO

INSERT INTO dbo.ProductInventory (BatchNo, ProductID, TotalQTY, Stocks, Price, ExpirationDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (0, 'PI21030006', 12, 6, 200, NULL, '2021-03-26 15:19:36.777', '2021-03-26 15:19:36.777', NULL, '')
GO

INSERT INTO dbo.ProductInventory (BatchNo, ProductID, TotalQTY, Stocks, Price, ExpirationDate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'PI21040001', 12, 0, 50, NULL, '2021-04-12 19:16:12.07', '2021-04-12 19:16:12.07', NULL, 'US21030002')
GO


sELECT TH.VisitDate, TH.TransactionID, PR.Product 'ProductName', PR.QTY 'ProductQTY',
VX.Vaccine, VX.QTY 'VXQTY', TH.ProductAmount, TH.ServicesAmount, TH.DiscountedAmount, 
TH.TotalAmount FROM TransactionHeader TH
INNER JOIN TransactionDetails TD ON TH.TransactionID = TD.TransactionID
LEFT JOIN (
	SELECT PP.TransactionID, P.ProductID, P.Description 'Product', PP.QTY, PP.TotatlPrice FROM PurschasedProducts PP
	INNER JOIN Products P ON PP.ProductID = P.ProductID
	AND P.TypeID <> 2
) AS PR ON TD.TransactionID = PR.TransactionID
LEFT JOIN (
	SELECT PP.TransactionID, P.ProductID, P.Description 'Vaccine', PP.QTY, PP.TotatlPrice FROM PurschasedProducts PP
	INNER JOIN Products P ON PP.ProductID = P.ProductID
	AND P.TypeID = 2
) AS VX ON TD.TransactionID = VX.TransactionID