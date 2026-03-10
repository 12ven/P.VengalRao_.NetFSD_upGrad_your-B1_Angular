--Assignment 2 - Student age function

--create function

CREATE FUNCTION fn_GetStudentAge
(
    @DateOfBirth DATE
)
RETURNS INT
AS
BEGIN
    DECLARE @Age INT

    SET @Age = DATEDIFF(YEAR, @DateOfBirth, GETDATE())

    RETURN @Age
END;

--execution

SELECT 
    StudentID,
    FirstName,
    LastName,
    dbo.fn_GetStudentAge(DateOfBirth) AS Age
FROM Students;