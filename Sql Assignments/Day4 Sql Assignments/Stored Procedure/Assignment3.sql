--Assignment 3 – Course Enrollment Procedure

--Create Procedure

CREATE PROCEDURE sp_EnrollStudent
    @StudentID INT,
    @CourseID INT
AS
BEGIN
    INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate)
    VALUES (@StudentID, @CourseID, GETDATE());
END;


--execution

EXEC sp_EnrollStudent 5, 201;