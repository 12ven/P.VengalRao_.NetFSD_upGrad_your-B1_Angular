--Assignment 10 – Indexes

--1. Create index on Student LastName

CREATE INDEX IDX_STUDENT_LASTNAME ON Students(LastName)

--2. Create index on Teacher Email

create index idx_teacher_email on teachers(email)

--3. Create composite index on
--StudentID + CourseID
--in Enrollments table

CREATE INDEX IDX_Enrollment_StudentCourse ON Enrollments(StudentID,CourseID)


--4. Create unique index on DepartmentName

CREATE UNIQUE INDEX UQ_IDX_DepartmentName ON Departments(DepartmentName)

--5. Drop an index

DROP INDEX IDX_STUDENT_LASTNAME ON Students