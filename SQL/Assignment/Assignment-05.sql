use Assignments


CREATE or ALTER proc GeneratePayslip @Ename varchar(20)
as
begin 
	DECLARE @HRA int, @DA int, @PF int ,@IT int, @Salary int
	SELECT @Salary = Salary from Empl
 
--- Calculating the HRA, DA, PF, IT--------------------------------------------------------------------------------------------------------------------

	SET @HRA = @Salary * 0.1 --HRA 
	SET @DA = @Salary * 0.2
	SET @PF = @Salary * 8/100
	SET @IT = @Salary * 5/100

-- To calculate deductions, gross salary and net salary, declare the variables--------------------------------------------------------------------------

	DECLARE @Deduction INT, @GrossSalary INT, @NetSalary INT

-- Deductions as sum of PF and IT-----------------------------------------------------------------------------------------------------------------------

	SET @Deduction = @PF + @IT
 
--Gross Salary as sum of Salary,HRA,DA------------------------------------------------------------------------------------------------------------------

	SET @GrossSalary = @Salary + @HRA + @DA

--Net Salary as Gross Salary - Deductions---------------------------------------------------------------------------------------------------------------

	SET @NetSalary = @GrossSalary - @Deduction
 
--- Displaying the payslip data-------------------------------------------------------------------------------------------------------------------------

	Print 'Employee Name: ' + cast(@Ename as varchar(10))
    Print 'Salary: ' + cast(@Salary as varchar(20))
    Print 'HRA: ' + cast(@HRA as varchar(20))
    Print 'DA: ' + cast(@DA as varchar(20))
    Print 'PF: ' + cast(@PF as varchar(20))
    Print 'IT: ' + CAST(@IT as varchar(20))
    Print 'Deductions: ' + cast(@Deduction as varchar(20))
    Print 'Gross Salary: ' + cast(@GrossSalary as varchar(20))
    Print 'Net Salary: ' + cast(@NetSalary as varchar(20))

end

--Capture the result set---------------------------------------------------------------------------------------------------------------------------------

EXEC GeneratePayslip @Ename = 'SCOTT'

