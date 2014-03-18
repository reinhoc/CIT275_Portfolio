--Create the HelpDesk database
--Create Database HelpDesk
--Go

Use HelpDesk

--Customer Table
Create Table Customer
(CustID				int				Not Null Primary Key Identity,
CustName			varchar(50)		Not Null,
CustAddress			varchar(150)	Not Null,
CustState			varchar(30)		Not Null,
CustZip				int				Not Null
)

--Ticket Table
Create Table Ticket
(TickID				int				Not Null Primary Key Identity,
ProblemTitle		varchar(50)		Not Null,
ProbleDescription	varchar(500)	Not Null,
Severity			int				Not Null,
Completed			bit)

--CustTick Table
Create Table CustTick
(CustID int References Customer (CustID),
TickID int References Ticket (TickID),
Primary Key(CustID, TickID)
)

--Employee Table
Create Table Employee
(EmpID				int				Not Null Primary Key Identity,
EmpFName			varchar(50)		Not Null,
EmpLName			varchar(50)		Not Null,
EmpUName			varchar(50)		Not Null
)

--EmpTick Table
Create Table EmpTick
(EmpID	int References Employee (EmpID),
TickID	int	References Ticket (TickID),
Primary Key(EmpID, TickID)
)