
--Assignment 2. Prevent deleting student who 

CREATE TRIGGER trg_PreventStudentDelete
ON Students
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Enrollments e
        JOIN deleted d
        ON e.StudentID = d.StudentID
    )
    BEGIN
        RAISERROR('Student has course enrollments and cannot be deleted',16,1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    DELETE FROM Students
    WHERE StudentID IN (SELECT StudentID FROM deleted);
END;


delete from students where StudentId=1
select * from students

delete from students where StudentId=101