--Assignment 5 – Department Students Function (Table-Valued)

--Create Function

CREATE FUNCTION fn_GetDepartmentStudents
(
    @DepartmentID INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        StudentID,
        FirstName + ' ' + LastName AS StudentName,
        AdmissionDate
    FROM Students
    WHERE DepartmentID = @DepartmentID
);

--exection

SELECT *
FROM dbo.fn_GetDepartmentStudents(2);