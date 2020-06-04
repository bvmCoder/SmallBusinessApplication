--Create the database
CREATE DATABASE SmallBusinessDB


--Create Customer Table
CREATE TABLE Customer
(
Customer_IDNumber VarChar(4) PRIMARY KEY,
Customer_Name VarChar(50) NOT NULL,
Customer_SSNumber VarChar(11) NOT NULL,
Customer_BDate VarChar(10) NOT NULL,
Customer_Address VarChar(100) NULL,
Customer_Phone VarChar(20) NOT NULL,
Customer_Email VarChar(50) NOT NULL
)