--Assignment 2 – Student Course Enrollment View

--Create a view 

CREATE VIEW vw_StudentCourses AS
SELECT 
    s.StudentID,
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.EnrollmentDate
FROM Students s
JOIN Enrollments e
ON s.StudentID = e.StudentID
JOIN Courses c
ON e.CourseID = c.CourseID;

--1. Show Courses Taken by StudentID = 5
select coursename from vw_StudentCourses
where StudentId =5

--2. Count Courses Taken by Each Student
select studentname, count(coursename) as TotalStudent 
from vw_StudentCourses
group by StudentName

--3.List Students Enrolled After 2024
select * from vw_StudentCourses
where enrollmentdate>'2024-01-01'