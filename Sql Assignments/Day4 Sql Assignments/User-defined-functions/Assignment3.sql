--Assignment 3 – Total Marks Function (Scalar)


--Create Function


CREATE FUNCTION fn_GetTotalMarks
(
    @StudentID INT
)
RETURNS INT
AS
BEGIN
    DECLARE @TotalMarks INT

    SELECT @TotalMarks = SUM(MarkObtained)
    FROM Marks
    WHERE StudentID = @StudentID

    RETURN @TotalMarks
END;


--exection

SELECT 
    StudentID,
    dbo.fn_GetTotalMarks(StudentID) AS TotalMarks
FROM Students;