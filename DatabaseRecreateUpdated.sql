-- Database Recreation Script for EMS System (Updated)
-- This script will completely recreate the database with the correct structure
-- WARNING: This will delete all existing data!
-- Updated to remove Department and HireDate columns from Employees table

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'EMSDB')
BEGIN
    ALTER DATABASE EMSDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE EMSDB;
    PRINT 'Dropped existing EMSDB database';
END
GO

CREATE DATABASE EMSDB;
PRINT 'Created new EMSDB database';
GO

USE EMSDB;
GO

-- Create Users table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    Role NVARCHAR(20) DEFAULT 'User',
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE()
);
PRINT 'Created Users table';

-- Create Employees table (Updated - removed Department and HireDate)
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeCode NVARCHAR(20) NOT NULL UNIQUE,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Email NVARCHAR(100),
    Phone NVARCHAR(20),
    Address NVARCHAR(200),
    Position NVARCHAR(50),
    Salary DECIMAL(10,2) DEFAULT 0.00,
    OTRate DECIMAL(8,2) DEFAULT 0.00,
    Allowance DECIMAL(10,2) DEFAULT 0.00,
    EPFPercentage DECIMAL(5,2) DEFAULT 0.00,
    EPFAmount DECIMAL(10,2) DEFAULT 0.00,
    NIC NVARCHAR(20),
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE()
);
PRINT 'Created Employees table (Updated schema)';

-- Create Salaries table
CREATE TABLE Salaries (
    SalaryID NVARCHAR(20) PRIMARY KEY,
    PayrollID NVARCHAR(20) NOT NULL,
    EmployeeID INT NOT NULL,
    BasicSalary DECIMAL(10,2) NOT NULL,
    Overtime DECIMAL(10,2) DEFAULT 0,
    Allowance DECIMAL(10,2) DEFAULT 0,
    Deductions DECIMAL(10,2) DEFAULT 0,
    NetSalary DECIMAL(10,2) NOT NULL,
    Month INT NOT NULL,
    Year INT NOT NULL,
    PaymentDate DATE NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
PRINT 'Created Salaries table';

-- Create SystemSettings table
CREATE TABLE SystemSettings (
    SettingID INT IDENTITY(1,1) PRIMARY KEY,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    LeavesPerYear INT DEFAULT 21,
    CycleDateRange INT DEFAULT 30,
    LastUpdated DATETIME DEFAULT GETDATE()
);
PRINT 'Created SystemSettings table';

-- Insert default admin user
INSERT INTO Users (Username, Password, FullName, Email, Role, IsActive)
VALUES ('admin', 'admin123', 'System Administrator', 'admin@ems.com', 'Admin', 1);
PRINT 'Inserted default admin user';

-- Insert sample employees (Updated - removed Department and HireDate)
INSERT INTO Employees (EmployeeCode, FirstName, LastName, DateOfBirth, Gender, Email, Phone, Address, Position, Salary, OTRate, Allowance, EPFPercentage, EPFAmount, NIC, IsActive)
VALUES 
    ('EMP001', 'John', 'Doe', '1990-05-15', 'Male', 'john.doe@company.com', '+1234567890', '123 Main St, City', 'Software Developer', 5000.00, 25.00, 500.00, 8.00, 400.00, '1234567890123', 1),
    ('EMP002', 'Jane', 'Smith', '1988-08-22', 'Female', 'jane.smith@company.com', '+1234567891', '456 Oak Ave, Town', 'Project Manager', 6000.00, 30.00, 600.00, 8.00, 480.00, '9876543210987', 1),
    ('EMP003', 'Mike', 'Johnson', '1992-03-10', 'Male', 'mike.johnson@company.com', '+1234567892', '789 Pine Rd, Village', 'Business Analyst', 4500.00, 22.50, 450.00, 8.00, 360.00, '4567891230456', 1);
PRINT 'Inserted sample employees';

-- Insert sample salary records
INSERT INTO Salaries (SalaryID, PayrollID, EmployeeID, BasicSalary, Overtime, Allowance, Deductions, NetSalary, Month, Year, PaymentDate)
VALUES 
    ('SAL0001', 'PRL0001', 1, 5000.00, 250.00, 500.00, 400.00, 5350.00, 1, 2024, '2024-01-31'),
    ('SAL0002', 'PRL0002', 2, 6000.00, 300.00, 600.00, 480.00, 6420.00, 1, 2024, '2024-01-31'),
    ('SAL0003', 'PRL0003', 3, 4500.00, 225.00, 450.00, 360.00, 4815.00, 1, 2024, '2024-01-31');
PRINT 'Inserted sample salary records';

-- Insert default system settings
INSERT INTO SystemSettings (StartDate, EndDate, LeavesPerYear, CycleDateRange)
VALUES ('2024-01-01', '2024-12-31', 21, 30);
PRINT 'Inserted default system settings';

-- Create indexes for better performance
CREATE INDEX IX_Employees_EmployeeCode ON Employees(EmployeeCode);
CREATE INDEX IX_Employees_Email ON Employees(Email);
CREATE INDEX IX_Salaries_EmployeeID ON Salaries(EmployeeID);
CREATE INDEX IX_Salaries_PaymentDate ON Salaries(PaymentDate);
PRINT 'Created performance indexes';

PRINT 'Database recreation completed successfully!';
PRINT 'Default login: admin / admin123';
GO
