--Assignment 2 – Get Students By Department

--create procedure

CREATE PROCEDURE sp_GetStudentsByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        StudentID,
        FirstName + ' ' + LastName AS StudentName,
        AdmissionDate
    FROM Students
    WHERE DepartmentID = @DepartmentID;
END;


--execution

EXEC sp_GetStudentsByDepartment 2;


--Execute for DepartmentID = 3

EXEC sp_GetStudentsByDepartment 3;