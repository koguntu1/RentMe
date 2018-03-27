--  Forward Engineering

/* SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0; */
/* SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0; */
/* SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES'; */

-- -----------------------------------------------------
-- Schema rentme
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema rentme
-- -----------------------------------------------------

CREATE DATABASE RentMe;

-- -----------------------------------------------------
-- Table `rentme`.`Employee`
-- -----------------------------------------------------
USE RentMe;

CREATE TABLE Employee (
  [employeeID] INT NOT NULL IDENTITY,
  [fname] VARCHAR(45) NOT NULL,
  [middleInitial] VARCHAR(1) NULL,
  [lname] VARCHAR(45) NOT NULL,
  [dateOfBirth] DATETIME2(0) NOT NULL,
  [homePhone] VARCHAR(14) NULL,
  [Address1] VARCHAR(60) NULL,
  [Address2] VARCHAR(60) NULL,
  [City] VARCHAR(15) NULL,
  [State] VARCHAR(2) NULL,
  [PostalCode] VARCHAR(10) NULL,
  [gender] VARCHAR(14) NULL,
  PRIMARY KEY ([employeeID])
 );
 
-- -----------------------------------------------------
-- Table `rentme`.`Member`
-- -----------------------------------------------------
CREATE TABLE Member (
  [memberID] INT NOT NULL IDENTITY,
  [fname] VARCHAR(45) NOT NULL,
  [middleInitial] VARCHAR(1) NULL,
  [lname] VARCHAR(45) NOT NULL,
  [dateOfBirth] DATETIME2(0) NOT NULL,
  [homePhone] VARCHAR(14) NULL,
  [Address1] VARCHAR(60) NULL,
  [Address2] VARCHAR(60) NULL,
  [City] VARCHAR(15) NULL,
  [State] VARCHAR(2) NULL,
  [PostalCode] VARCHAR(10) NULL,
  [gender] VARCHAR(14) NULL,
  PRIMARY KEY ([memberID])
 );


-- -----------------------------------------------------
-- Table `rentme`.`Style`
-- -----------------------------------------------------
CREATE TABLE Style (
  [styleID] INT NOT NULL IDENTITY,
  [description] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([styleID]))
;


-- -----------------------------------------------------
-- Table `rentme`.`Category`
-- -----------------------------------------------------
CREATE TABLE Category (
  [categoryID] INT NOT NULL IDENTITY,
  [description] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([categoryID]))
;


-- -----------------------------------------------------
-- Table `rentme`.`Furniture`
-- -----------------------------------------------------
CREATE TABLE Furniture (
  [furnitureID] INT NOT NULL IDENTITY,
  [description] VARCHAR(45) NOT NULL,
  [styleID] INT NOT NULL,
  [categoryID] INT NOT NULL,
  [fine_Rate] DECIMAL(10,2) NOT NULL,
  [daily_Rate] DECIMAL(10,2) NOT NULL,
  PRIMARY KEY ([furnitureID])
 ,
  CONSTRAINT [fk_Furniture_Style]
    FOREIGN KEY ([styleID])
    REFERENCES Style ([styleID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Furniture_Category]
    FOREIGN KEY ([categoryID])
    REFERENCES Category ([categoryID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Furniture_Style_idx] ON Furniture ([styleID] ASC);
CREATE INDEX [fk_Furniture_Category1_idx] ON Furniture ([categoryID] ASC);


-- -----------------------------------------------------
-- Table `rentme`.`Store_item`
-- -----------------------------------------------------
CREATE TABLE Store_item (
  [itemID] INT NOT NULL IDENTITY,
  [furnitureID] INT NOT NULL,
  PRIMARY KEY ([itemID])
 ,
  CONSTRAINT [fk_Inventory_Furniture]
    FOREIGN KEY ([furnitureID])
    REFERENCES Furniture ([furnitureID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Inventory_Furniture1_idx] ON Store_item ([furnitureID] ASC);


-- -----------------------------------------------------
-- Table `rentme`.`Rental`
-- -----------------------------------------------------
CREATE TABLE Rental (
  [rentalID] INT NOT NULL IDENTITY,
  [memberID] INT NOT NULL,
  [expected_return] DATETIME2(0) NOT NULL,
  [itemID] INT NOT NULL,
  [return_date] DATETIME2(0) NULL,
  [rental_date] DATETIME2(0) NOT NULL,
  PRIMARY KEY ([rentalID])
 ,
  CONSTRAINT [fk_Rental_Member]
    FOREIGN KEY ([memberID])
    REFERENCES Member ([memberID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Rental_Store_item]
    FOREIGN KEY ([itemID])
    REFERENCES Store_item ([itemID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Rental_Member_idx] ON Rental ([memberID] ASC);
CREATE INDEX [fk_Rental_Store_item_idx] ON Rental ([itemID] ASC);
-- -----------------------------------------------------
-- Table `rentme`.`Transactions`
-- -----------------------------------------------------
CREATE TABLE Transactions (
  [transactionID] INT NOT NULL IDENTITY,
  [date] DATETIME2(0) NOT NULL,
  [amount] VARCHAR(45) NOT NULL,
  [comment] VARCHAR(45) NULL,
  [employeeID] INT NOT NULL,
  [fines] DECIMAL(10,2) NULL,
  PRIMARY KEY ([transactionID])
 ,
  CONSTRAINT [fk_Transactions_Employee]
    FOREIGN KEY ([employeeID])
    REFERENCES Employee ([employeeID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Transactions_Employee_idx] ON  Transactions ([employeeID] ASC);


-- -----------------------------------------------------
-- Table `rentme`.`Rental_return_transactions`
-- -----------------------------------------------------
CREATE TABLE Rental_return_transaction(
  [returnID] INT NOT NULL IDENTITY,
  [rentalID] INT NOT NULL,
  [transactionID] INT NOT NULL,
  PRIMARY KEY ([returnID])
 ,
  CONSTRAINT [fk_Rental_return_transaction_Rental]
    FOREIGN KEY ([rentalID])
    REFERENCES Rental ([rentalID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Rental_return_transaction_Transacation]
    FOREIGN KEY ([transactionID])
    REFERENCES Transactions ([transactionID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Rental_return_transaction_Transacation_idx] ON Rental_return_transaction ([transactionID] ASC);
CREATE INDEX [fk_Rental_return_transaction_Rental_idx] ON  Rental_return_transaction ([rentalID] ASC);


-- -----------------------------------------------------
-- Table `rentme`.`Rental_transactions`
-- -----------------------------------------------------
CREATE TABLE Rental_transaction(
  [rentalTransacationID] INT NOT NULL IDENTITY,
  [rentalID] INT NOT NULL,
  [transactionID] INT NOT NULL,
  PRIMARY KEY ([rentalTransacationID])
 ,
  CONSTRAINT [fk_Rental_transaction_Rental]
    FOREIGN KEY ([rentalID])
    REFERENCES Rental ([rentalID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Rental_transaction_Transacation]
    FOREIGN KEY ([transactionID])
    REFERENCES Transactions ([transactionID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Rental_transaction_Transacation_idx] ON Rental_transaction ([transactionID] ASC);
CREATE INDEX [fk_Rental_transaction_Rental_idx] ON  Rental_transaction ([rentalID] ASC);





-- -----------------------------------------------------
-- Table `rentme`.`Login`
-- -----------------------------------------------------
CREATE TABLE Login (
  [loginID] INT NOT NULL,
  [userID] VARCHAR(30) NOT NULL,
  [password] VARCHAR(45) NOT NULL,
  [employeeID] INT NOT NULL,
  PRIMARY KEY ([login])
 ,
  CONSTRAINT [fk_Login_Employee]
    FOREIGN KEY ([employeeID])
    REFERENCES Employee ([employeeID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Login_Employee1_idx] ON Login ([employeeID] ASC);


/* SET SQL_MODE=@OLD_SQL_MODE; */
/* SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS; */
/* SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS; */
