--3. User Defined Functions Assignments

--Assignment 1 – Calculate Grade (Scalar Function)

CREATE FUNCTION fn_GetGrade
(
    @MarksObtained INT
)
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @Grade VARCHAR(10)

    IF @MarksObtained >= 90
        SET @Grade = 'A'
    ELSE IF @MarksObtained >= 75
        SET @Grade = 'B'
    ELSE IF @MarksObtained >= 60
        SET @Grade = 'C'
    ELSE
        SET @Grade = 'Fail'

    RETURN @Grade
END;