create database school_management_Db

-- Assigment 1 and 2

-- 1. creating tables and relations

--2. Apply constraints


create table Departments(
	DepartmentId int primary key,
	DepartmentName varchar(50) unique,
	location varchar(30)
)

create table teachers(
	teacherId int primary key,
	teachername varchar(50),
	email varchar(50) unique,
	DepartmentId int,
	hiredate date,
	foreign key (departmentid) references departments(departmentId)
)

create table students(
	StudentId int primary key,
	firstname varchar(50),
	lastname varchar(50),
	dateofbirth date,
	gender char(1) check(Gender in('M','F')),
	departmentid int,
	admission date,
	foreign key (departmentid) references departments(departmentid)
)

create table courses(
	courseid int primary key,
	coursename varchar(50),
	credits int check (credits between 1 and 5),
	departmentid int,
	teacherid int,
	foreign key (departmentid) references departments(departmentid),
	foreign key (teacherid) references teachers(teacherid)

)

create table enrollments(
	enrollmentid int primary key,
	studentid int,
	courseid int,
	enrollmentdate date default cast(getdate() as date),
	foreign key (studentid) references students(studentid),
	foreign key (courseid) references courses(courseid)

)

create table exams(
	examid int primary key,
	courseid int,
	examdate date,
	examtype varchar(50)
)

create table marks(
	marksid int primary key,
	studentid int,
	examid int,
	markobtained int CHECK (markobtained BETWEEN 0 AND 100),
	foreign key (studentid) references students(studentid),
	foreign key (examid) references exams(examid)
)