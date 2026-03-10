--Assignment 5 – Update Student Marks

--Create Procedure

CREATE PROCEDURE sp_UpdateMarks
    @MarkID INT,
    @NewMarks INT
AS
BEGIN
    UPDATE Marks
    SET MarkObtained = @NewMarks
    WHERE MarkID = @MarkID;

    SELECT * FROM Marks
    WHERE MarkID = @MarkID;
END;


--execution
EXEC sp_UpdateMarks 1, 90;
