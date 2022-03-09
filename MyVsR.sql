create database MyVsR1
use MyVsR1
drop database MyVsR1

create table Log_In
(
UserName varchar(50) not null,
Passwords varchar(50) not null,
Position varchar(50) not null
)

insert into Log_In values
('MyVsR','2071203','Administrator')

create table NewAccount
( 
AccountNumber int primary key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
Gender varchar(50) not null,
DoB date,
Age AS YEAR(GETDATE()) - YEAR(DOB),
Adress varchar(50) not null,
Nationality varchar(50) not null,
PhoneNumber varchar(50) not null,
Email varchar(50) not null,
MartialStatus varchar(50) not null,
Balances money not null,
Pictures image
)
drop table NewAccount

drop proc sp_add_account
GO
CREATE PROCEDURE sp_add_account
@AccountNumber int ,
@FirstName varchar(50),
@LastName varchar(50),
@Gender varchar(50),
@DoB date,
@Adress varchar(50),
@Nationality varchar(50),
@PhoneNumber varchar(50),
@Email varchar(50),
@MartialStatus varchar(50),
@Balances money,
@Pictures image
AS
BEGIN 
  INSERT INTO NewAccount VALUES
  (@AccountNumber, @FirstName, @LastName, @Gender, @DoB, @Adress, @Nationality, @PhoneNumber, @Email, @MartialStatus, @Balances, @Pictures)
END
GO

GO
CREATE PROCEDURE sp_remove_account
@AccountNumber int
AS
BEGIN
  DELETE FROM NewAccount WHERE AccountNumber = @AccountNumber
END 
GO
drop proc sp_remove_account
select * from NewAccount

create table Withdraw 
(
Id int primary key identity,
DOT date,
AccountNo int not null,
WithdrawalAmount money not null
)
drop table Withdraw
GO
CREATE PROCEDURE sp_withdraw
@Account INT, @Amount MONEY
AS
BEGIN
  DECLARE @CurBalance MONEY
  SELECT @CurBalance = Balances FROM NewAccount WHERE AccountNumber = @Account
  IF (@CurBalance < @Amount)
    ROLLBACK
  UPDATE NewAccount
  SET Balances = Balances - @Amount
  WHERE AccountNumber = @Account
  
  INSERT INTO Withdraw VALUES
  (GETDATE(),@Account,@Amount)
  
END
GO
drop proc sp_withdraw
drop table Deposit
create table Deposit
(
Id int primary key identity,
DOD date,
AccountNo int not null,
DepositedAmount money not null
)

GO
CREATE PROCEDURE sp_deposit
@Account INT, @Amount MONEY
AS
BEGIN
  DECLARE @CurBalance MONEY
  SELECT @CurBalance = Balances FROM NewAccount WHERE AccountNumber = @Account
  UPDATE NewAccount
  SET Balances = Balances + @Amount
  WHERE AccountNumber = @Account
  
  INSERT INTO Deposit VALUES
  (GETDATE(),@Account,@Amount)
END
GO
drop proc sp_deposit
GO
CREATE PROCEDURE sp_update_account
@AccountNumber int ,
@FirstName varchar(50),
@LastName varchar(50),
@Gender varchar(50),
@DoB date,
@Adress varchar(50),
@Nationality varchar(50),
@PhoneNumber varchar(50),
@Email varchar(50),
@MartialStatus varchar(50),
@Balances money,
@Pictures image = NULL
AS
BEGIN 
  --INSERT INTO NewAccount VALUES
  --(@AccountNumber, @FirstName, @LastName, @Gender, @DoB, @Adress, @Nationality, @PhoneNumber, @Email, @MartialStatus, @Balances, @Pictures)
  UPDATE NewAccount
  SET FirstName = @FirstName,
    LastName = @LastName,
    Gender = @Gender,
    DoB = @DoB,
    Adress = @Adress,
    Nationality = @Nationality,
    PhoneNumber = @PhoneNumber,
    Email = @Email,
    MartialStatus = @MartialStatus,
    Balances = @Balances,
    Pictures = @Pictures
  WHERE 
    AccountNumber = @AccountNumber
    
END
GO
drop proc sp_update_account
select * from NewAccount