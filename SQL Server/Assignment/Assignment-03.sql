
use Assignments
select *from Empl

--1. Retrieve a list of MANAGERS. 
SELECT Ename FROM Empl WHERE JOB = 'MANAGER';
---------------------------------------------------------------------------------------------------------------------------------

--2. Find out the names and salaries of all employees earning more than 1000 per month. 
SELECT Ename, Salary FROM Empl WHERE Salary > 1000;
---------------------------------------------------------------------------------------------------------------------------------

--3. Display the names and salaries of all employees except JAMES. 
SELECT Ename, Salary From Empl Where Ename <> 'JAMES';
---------------------------------------------------------------------------------------------------------------------------------

--4. Find out the details of employees whose names begin with ‘S’. 
SELECT * from Empl WHERE Ename like 'S%';
---------------------------------------------------------------------------------------------------------------------------------

--5. Find out the names of all employees that have ‘A’ anywhere in their name.
SELECT Ename from Empl WHERE Ename like '%A%';
---------------------------------------------------------------------------------------------------------------------------------

--6. Find out the names of all employees that have ‘L’ as their third character in their name. 
SELECT Ename FROM Empl WHERE Ename LIKE '__L%';
---------------------------------------------------------------------------------------------------------------------------------

--7. Compute daily salary of JONES. 
SELECT Ename, Salary/22 AS daily_salary fROM Empl WHERE Ename = 'JONES';
----------------------------------------------------------------------------------------------------------------------------------

--8. Calculate the total monthly salary of all employees. 
select SUM(Salary) AS TotalMonthlySalary FROM Empl;

----------------------------------------------------------------------------------------------------------------------------------

--9. Print the average annual salary . 
SELECT AVG(Salary * 12) AS average_annual_salary FROM Empl;

----------------------------------------------------------------------------------------------------------------------------------

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
SELECT Ename, Salary, Job, Deptno from Empl WHERE Deptno = 30 and Job <> 'SALESMAN';
----------------------------------------------------------------------------------------------------------------------------------

--11. List unique departments of the EMP table.
SELECT DISTINCT Deptno FROM Empl;
----------------------------------------------------------------------------------------------------------------------------------

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
SELECT Ename AS Employee, Salary AS "Monthly Salary" FROM Empl WHERE Salary > 1500 AND (Deptno = 10 OR Deptno = 30);
-----------------------------------------------------------------------------------------------------------------------------------

--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
SELECT Ename, Job, Salary FROM Empl WHERE (Job = 'MANAGER' OR Job = 'ANALYST') AND Salary NOT IN (1000, 3000, 5000);

-----------------------------------------------------------------------------------------------------------------------------------

--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
SELECT Ename,Salary,Comm from Empl WHERE Comm > Salary * 0.1;
----------------------------------------------------------------------------------------------------------------------------------

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
SELECT Ename FROM Empl WHERE (Ename LIKE '%L%L%') AND (Deptno = 30 OR Mgr_id = 7782);

----------------------------------------------------------------------------------------------------------------------------------

--16. Display the names of employees with experience of over 30 years and under 40 yrs.
--Count the total number of employees. 
SELECT Ename, COUNT(*) AS TotalEmployees FROM Empl
WHERE DATEDIFF(YEAR, hiredate, GETDATE()) BETWEEN 31 AND 39
GROUP BY Ename;

----------------------------------------------------------------------------------------------------------------------------------

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
SELECT D.Dname AS Department, E.Ename AS Employee FROM DEPT D
JOIN Empl E ON D.Deptno = E.Deptno
ORDER BY D.Dname ASC, E.Ename DESC;

-----------------------------------------------------------------------------------------------------------------------------------

--18. Find out experience of MILLER. 
SELECT Ename, DATEDIFF(year,hiredate,getdate())  AS Experience
FROM Empl
WHERE Ename = 'MILLER';

----------------------------------------------------------------------------------------------------------------------------------
