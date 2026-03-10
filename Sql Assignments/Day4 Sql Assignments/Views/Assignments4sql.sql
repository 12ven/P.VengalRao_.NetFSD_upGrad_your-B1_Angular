--Assignment 4 – Aggregate View

--create a view 

CREATE VIEW vw_DepartmentStudentCount AS
SELECT 
    d.DepartmentName,
    COUNT(s.StudentID) AS TotalStudents
FROM Departments d
LEFT JOIN Students s
ON d.DepartmentID = s.DepartmentID
GROUP BY d.DepartmentName;

--1. Retrieve Departments with More Than 10 Students

select * from vw_DepartmentStudentCount
where TotalStudents>10

--2. Sort Departments by Highest Student Count

SELECT *
FROM vw_DepartmentStudentCount
ORDER BY TotalStudents DESC;
