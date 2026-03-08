--Assignment 6 – Grouping Data (GROUP BY)

--1. Count students in each department

select d.departmentname,count(*) as studentcount
from students s
join Departments d
on s.departmentid=d.DepartmentId
group by(d.DepartmentName)

--2. Find average marks per exam

select examid, avg(markobtained) as AverageMarks
from marks
group by examid

--3. Find total students enrolled per course

SELECT CourseID, COUNT(*) AS StudentCount
FROM Enrollments
GROUP BY CourseID;

--4. Find maximum marks scored in each exam

select examid, max(markobtained) as MaxMarks from marks
group by examid

--5. Find minimum marks per course

SELECT e.CourseID, MIN(m.markobtained) AS MinMarks
FROM Marks m
JOIN Exams e
ON m.ExamID = e.ExamID
GROUP BY e.CourseID;

--6. Find departments having more than 5 students

select d.departmentname, count(*) as Studentcount
from students s
join Departments d
on s.departmentid = d.DepartmentId
group by DepartmentName
having count(*)>5