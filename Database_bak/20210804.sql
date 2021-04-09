IF OBJECT_ID ('dbo._tbl_info') IS NOT NULL
	DROP TABLE dbo._tbl_info
GO

CREATE TABLE dbo._tbl_info
	(
	tbl_ID         VARCHAR (1) NOT NULL,
	tbl_name       VARCHAR (50) NOT NULL,
	tbl_colID_name VARCHAR (50) NOT NULL,
	colID_Prefix   VARCHAR (2) NOT NULL
	)
GO


INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('A', 'Accounts', 'AccountID', 'US')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('O', 'Owners', 'OwnerID', 'OW')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('U', 'Users', 'UserID', 'US')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('P', 'Pets', 'PetID', 'PT')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('S', 'Schedules', 'ScheduleCode', 'SD')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('T', 'TransactionHeader', 'TransactionID', 'TH')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('I', 'Products', 'ProductID', 'PI')
GO

INSERT INTO dbo._tbl_info (tbl_ID, tbl_name, tbl_colID_name, colID_Prefix)
VALUES ('V', 'Services', 'ServiceID', 'SV')
GO

IF OBJECT_ID ('dbo.Accounts') IS NOT NULL
	DROP TABLE dbo.Accounts
GO

CREATE TABLE dbo.Accounts
	(
	AccountID    NVARCHAR (10) NOT NULL,
	UserName     VARCHAR (20),
	Password     VARCHAR (20),
	UserLevel    VARCHAR (10),
	Q1           VARCHAR (5),
	Q2           VARCHAR (5),
	A1           VARCHAR (200),
	A2           VARCHAR (200),
	isDeactivate BIT,
	CreatedDate  DATETIME,
	UpdatedDate  DATETIME,
	DeletedDate  DATETIME,
	UpdatedBy    VARCHAR (10),
	PRIMARY KEY (AccountID)
	)
GO
INSERT INTO dbo.Accounts (AccountID, UserName, Password, UserLevel, Q1, Q2, A1, A2, isDeactivate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('US21030002', 'master', 'master', '1', '2', '1', 'a', 'b', 0, '2021-03-25 07:48:34.04', '2021-03-25 07:48:34.04', NULL, 'US21030002')
GO

INSERT INTO dbo.Accounts (AccountID, UserName, Password, UserLevel, Q1, Q2, A1, A2, isDeactivate, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('US21030003', 'staff', 'staff', '2', '1', '1', 'b', 'c', 0, '2021-03-27 06:19:44.657', '2021-04-06 12:34:54.607', NULL, 'US21030003')
GO



IF OBJECT_ID ('dbo.Actions') IS NOT NULL
	DROP TABLE dbo.Actions
GO

CREATE TABLE dbo.Actions
	(
	ActionID    INT NOT NULL,
	Description VARCHAR (50),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   NVARCHAR (10),
	PRIMARY KEY (ActionID)
	)
GO


INSERT INTO dbo.Actions (ActionID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (1, 'Create', '2021-03-02 15:19:36.27', '2021-03-02 15:19:36.27', NULL, NULL)
GO

INSERT INTO dbo.Actions (ActionID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (2, 'Update', '2021-03-02 15:19:42.52', '2021-03-02 15:19:42.52', NULL, NULL)
GO

INSERT INTO dbo.Actions (ActionID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (3, 'Delete', '2021-03-02 15:19:50.067', '2021-03-02 15:19:50.067', NULL, NULL)
GO

INSERT INTO dbo.Actions (ActionID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (4, 'Login', '2021-03-02 15:20:02.153', '2021-03-02 15:20:02.153', NULL, NULL)
GO

INSERT INTO dbo.Actions (ActionID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (5, 'Logout', '2021-03-02 15:20:11.797', '2021-03-02 15:20:11.797', NULL, NULL)
GO

INSERT INTO dbo.Actions (ActionID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (6, 'Activate', '2021-03-02 15:20:19.98', '2021-03-02 15:20:19.98', NULL, NULL)
GO

INSERT INTO dbo.Actions (ActionID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES (7, 'Deactivate', '2021-03-02 15:20:29.093', '2021-03-02 15:20:29.093', NULL, NULL)
GO

IF OBJECT_ID ('dbo.LogHistories') IS NOT NULL
	DROP TABLE dbo.LogHistories
GO

CREATE TABLE dbo.LogHistories
	(
	Seq         INT IDENTITY NOT NULL,
	UserID      NVARCHAR (10),
	ActionDate  DATETIME,
	ActionID    INT,
	Remarks     VARCHAR (200),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   NVARCHAR (10),
	PRIMARY KEY (Seq)
	)
GO



IF OBJECT_ID ('dbo.M_SecurityQuestion') IS NOT NULL
	DROP TABLE dbo.M_SecurityQuestion
GO

CREATE TABLE dbo.M_SecurityQuestion
	(
	QuestionID  INT IDENTITY NOT NULL,
	Question    VARCHAR (1000),
	CreatedDate DATETIME,
	UpdateDate  DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (QuestionID)
	)
GO


INSERT INTO dbo.M_SecurityQuestion (Question, CreatedDate, UpdateDate, DeletedDate, UpdatedBy)
VALUES ('A', '2021-02-10 14:19:27.94', '2021-02-10 14:19:27.94', NULL, 'script')
GO

INSERT INTO dbo.M_SecurityQuestion (Question, CreatedDate, UpdateDate, DeletedDate, UpdatedBy)
VALUES ('B', '2021-02-10 14:19:28.04', '2021-02-10 14:19:28.04', NULL, 'script')
GO

INSERT INTO dbo.M_SecurityQuestion (Question, CreatedDate, UpdateDate, DeletedDate, UpdatedBy)
VALUES ('C', '2021-02-10 14:19:28.043', '2021-02-10 14:19:28.043', NULL, 'script')
GO

INSERT INTO dbo.M_SecurityQuestion (Question, CreatedDate, UpdateDate, DeletedDate, UpdatedBy)
VALUES ('D', '2021-02-10 14:19:28.043', '2021-02-10 14:19:28.043', NULL, 'script')
GO

INSERT INTO dbo.M_SecurityQuestion (Question, CreatedDate, UpdateDate, DeletedDate, UpdatedBy)
VALUES ('E', '2021-02-10 14:19:28.043', '2021-02-10 14:19:28.043', NULL, 'script')
GO

IF OBJECT_ID ('dbo.Owners') IS NOT NULL
	DROP TABLE dbo.Owners
GO

CREATE TABLE dbo.Owners
	(
	OwnerID     NVARCHAR (10) NOT NULL,
	LastName    VARCHAR (50),
	FirstName   VARCHAR (50),
	Address     VARCHAR (500),
	ContactNo   VARCHAR (20),
	CreatedDate DATETIME,
	UpdateDate  DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (OwnerID)
	)
GO

INSERT INTO dbo.Owners (OwnerID, LastName, FirstName, Address, ContactNo, CreatedDate, UpdateDate, DeletedDate, UpdatedBy)
VALUES ('OW21040001', 'Ackerman', 'Mikasa', 'Paradis', '1234567', '2021-04-05 12:37:37.407', '2021-04-05 12:37:37.407', NULL, '')
GO

IF OBJECT_ID ('dbo.Pets') IS NOT NULL
	DROP TABLE dbo.Pets
GO

CREATE TABLE dbo.Pets
	(
	PetID       NVARCHAR (10) NOT NULL,
	OwnerID     NVARCHAR (10) NOT NULL,
	Name        VARCHAR (200),
	Breed       VARCHAR (500),
	PetColor    VARCHAR (20),
	Age         NVARCHAR (5),
	Gender      VARCHAR (2),
	Birthday    DATETIME,
	isDeceased  BIT,
	CreatedDate DATETIME,
	UpdateDate  DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (PetID, OwnerID)
	)
GO

INSERT INTO dbo.Pets (PetID, OwnerID, Name, Breed, PetColor, Age, Gender, Birthday, isDeceased, CreatedDate, UpdateDate, DeletedDate, UpdatedBy)
VALUES ('PT21040001', 'OW21040001', 'Mikmik', 'Shih Tzu', 'White/Brown', '0.3', 'M', '2020-12-07', 0, '2021-04-05 12:37:38.247', '2021-04-06 07:01:46.46', NULL, '')
GO



IF OBJECT_ID ('dbo.ProductInventory') IS NOT NULL
	DROP TABLE dbo.ProductInventory
GO

CREATE TABLE dbo.ProductInventory
	(
	ProductID   NVARCHAR (10) NOT NULL,
	TotalQTY    INT,
	Stocks      INT,
	Price       NUMERIC (18, 2),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (ProductID)
	)
GO

INSERT INTO dbo.ProductInventory (ProductID, TotalQTY, Stocks, Price, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030001', 12, 12, 300, '2021-03-26 10:41:37.56', '2021-04-06 12:05:09.99', NULL, '')
GO

INSERT INTO dbo.ProductInventory (ProductID, TotalQTY, Stocks, Price, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030002', 12, 11, 1000, '2021-03-26 10:41:58.633', '2021-03-26 10:41:58.633', NULL, '')
GO

INSERT INTO dbo.ProductInventory (ProductID, TotalQTY, Stocks, Price, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030003', 10, 9, 1000, '2021-03-26 10:42:22.373', '2021-03-26 10:42:22.373', NULL, '')
GO

INSERT INTO dbo.ProductInventory (ProductID, TotalQTY, Stocks, Price, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030004', 10, 10, 1300, '2021-03-26 10:42:35.36', '2021-03-26 11:04:56.57', NULL, '')
GO

INSERT INTO dbo.ProductInventory (ProductID, TotalQTY, Stocks, Price, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030005', 10, 10, 500, '2021-03-26 10:42:43.79', '2021-03-26 10:42:43.79', NULL, '')
GO

INSERT INTO dbo.ProductInventory (ProductID, TotalQTY, Stocks, Price, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030006', 12, 8, 200, '2021-03-26 15:19:36.777', '2021-03-26 15:19:36.777', NULL, '')
GO

IF OBJECT_ID ('dbo.Products') IS NOT NULL
	DROP TABLE dbo.Products
GO

CREATE TABLE dbo.Products
	(
	ProductID   NVARCHAR (10) NOT NULL,
	Description VARCHAR (200),
	TypeID      NVARCHAR (5),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (ProductID)
	)
GO
INSERT INTO dbo.Products (ProductID, Description, TypeID, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030001', '2 in 1', '2', '2021-03-26 10:41:37.54', '2021-04-06 12:05:09.92', NULL, '')
GO

INSERT INTO dbo.Products (ProductID, Description, TypeID, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030002', '9 in 1', '2', '2021-03-26 10:41:58.52', '2021-03-26 10:41:58.52', NULL, '')
GO

INSERT INTO dbo.Products (ProductID, Description, TypeID, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030003', 'K/C', '2', '2021-03-26 10:42:22.35', '2021-03-26 10:42:22.35', NULL, '')
GO

INSERT INTO dbo.Products (ProductID, Description, TypeID, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030004', 'R', '2', '2021-03-26 10:42:35.35', '2021-03-26 11:04:56.51', NULL, '')
GO

INSERT INTO dbo.Products (ProductID, Description, TypeID, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030005', 'M', '2', '2021-03-26 10:42:43.717', '2021-03-26 10:42:43.717', NULL, '')
GO

INSERT INTO dbo.Products (ProductID, Description, TypeID, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('PI21030006', 'Shampoo', '1', '2021-03-26 15:19:36.757', '2021-03-26 15:19:36.757', NULL, '')
GO

IF OBJECT_ID ('dbo.ProductTypes') IS NOT NULL
	DROP TABLE dbo.ProductTypes
GO

CREATE TABLE dbo.ProductTypes
	(
	TypeID      INT IDENTITY NOT NULL,
	Description VARCHAR (200),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (TypeID)
	)
GO

INSERT INTO dbo.ProductTypes (Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('For Grooming', '2021-03-26 10:24:40.703', '2021-03-26 10:24:40.703', NULL, 'admin')
GO

INSERT INTO dbo.ProductTypes (Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('Vaccine', '2021-03-26 10:24:50.47', '2021-03-26 10:24:50.47', NULL, 'admin')
GO

INSERT INTO dbo.ProductTypes (Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('test', '2021-03-29 12:42:18.167', '2021-03-29 12:42:18.167', NULL, '')
GO

IF OBJECT_ID ('dbo.PurschasedProducts') IS NOT NULL
	DROP TABLE dbo.PurschasedProducts
GO

CREATE TABLE dbo.PurschasedProducts
	(
	TransactionID NVARCHAR (10),
	ProductID     NVARCHAR (10),
	QTY           INT,
	TotatlPrice   NUMERIC (18, 2),
	CreatedDate   DATETIME,
	UpdatedDate   DATETIME,
	DeletedDate   DATETIME,
	UpdatedBy     VARCHAR (10)
	)
GO



INSERT INTO dbo.PurschasedProducts (TransactionID, ProductID, QTY, TotatlPrice, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21030001', 'PI21030006', 1, 200, '2021-03-30 09:19:58.797', '2021-03-30 09:19:58.797', NULL, '')
GO

INSERT INTO dbo.PurschasedProducts (TransactionID, ProductID, QTY, TotatlPrice, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21030002', 'PI21030005', 1, 500, '2021-03-30 09:21:18.263', '2021-03-30 09:21:18.263', NULL, '')
GO

INSERT INTO dbo.PurschasedProducts (TransactionID, ProductID, QTY, TotatlPrice, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21040001', 'PI21030002', 1, 1000, '2021-04-05 12:40:21.103', '2021-04-05 12:40:21.103', NULL, '')
GO

INSERT INTO dbo.PurschasedProducts (TransactionID, ProductID, QTY, TotatlPrice, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21040001', 'PI21030006', 1, 200, '2021-04-05 12:40:21.15', '2021-04-05 12:40:21.15', NULL, '')
GO

INSERT INTO dbo.PurschasedProducts (TransactionID, ProductID, QTY, TotatlPrice, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21040002', 'PI21030003', 1, 1000, '2021-04-07 10:26:33.42', '2021-04-07 10:26:33.42', NULL, '')
GO

INSERT INTO dbo.PurschasedProducts (TransactionID, ProductID, QTY, TotatlPrice, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21040002', 'PI21030006', 1, 200, '2021-04-07 10:26:33.45', '2021-04-07 10:26:33.45', NULL, '')
GO

IF OBJECT_ID ('dbo.Schedules') IS NOT NULL
	DROP TABLE dbo.Schedules
GO

CREATE TABLE dbo.Schedules
	(
	ScheduleCode NVARCHAR (10) NOT NULL,
	CustomerID   NVARCHAR (10),
	ScheduleDate DATETIME,
	ServiceID    NVARCHAR (10),
	Purpose      VARCHAR (500),
	isArrived    BIT,
	isCancelled  BIT,
	CreatedDate  DATETIME,
	UpdatedDate  DATETIME,
	DeletedDate  DATETIME,
	UpdatedBy    VARCHAR (10),
	PRIMARY KEY (ScheduleCode)
	)
GO


INSERT INTO dbo.Schedules (ScheduleCode, CustomerID, ScheduleDate, ServiceID, Purpose, isArrived, isCancelled, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('SD21040001', 'OW21040001', '2021-04-06', 'SV21040001', 'test', 1, 0, '2021-04-06 12:40:17', '2021-04-06 14:10:53.923', NULL, '')
GO

INSERT INTO dbo.Schedules (ScheduleCode, CustomerID, ScheduleDate, ServiceID, Purpose, isArrived, isCancelled, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('SD21040002', 'OW21040001', '2021-04-07', 'SV21040001', 'test', 0, 0, '2021-04-07 10:26:10.66', '2021-04-07 13:29:44.257', NULL, '')
GO

IF OBJECT_ID ('dbo.Services') IS NOT NULL
	DROP TABLE dbo.Services
GO

CREATE TABLE dbo.Services
	(
	ServiceID   NVARCHAR (10) NOT NULL,
	Description VARCHAR (200),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (ServiceID)
	)
GO

INSERT INTO dbo.Services (ServiceID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('SV21040001', 'Treatments', '2021-04-01 23:44:24.107', '2021-04-01 23:44:24.107', NULL, 'US21030002')
GO

INSERT INTO dbo.Services (ServiceID, Description, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('SV21040002', 'Vaccines', '2021-04-01 23:44:32.687', '2021-04-01 23:44:32.687', NULL, 'US21030002')
GO


IF OBJECT_ID ('dbo.TransactionDetails') IS NOT NULL
	DROP TABLE dbo.TransactionDetails
GO

CREATE TABLE dbo.TransactionDetails
	(
	Seq           INT IDENTITY NOT NULL,
	TransactionID NVARCHAR (10) NOT NULL,
	Treatment     NVARCHAR (5),
	Vaccine       NVARCHAR (5),
	CreatedDate   DATETIME,
	UpdatedDate   DATETIME,
	DeletedDate   DATETIME,
	UpdatedBy     NVARCHAR (10),
	PRIMARY KEY (TransactionID, Seq)
	)
GO


INSERT INTO dbo.TransactionDetails (TransactionID, Treatment, Vaccine, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21040001', '1', NULL, '2021-04-05 12:40:21.08', '2021-04-05 12:40:21.08', NULL, '')
GO

INSERT INTO dbo.TransactionDetails (TransactionID, Treatment, Vaccine, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21040002', '3', NULL, '2021-04-07 10:26:33.403', '2021-04-07 10:26:33.403', NULL, '')
GO

IF OBJECT_ID ('dbo.TransactionHeader') IS NOT NULL
	DROP TABLE dbo.TransactionHeader
GO

CREATE TABLE dbo.TransactionHeader
	(
	TransactionID    NVARCHAR (10) NOT NULL,
	OwnerID          NVARCHAR (10),
	PetID            NVARCHAR (10),
	VisitDate        DATETIME,
	WT               NUMERIC (18, 2),
	Temp             NUMERIC (18, 2),
	Diagnostic       VARCHAR (2000),
	Others           VARCHAR (2000),
	ProductAmount    NUMERIC (18, 2),
	ServicesAmount   NUMERIC (18, 2),
	DiscountedAmount NUMERIC (18, 2),
	TotalAmount      NUMERIC (18, 2),
	NextVisit        DATETIME,
	CreatedDate      DATETIME,
	UpdatedDate      DATETIME,
	DeletedDate      DATETIME,
	UpdatedBy        VARCHAR (10),
	PRIMARY KEY (TransactionID)
	)
GO


INSERT INTO dbo.TransactionHeader (TransactionID, OwnerID, PetID, VisitDate, WT, Temp, Diagnostic, Others, ProductAmount, ServicesAmount, DiscountedAmount, TotalAmount, NextVisit, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21040001', 'OW21040001', 'PT21040001', '2021-04-05', 2, 38, 'Fever', NULL, 1200, 500, 200, 1000, '2021-04-05', '2021-04-05 12:40:21.2', '2021-04-06 14:12:23.233', NULL, '')
GO

INSERT INTO dbo.TransactionHeader (TransactionID, OwnerID, PetID, VisitDate, WT, Temp, Diagnostic, Others, ProductAmount, ServicesAmount, DiscountedAmount, TotalAmount, NextVisit, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('TH21040002', 'OW21040001', 'PT21040001', '2021-04-07', 2, 35, 'Treatment', NULL, 1200, 600, NULL, 1800, '2021-04-07', '2021-04-07 10:26:33.503', '2021-04-07 10:26:33.503', NULL, '')
GO

IF OBJECT_ID ('dbo.Treatments') IS NOT NULL
	DROP TABLE dbo.Treatments
GO

CREATE TABLE dbo.Treatments
	(
	TRID          INT IDENTITY NOT NULL,
	TRDescription VARCHAR (100),
	Price         NUMERIC (18, 2),
	CreatedDate   DATETIME,
	UpdatedDAte   DATETIME,
	DeletedDate   DATETIME,
	UpdatedBy     NVARCHAR (10),
	PRIMARY KEY (TRID)
	)
GO


INSERT INTO dbo.Treatments (TRDescription, Price, CreatedDate, UpdatedDAte, DeletedDate, UpdatedBy)
VALUES ('Deworm', 500, '2021-03-01 12:36:08.39', '2021-03-11 13:37:16.06', NULL, '')
GO

INSERT INTO dbo.Treatments (TRDescription, Price, CreatedDate, UpdatedDAte, DeletedDate, UpdatedBy)
VALUES ('Bra', 1000, '2021-03-01 12:44:47.303', '2021-03-01 12:44:47.303', NULL, NULL)
GO

INSERT INTO dbo.Treatments (TRDescription, Price, CreatedDate, UpdatedDAte, DeletedDate, UpdatedBy)
VALUES ('Bela', 600, '2021-03-01 12:44:56.383', '2021-03-01 12:44:56.383', NULL, NULL)
GO

INSERT INTO dbo.Treatments (TRDescription, Price, CreatedDate, UpdatedDAte, DeletedDate, UpdatedBy)
VALUES ('Bac', 500, '2021-03-01 12:45:15.197', '2021-03-01 12:45:15.197', NULL, NULL)
GO

INSERT INTO dbo.Treatments (TRDescription, Price, CreatedDate, UpdatedDAte, DeletedDate, UpdatedBy)
VALUES ('Bay', 500, '2021-03-01 12:45:22.657', '2021-03-01 12:45:22.657', NULL, NULL)
GO

INSERT INTO dbo.Treatments (TRDescription, Price, CreatedDate, UpdatedDAte, DeletedDate, UpdatedBy)
VALUES ('Pen', 800, '2021-03-01 12:45:35.71', '2021-03-01 12:45:35.71', NULL, NULL)
GO

INSERT INTO dbo.Treatments (TRDescription, Price, CreatedDate, UpdatedDAte, DeletedDate, UpdatedBy)
VALUES ('Cer', 700, '2021-03-01 12:45:44.413', '2021-03-01 12:45:44.413', NULL, NULL)
GO

IF OBJECT_ID ('dbo.UserLevel') IS NOT NULL
	DROP TABLE dbo.UserLevel
GO

CREATE TABLE dbo.UserLevel
	(
	LevelID     INT,
	Description VARCHAR (20),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DEletedDate DATETIME,
	UpdatedBy   NVARCHAR (10)
	)
GO


IF OBJECT_ID ('dbo.UserLevel') IS NOT NULL
	DROP TABLE dbo.UserLevel
GO

CREATE TABLE dbo.UserLevel
	(
	LevelID     INT,
	Description VARCHAR (20),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DEletedDate DATETIME,
	UpdatedBy   NVARCHAR (10)
	)
GO
INSERT INTO dbo.UserLevel (LevelID, Description, CreatedDate, UpdatedDate, DEletedDate, UpdatedBy)
VALUES (1, 'Admin', '2021-03-25 07:40:16.15', '2021-03-25 07:40:16.15', NULL, 'admin')
GO

INSERT INTO dbo.UserLevel (LevelID, Description, CreatedDate, UpdatedDate, DEletedDate, UpdatedBy)
VALUES (2, 'Staff', '2021-03-25 07:40:29.46', '2021-03-25 07:40:29.46', NULL, 'admin')
GO


IF OBJECT_ID ('dbo.Users') IS NOT NULL
	DROP TABLE dbo.Users
GO

CREATE TABLE dbo.Users
	(
	UserID      NVARCHAR (10) NOT NULL,
	LastName    VARCHAR (50),
	FirstName   VARCHAR (50),
	MiddleName  VARCHAR (50),
	CreatedDate DATETIME,
	UpdatedDate DATETIME,
	DeletedDate DATETIME,
	UpdatedBy   VARCHAR (10),
	PRIMARY KEY (UserID)
	)
GO

INSERT INTO dbo.Users (UserID, LastName, FirstName, MiddleName, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('US21030002', 'Dela Cruz', 'Juan', 'Miguel', '2021-03-25 07:47:43.29', '2021-03-25 07:47:43.29', NULL, 'US21030002')
GO

INSERT INTO dbo.Users (UserID, LastName, FirstName, MiddleName, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('US21030003', 'Perez', 'Mayumi', 'Cruz', '2021-03-27 06:19:44.633', '2021-04-06 12:34:54.627', NULL, 'US21030003')
GO
IF OBJECT_ID ('dbo.Vaccinations') IS NOT NULL
	DROP TABLE dbo.Vaccinations
GO

CREATE TABLE dbo.Vaccinations
	(
	VXID          INT IDENTITY NOT NULL,
	VXDesvription VARCHAR (100),
	CreatedDate   DATETIME,
	UpdatedDate   DATETIME,
	DeletedDate   DATETIME,
	UpdatedBy     NVARCHAR (10),
	PRIMARY KEY (VXID)
	)
GO

INSERT INTO dbo.Vaccinations (VXDesvription, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('P/D', '2021-03-01 10:12:22.19', '2021-03-12 08:05:50.103', NULL, '')
GO

INSERT INTO dbo.Vaccinations (VXDesvription, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('2 in 1', '2021-03-01 10:12:39.793', '2021-03-01 10:12:39.793', NULL, NULL)
GO

INSERT INTO dbo.Vaccinations (VXDesvription, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('9 in 1', '2021-03-01 10:12:51.817', '2021-03-01 10:12:51.817', NULL, NULL)
GO

INSERT INTO dbo.Vaccinations (VXDesvription, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('K/C', '2021-03-01 10:13:07.903', '2021-03-01 10:13:07.903', NULL, NULL)
GO

INSERT INTO dbo.Vaccinations (VXDesvription, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('R', '2021-03-01 10:13:18.52', '2021-03-01 10:13:18.52', NULL, NULL)
GO

INSERT INTO dbo.Vaccinations (VXDesvription, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('M', '2021-03-01 10:13:25.82', '2021-03-01 10:13:25.82', NULL, NULL)
GO



IF OBJECT_ID ('dbo.PetsProfile') IS NOT NULL
	DROP TABLE dbo.PetsProfile
GO

CREATE TABLE dbo.PetsProfile
	(
	PetID       NVARCHAR (10) NOT NULL,
	ProfilePath VARCHAR (500) NULL,
	CreatedDate DATETIME NULL,
	UpdateDate  DATETIME NULL,
	DeletedDate DATETIME NULL,
	UpdatedBy   VARCHAR (10) NULL,
	PRIMARY KEY (PetID)
	)
GO

