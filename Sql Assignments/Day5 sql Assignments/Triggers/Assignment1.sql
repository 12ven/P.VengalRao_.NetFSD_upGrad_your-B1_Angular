-- Triggers

--Assignment 1. Audit Trigger to students

--create a studentAudit

create table studentsAudit(
	AuditID int primary key identity(1,1),
	StudentId int,
	ActionType varchar(20),
	ActionDate date
	foreign key (studentId) references Students(studentid)
)

--create trigger

create trigger trg_StudentInsertAudit
on students
after insert 
as
begin
insert into studentsAudit(StudentId,ActionType,ActionDate)
select StudentId,'Insert',GETDATE() from inserted
end

select * from students

INSERT INTO Students (StudentID, FirstName, LastName, Gender, DepartmentID, Admission)
VALUES (101, 'Test', 'Student', 'M', 1, '2024-06-01');
select * from studentsAudit

INSERT INTO Students (StudentID, FirstName, LastName, Gender, DepartmentID, Admission)
VALUES
(102,'Amit','Sharma','M',1,'2024-06-02'),
(103,'Priya','Verma','F',2,'2024-06-02');