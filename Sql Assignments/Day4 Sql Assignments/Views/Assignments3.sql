--Assignment 3 – Exam Result View

--create a view 

CREATE VIEW vw_ExamResults AS
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.ExamType,
    m.MarkObtained AS MarksObtained
FROM Marks m
JOIN Students s
ON m.StudentID = s.StudentID
JOIN Exams e
ON m.ExamID = e.ExamID
JOIN Courses c
ON e.CourseID = c.CourseID;


--1. Retrieve Students Scoring More Than 80

select studentname from vw_ExamResults
where MarksObtained>80

--2. Retrieve Top Scorers in Each Exam

select * from vw_ExamResults
where MarksObtained in(
	select max(MarksObtained) 
	from vw_ExamResults
	group by examtype
)

--3. Find Students Who Failed (example: marks < 40)

select * from vw_ExamResults
where MarksObtained<40