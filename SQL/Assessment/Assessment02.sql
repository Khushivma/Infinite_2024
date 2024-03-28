use Assignments
---1. Write a query to display your birthday( day of week)

SELECT DATENAME(DW, '2001-01-26') AS Birthday_Day_in_week;\
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

---2. Write a query to display your age in days

SELECT DATEDIFF(DAY, '2001-01-26', CAST(GETDATE() AS DATE)) AS Age_In_Days;
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

---3. Write a query to display all employees information those who joined before 5 years in the current month
 --(Hint : If required update some HireDates in your EMP table of the assignment)

 -- Check employees hired before 5 years ago

UPDATE Empl
SET HireDate = DATEADD(YEAR, -5, HireDate)
WHERE Empno IN (7369, 7521, 7654, 7844, 7876);
SELECT *
FROM Empl
WHERE Hiredate < DATEADD(YEAR, -5, GETDATE());


--------------------------------------------------------------------------------------------------------------------------------

---4. Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	--a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
    --c. Delete first row.
--d. After completing above all actions how to recall the deleted row without losing increment of second row.

CREATE TABLE Emplo (
    EMPNO INT PRIMARY KEY,
    ENAME VARCHAR(50),
    SALARY FLOAT,
    DOJ DATE
);

CREATE OR ALTER PROCEDURE OPERATION
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
	-- Insert all data into the Emplo table
    -- Insert data into Emplo table if EMPNO does not already exist
	INSERT INTO Emplo (EMPNO, ENAME, SALARY, DOJ)
	SELECT 1, 'Shreya', 8000, '2022-06-01'
	WHERE NOT EXISTS (SELECT 1 FROM Emplo WHERE EMPNO = 1)
	UNION ALL
	SELECT 2, 'Divya', 9000, '2021-02-02'
	WHERE NOT EXISTS (SELECT 1 FROM Emplo WHERE EMPNO = 2)
	UNION ALL
	SELECT 3, 'Vidya', 7000, '2019-05-03'
	WHERE NOT EXISTS (SELECT 1 FROM Emplo WHERE EMPNO = 3);


--b.----------------------------------------------------------------------------------------------------------------
	UPDATE Emplo SET Salary = salary * 1.15/100 WHERE Empno = 2;

--c.-----------------------------------------------------------------------------------------------------------------
	DELETE FROM Emplo WHERE EMPNO = 2;

-- Commit the transaction--------------------------------------------------------------------------------------------
	commit transaction
 
	select * from Emplo
END

--d.----------------------------------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE DELETEDROW
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

-- Insert the deleted row into the Emplo table
    INSERT INTO Emplo (EMPNO, ENAME, SALARY, DOJ)
    SELECT EMPNO, ENAME, SALARY, DOJ
    FROM Emplo
    WHERE EMPNO = 2;

-- Commit the transaction to recall the deleted row
    COMMIT TRANSACTION;

    -- Select all records from the Emplo table
    SELECT * FROM Emplo;
END;

---Executing the function---------------------------------------------------------------------------------
EXECUTE OPERATION;
EXECUTE DELETEDROW;

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

---5. Create a user defined function calculate Bonus for all employees of a  given job using following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

CREATE FUNCTION dbo.CalculateBonus (@Deptno INT, @Salary DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @Bonus DECIMAL(10, 2);

    IF @Deptno = 10
        SET @Bonus = @Salary * 0.15;
    ELSE IF @Deptno = 20
        SET @Bonus = @Salary * 0.20;
    ELSE
        SET @Bonus = @Salary * 0.05;

    RETURN @Bonus;
END;

---Executing the function---------------------------------------------------------------------------------

DECLARE @bonus DECIMAL(10, 2);
SET @bonus = dbo.CalculateBonus(10,1600); -- Example for Department 10 with salary 800
SELECT CAST(@bonus AS VARCHAR(20)) AS Bonus_for_employee;

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


