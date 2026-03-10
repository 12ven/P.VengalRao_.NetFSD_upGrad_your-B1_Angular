--Assignment 8 – Subqueries

--1. Find students whose marks are greater than average marks

select s.firstname from students s
join marks m
on m.studentid=s.StudentId
where m.markobtained>(select avg(markobtained) from marks)

--2. Find courses with maximum credits

select courseName,credits from courses where credits in(select max(credits) from courses)

--3. Find students enrolled in more than 2 courses

select FirstName,LastName from Students where StudentID in(select StudentID from Enrollments group by StudentID having count(CourseID)>2)

--4. Find teachers working in the same department as teacher 'John'

select teachersname from Teachers where DepartmentID=any(select DepartmentID from Teachers where teachersname like 'John%') and teachersname not like 'John%'

--5. Find students who scored highest marks in an exam

select s.FirstName,s.LastName, m.MarkObtained from Students s join Marks m on s.StudentID=m.StudentID where MarkObtained = (select max(MarkObtained) from Marks)


--6. Find departments having maximum number of students

select DepartmentName from Departments d where exists (select DepartmentID from Students group by DepartmentID 
having d.DepartmentID=Students.DepartmentID and count(*)=(select max(StudentCount) from(select COUNT(*) as StudentCount 
from Students group by DepartmentID) as T))