--views


--Assignment 1 – Student Department View

CREATE VIEW vw_StudentDepartment AS
SELECT 
    s.StudentID,
    s.FirstName + ' ' + s.LastName AS StudentName,
    d.DepartmentName,
    s.admission
FROM Students s
JOIN Departments d
ON s.DepartmentID = d.DepartmentID;

--1.Retrieve All Records

select * from vw_StudentDepartment

--2.Filter Students from Computer Science Department

select * from vw_StudentDepartment where DepartmentName='computer science'

--3. Drop the View

drop view vw_StudentDepartment