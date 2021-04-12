IF OBJECT_ID ('dbo.ProductExpirations') IS NOT NULL
	DROP TABLE dbo.ProductExpirations
GO

CREATE TABLE dbo.ProductExpirations
	(
	ProductID      NVARCHAR (10),
	ExpirationDate DATETIME,
	CreatedDate    DATETIME,
	UpdatedDate    DATETIME,
	DeletedDate    DATETIME,
	UpdatedBy      VARCHAR (10)
	)
GO

