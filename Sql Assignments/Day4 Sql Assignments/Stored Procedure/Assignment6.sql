--Create Procedure

CREATE PROCEDURE sp_DeleteEnrollment
    @EnrollmentID INT
AS
BEGIN
    DELETE FROM Enrollments
    WHERE EnrollmentID = @EnrollmentID;
END;

--execution
EXEC sp_DeleteEnrollment 10;

--verify delection

select * from enrollments