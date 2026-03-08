--Assignment 5 – Filtering Data (WHERE)

--1. Find students from Computer Science department

SELECT s.StudentID, s.FirstName, s.LastName
FROM Students s
JOIN Departments d 
ON s.DepartmentID = d.DepartmentID
WHERE d.DepartmentName = 'Computer Science';

--2. Find teachers hired after 2022

select * from teachers
where hiredate>'2022-01-01'

--3. Find students whose name starts with 'A'

select * from students
where firstname like 'A%'

--4. Find courses having credits greater than 3

select * from courses
where credits>3

--5. Find students born between 2005 and 2008

select * from students
where dateofbirth between '2005-01-01' and '2008-01-01'

--6. Find students not belonging to Mechanical department

SELECT s.*
FROM Students s
JOIN Departments d
ON s.DepartmentID = d.DepartmentID
WHERE d.DepartmentName <> 'Mechanical';

--7. Find teachers whose salary between 40000 and 70000

select * from teachers
where salary between 40000 and 70000

--8. Find courses not taught by TeacherID = 3

select * from teachers
where teacherId<>3