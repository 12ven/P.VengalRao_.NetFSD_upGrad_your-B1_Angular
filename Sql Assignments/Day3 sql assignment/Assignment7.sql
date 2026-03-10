--Assignment 7 – Joins


--1. Show students with department names

select s.firstname, d.DepartmentName from students s
join Departments d
on s.departmentid = d.DepartmentId

--2. Show courses with teacher names

select c.coursename, t.teachersname 
from courses c
join teachers t
on c.teacherid=t.teacherId

--3. Show student name and enrolled courses

select s.firstname,c.courseName
from enrollments e
join courses c
on e.courseid = c.courseid
join students s
on e.studentid = s.studentid


--4. Show students with exam marks

select s.firstname, m.markobtained
from marks m
join exams e 
on m.examid = e.examid
join students s
on m.studentid=s.studentid

--5. Show all courses and teachers (even if no teacher assigned)

select c.coursename, t.teachersname
from courses c
left join teachers t
on c.teacherid=t.teacherId


--6. Show teachers who are not assigned to any course

select t.teachersname from teachers t left join courses c
on c.teacherid =t.teacherId
where c.teacherId is null