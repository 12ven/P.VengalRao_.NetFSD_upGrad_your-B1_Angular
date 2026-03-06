create database AssignmentDB
use AssignmentDB

CREATE TABLE Worker (
	WORKER_ID INT PRIMARY KEY IDENTITY(1,1),
	FIRST_NAME VARCHAR(25),
	LAST_NAME VARCHAR(25),
	SALARY INT,
	JOINING_DATE DATETIME,
	DEPARTMENT CHAR(25)
);

CREATE TABLE Bonus (
	WORKER_REF_ID INT,
	BONUS_AMOUNT INT,
	BONUS_DATE DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

CREATE TABLE Title (
	WORKER_REF_ID INT,
	WORKER_TITLE CHAR(25),
	AFFECTED_FROM DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

insert into Worker(FIRST_NAME,LAST_NAME,SALARY,JOINING_DATE,DEPARTMENT) 
VALUES('Monika','Arora',100000,'2014-02-20 09:00:00','HR'),
('Niharika','verma',80000,'2014-06-11 09:00:00','ADMIN'),
('Vishal','Singhal',300000,'2014-02-20 09:00:00','HR'),
('Amitabh','Singh',500000,'2014-02-20 09:00:00','ADMIN'),
('Vivek','Bhati',500000,'2014-06-11 09:00:00','ADMIN'),
('Vipul','Diwan',200000,'2014-06-11 09:00:00','ACCOUNT'),
('Satish','Kumar',75000,'2014-01-20 09:00:00','ACCOUNT'),
('Geetika','Chauhan',90000,'2014-04-11 09:00:00','ADMIN')

select * from Worker

insert into Bonus(WORKER_REF_ID,BONUS_DATE,BONUS_AMOUNT)
Values
(1,'2016-02-20 00:00:00',5000),
(2,'2016-06-11 00:00:00',3000),
(3,'2016-02-20 00:00:00',4000),
(1,'2016-02-20 00:00:00',4500),
(2,'2016-06-11 00:00:00',3500)

select * from Bonus

insert into Title(WORKER_REF_ID,WORKER_TITLE,AFFECTED_FROM)
values
(1,'Manager','2026-02-20 00:00:00'),
(2,'Executive','2026-06-11 00:00:00'),
(8,'Executive','2026-06-11 00:00:00'),
(5,'Manager','2026-06-11 00:00:00'),
(4,'Asst. Manager','2026-06-11 00:00:00'),
(7,'Executive','2026-06-11 00:00:00'),
(6,'Lead','2026-06-11 00:00:00'),
(3,'Lead','2026-06-11 00:00:00')

select * from Title


--Questions
--1. . Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.

select FIRST_NAME as WORKER_NAME from Worker

--2. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.

select UPPER(FIRST_NAME) AS FIRST_NAME FROM Worker 

--3. Write an SQL query to fetch unique values of DEPARTMENT from Worker table.

select distinct Department from worker

--4. Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.

select SUBSTRING(FIRST_NAME,1,3) AS First_Three_letters from worker

--5. Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.

select  CHARINDEX('a',FIRST_NAME) AS position from worker
where FIRST_NAME ='Amitabh' 

--6. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.

select RTRIM(First_name) AS TrimmedFirstName from worker 

--7. Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.

select LTRIM(Department) AS TrimmedLeft from worker 

--8. Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.

select distinct department, len(department) AS LengthDepartment from worker

--9. Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’.

select REPLACE(First_name,'a','A') AS ReplaceLetter from worker

--10. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.

select CONCAT(FIRST_NAME,' ',LAST_NAME) AS FULLNAME from Worker

--11. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.

select * from worker
order by first_name asc

--12. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.

select * from worker
order by first_name asc,DEPARTMENT desc

--13. Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.

select * from worker
where first_name ='vipul' or first_name='satish' 

--14. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.

select last_name,salary,joining_date,department from worker
where first_name='vipul' or first_name='satish'

--15. Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.

select * from worker
where DEPARTMENT ='admin'

--16. Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.

select * from worker
where first_name like '%a%'

--17. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’.

select * from worker
where first_name like '%a'

--18. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.

select * from worker
where first_name like '%h' and len(first_name)=6

--19. Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.

select * from worker
where salary between 100000 and 500000

--20 Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.

select * from worker
where SALARY>=50000 and salary <=100000

--21. Write an SQL query to fetch the no. of workers for each department in the descending order.

select count(*) CountOfEachDepartment from worker
group by department
order by department desc

--22. Write an SQL query to print details of the Workers who are also Managers

SELECT w.*
FROM Worker w
JOIN Title t
    ON w.WORKER_ID = t.WORKER_REF_ID
WHERE t.WORKER_TITLE = 'Manager'

--23.Write an SQL query to show the current date and time.\

select getdate() as CurrentDateTime

--24. Write an SQL query to show the top n (say 10) records of a table

select top 10 * from worker






