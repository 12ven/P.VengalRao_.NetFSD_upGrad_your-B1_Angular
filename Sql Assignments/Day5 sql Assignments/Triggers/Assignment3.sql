--Assignment 3 – Update Marks Trigger

--create marksaudit table 

create table marksAudit(
	AuditID int primary key identity(1,1),
	StudentId int,
	Examid int,
	oldmarks int,
	newmarks int,
	updateDate datetime
)

--create trigger

CREATE TRIGGER trg_UpdateMarksAudit
ON Marks
AFTER UPDATE
AS
BEGIN
    INSERT INTO MarksAudit (StudentID, ExamID, OldMarks, NewMarks, UpdateDate)
    SELECT 
        d.StudentID,
        d.ExamID,
        d.MarkObtained,
        i.MarkObtained,
        GETDATE()
    FROM deleted d
    JOIN inserted i
    ON d.MarksID = i.MarksID;
END


UPDATE Marks
SET MarkObtained = 90
WHERE MarksID = 1;

SELECT * FROM MarksAudit;