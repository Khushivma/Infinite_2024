-- 1. Create a database called Employeemanagement
CREATE DATABASE Employeemanagement;

use Employeemanagement

--- Create a table in the database called Employee_Details

CREATE TABLE Employee_Details (
    Empno INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Empsal NUMERIC(10, 2) CHECK (Empsal >= 25000),
    Emptype CHAR(1) CHECK (Emptype IN ('P', 'C'))
);

-- 2. Create a stored procedure to add new rows to the Employee_Details Table
drop PROCEDURE AddEmployee


CREATE PROCEDURE AddEmployee
    @EmpName VARCHAR(50),
    @Empsal NUMERIC(10, 2),
    @Emptype CHAR(1)
AS
BEGIN
    DECLARE @NewEmpNo INT;

    -- Generate Empno
    SELECT @NewEmpNo = ISNULL(MAX(Empno), 0) + 1 FROM Employee_Details;

    -- Insert new employee
    INSERT INTO Employee_Details (Empno, EmpName, Empsal, Emptype)
    VALUES (@NewEmpNo, @EmpName, @Empsal, @Emptype);
END

-- Check the procedure

EXEC AddEmployee 'Ananya', 45000.00, 'C';

-- 4. Display all employee rows

SELECT * FROM Employee_Details;