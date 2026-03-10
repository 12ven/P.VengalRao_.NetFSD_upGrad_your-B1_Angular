--Assignment 9 – Views

--

CREATE VIEW StudentDepartmentView AS
SELECT 
    s.StudentID,
    s.FirstName + ' ' + s.LastName AS StudentName,
    d.DepartmentName
FROM Students s
JOIN Departments d
ON s.DepartmentID = d.DepartmentID;

CREATE VIEW StudentCourseEnrollmentView AS
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.EnrollmentDate
FROM Enrollments e
JOIN Students s
ON e.StudentID = s.StudentID
JOIN Courses c
ON e.CourseID = c.CourseID;


CREATE VIEW ExamResultView AS
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.ExamType,
    m.MarkObtained
FROM Marks m
JOIN Students s
ON m.StudentID = s.StudentID
JOIN Exams e
ON m.ExamID = e.ExamID
JOIN Courses c
ON e.CourseID = c.CourseID;

SELECT * FROM StudentDepartmentView;

SELECT * FROM StudentCourseEnrollmentView;

SELECT * FROM ExamResultView;


UPDATE StudentDepartmentView
SET StudentName = 'Rahul Kumar'
WHERE StudentID = 1;

UPDATE Students
SET FirstName = 'Rahul'
WHERE StudentID = 1;


DROP VIEW StudentDepartmentView;

DROP VIEW StudentCourseEnrollmentView;

DROP VIEW ExamResultView;