Create Database HRMS

use HRMS

Create table EmployeeDetails
(
EmpID varchar(10) Primary key,
FName varchar(30) not null,
MName varchar(30),
LName varchar(30),
Password varchar(30) not null,
Department varchar(40) not null,
Address varchar(100) not null,
Phone varchar(10),
Mobile varchar(15),
Dob DateTime,
Sex varchar(8) not null,
Education varchar(10) not null,
Designation varchar(30) not null,
Email varchar(50),
Doj DateTime,
status varchar(10)
)

insert EmployeeDetails values('HR001','Admin','','','pswd1','HR','Delhi','','','','FeMale','MA','Head','','',null)


Create table AttendanceDetails
(
EmpID varchar(10) references EmployeeDetails (EmpID),
FName varchar(30) not null,
Date varchar(30) not null,
CurrentDay varchar(30) not null,
CurrentMonth varchar(30) not null,
CurrentYear varchar(30) not null,
TimeIn varchar(30) not null,
TimeOut varchar(30) not null,
OvertimeHours int,
Department varchar(40) not null,
Designation varchar(30) not null,
Remarks varchar(100)
)

Create table LeaveDetails
(
EmpID varchar(10) references EmployeeDetails (EmpID),
FName varchar(30) not null,
Department varchar(40) not null,
CurrentMonth varchar(30) not null,
CurrentYear varchar(30) not null,
FromDate datetime,
ToDate datetime,
NoOfDays int,
Reason varchar(100)
)

Create table EmployeeSalaryAgreement
(
EmpID varchar(10) references EmployeeDetails (EmpID) Primary Key,
AgreementDate Datetime not null,
FName varchar(30) not null,
Department varchar(40) not null,
Designation varchar(30) not null,
BankName varchar(30),
AccountNo varchar(30),
PayFrequency varchar(20) not null,
WorkingDays int not null,
WorkingHours int not null,
Basic int not null,
HRA int not null,
DA int not null,
UA int not null,
ConveyanceAllowance int not null,
Telephone int not null,
MR int not null,
ProfessionTax int not null,
PF int not null,
TotalSalary int not null,
MonthlySalary int not null,
SalaryPerDay int not null,
OvertimePerHour int not null,
Remarks varchar(100)
)

Create table SalaryDetails
(
EmpID varchar(10) references EmployeeDetails (EmpID),
FName varchar(30) not null,
FixedSalary int not null,
Department varchar(40) not null,
Designation varchar(30) not null,
BankName varchar(30),
AccountNo varchar(30),
YearOfSalary varchar(20) not null,
MonthOfSalary varchar(20) not null,
NoOfLeaves int,
TotalDeduction int,
OvertimeHours int,
OvertimePayments int not null,
TotalSalary int not null,
Remarks varchar(100)
)
