
Create DATABASE CodingTest01
use CodingTest01

----CREATING THE BOOKS TABLE------------------------------------------------------------------------------------------------------
create table Books(
	ID int primary key,
	Title varchar(255),
	Isbn varchar(13) unique,
	Author varchar(100),
	Published_date DATETIME);

INSERT INTO Books(ID, Title,Isbn,Author,Published_date) VAlUES
(1, 'My First SQL book', '981483029127', 'Mary Parker', '2012-02-22 12:08:17'),
(2, 'My Second SQL book', '857300923713', 'John Mayer', '1972-07-03 09:22:45'),
(3, 'My Third SQL book', '523120967812', 'Cary Flint', '2015-10-18 14:05:44');

Select * from Books

----CREATING THE TABLE OF REVIEWS------------------------------------------------------------------------------------------------------

Create table Review(
	ID int primary key,
	Book_ID int,
	Reviewer_Name varchar(100),
	Content TEXT,
	Rating int,
	Published_date DATETIME,
	Foreign key (Book_ID) REFERENCES Books(ID));

INSERT INTO Review(id, book_id, reviewer_name, content, rating, published_date) VALUES
(1., 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11.1'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12.6'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10');

Select * from Review
------------------------------------------------------------------------------------------------------------------------------------
--1. Write a query to fetch the details of the books written by author whose name ends with er.
Select * from Books WHERE Author like '%er';

----------------------------------------------------------------------------------------------------------------------------------
--2. Display the Title ,Author and ReviewerName for all the books from the above table.
Select b.Title, b.Author, r.Reviewer_Name from Books b, Review r WHERE b.ID = r.Book_ID;

----------------------------------------------------------------------------------------------------------------------------------
--3. Display the reviewer name who reviewed more than one book.
SELECT Reviewer_Name FROM Review GROUP BY Reviewer_Name HAVING COUNT(DISTINCT book_id) > 1;

----CREATING THE CUSTOMER TABLE----------------------------------------------------------------------------------------------------

Create Table Customers (
	ID int primary key,
	NAME varchar(255),
	AGE int,
	ADDRESS varchar(255),
	SALARY Decimal(10,2)
);

INSERT INTO CUSTOMERS (ID, NAME, AGE, ADDRESS, SALARY) VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 25, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00);

Select * from Customers;

----CREATING THE ORDER TABLE-----------------------------------------------------------------------------------------------------------

Create table Orders (
	OID int primary key,
	DATE date,
	CUSTOMER_ID int,
	AMOUNT Decimal(10,2)
	foreign key (CUSTOMER_ID) references CUSTOMERS(ID)
);

INSERT INTO ORDERS (OID, DATE, CUSTOMER_ID, AMOUNT) VALUES
(102, '2009-10-08', 3, 3000.00),
(100, '2009-10-08', 3, 1500.00),
(101, '2009-11-20', 2, 1560.00),
(103, '2008-05-20', 4, 2060.00);

Select * from Orders
----------------------------------------------------------------------------------------------------------------------------------
--4. Display the Name for the customer from above customer table who live in same address which has character o anywhere in address.
Select NAME from Customers WHERE ADDRESS like '%o%'

-----------------------------------------------------------------------------------------------------------------------------------
--5. Write a query to display the Date,Total no of customer placed order on same Date.
Select DATE, Count(DISTINCT CUSTOMER_ID) AS Total_Customers from Orders
GROUP BY Date;

----------------------------------------------------------------------------------------------------------------------------------
----CREATING THE EMPLOYEE TABLE---------------------------------------------------------------------------------------------------

CREATE TABLE Employee (
    ID int primary key,
    NAME varchar(255),
    AGE int,
    ADDRESS varchar(255),
    SALARY decimal(10, 2)
);

INSERT INTO Employee (ID, NAME, AGE, ADDRESS, SALARY) VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', Null),
(7, 'Muffy', 24, 'Indore', NULL);

----------------------------------------------------------------------------------------------------------------------------------
--6.Display the Names of the Employee in lower case, whose salary is null.
Select LOWER(NAME) As Lowercase_Name from Employee WHERE Salary is null;

-----------------------------------------------------------------------------------------------------------------------------------
------CREATING THE STUDENT DETAILS TABLE------------------------------------------------------------------------------------------

CREATE TABLE StudentDetails (
    Register_No int primary key,
    Name varchar(255),
    Age int,
    Qualification varchar(50),
    Mobile_No varchar(15),
    Location varchar(100),
    Gender char(1),
    Mail_id varchar(255)
);

INSERT INTO StudentDetails (Register_No, Name, Age, Qualification, Mobile_No, Mail_id, Location, Gender) VALUES
(2., 'Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
(5, 'Nisha', 25, 'M.E', '7834672310', 'Nisha@gmail.com', 'Theni', 'F'),
(6, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
(7, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune', 'M');

-------------------------------------------------------------------------------------------------------.---------------------------
--7.Write a sql server query to display the Gender,Total no of male and female from the above relation
SELECT Gender , COUNT(*) AS Total_Number FROM StudentDetails GROUP BY GENDER

----------------------------------------------------------------------------------------------------------------------------------
