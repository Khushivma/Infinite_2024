
--1.Write a T-SQL Program to find the factorial of a given number.

begin
declare @Num int=1,@i int = 8
	if(@i<=1)
	begin 
		set @Num=1
	end
	else
	begin
	  declare @Sum int =1
	  while @Sum <=@i
		begin
		  set @Num=@Num*@Sum
		  set @Sum=@Sum+1
		end
	end
end
select @Num as 'Factorial'

----------------------------------------------------------------------------------------------------------------------------------------------

--2. Create a stored procedure to generate multiplication tables up to a given number.

CREATE PROCEDURE GenerateMultiplicationTables(@max_number INT)
AS
BEGIN
    DECLARE @i INT = 1;
    DECLARE @j INT;
 
    WHILE (@i <= @max_number)
    BEGIN
        PRINT 'Multiplication table for ' + CAST(@i AS VARCHAR) + ':';
        SET @j = 1;
        WHILE (@j <= 10)
        BEGIN
            PRINT CAST(@i AS VARCHAR) + ' x ' + CAST(@j AS VARCHAR) + ' = ' + CAST(@i * @j AS VARCHAR);
            SET @j += 1;
        END
        SET @i += 1;
        PRINT ''; -- Add an empty line for readability
    END
END
Exec GenerateMultiplicationTables @max_number= 8

-----------------------------------------------------------------------------------------------------------------------------------------------

--3. Create a trigger to restrict data manipulation on EMP table during General holidays. 
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 

-- Step 1: Create the holiday table
drop table HOLIDAY
CREATE TABLE HOLIDAY (
    Holiday_Date DATE PRIMARY KEY,
    Holiday_Name VARCHAR(100)
);

-- Step 2: Insert holiday details

INSERT INTO HOLIDAY(Holiday_Date, Holiday_Name) VALUES 
('2024-03-26', 'HOLI'),
('2024-08-15', 'INDEPENDENCE DAY'),
('2024-10-25', 'DIWALI'),
('2024-12-25', 'CHRISHMAS'),
('2024-01-26', 'REPULIC DAY');

-- Step 3: Create the trigger function to check if it's a holiday

CREATE OR ALTER TRIGGER trg_check_HOLIDAY
ON Empl
FOR INSERT, UPDATE, DELETE
AS
BEGIN

    SET NOCOUNT ON;
    DECLARE @HOLIDAY_COUNT INT;

    -- Check if the current date is a holiday

    SELECT @HOLIDAY_COUNT = COUNT(*)
    FROM HOLIDAY
    WHERE Holiday_Date = CONVERT(DATE, GETDATE());
 
    -- If current date is a holiday, raise an error and rollback the transaction

    IF @HOLIDAY_COUNT > 0
    BEGIN
        DECLARE @HD_Name VARCHAR(100);
        SELECT @HD_Name = @HD_Name
        FROM HOLIDAY
        WHERE Holiday_Date = CONVERT(DATE, GETDATE());
        RAISERROR('Due to %s, you cannot manipulate data.', 16, 1, @HD_Name);
        ROLLBACK TRANSACTION;
    END
END
Delete from Empl where Empno = 4500
Insert into Empl values(4500,'KHUSHI','MANAGER',9500,'2023-08-25',5000,null,30)
