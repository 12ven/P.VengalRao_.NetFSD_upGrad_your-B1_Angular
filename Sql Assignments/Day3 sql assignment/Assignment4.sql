--Assignement 4


--Students must insert minimum:
-- 5 Departments
-- 10 Teachers
-- 20 Students
-- 10 Courses
-- 30 Enrollments
-- 5 Exams
-- 30 Marks

INSERT INTO Departments VALUES
(1,'Computer Science','Block A'),
(2,'Electronics','Block B'),
(3,'Mechanical','Block C'),
(4,'Civil','Block D'),
(5,'Mathematics','Block E')


INSERT INTO teachers VALUES
(101,'Ramesh Kumar','ramesh@school.com',1,'2018-06-10',30000),
(102,'Sita Devi','sita@school.com',2,'2019-03-12',32000),
(103,'Anil Sharma','anil@school.com',3,'2017-07-21',35000),
(104,'Priya Nair','priya@school.com',4,'2020-01-15',28000),
(105,'Raj Patel','raj@school.com',5,'2016-11-25',40000),
(106,'Kiran Rao','kiran@school.com',1,'2019-05-17',31000),
(107,'Deepa Iyer','deepa@school.com',2,'2018-09-30',33000),
(108,'Sunil Verma','sunil@school.com',3,'2017-12-11',36000),
(109,'Meena Das','meena@school.com',4,'2021-02-20',27000),
(110,'Arjun Singh','arjun@school.com',5,'2016-08-14',42000);

INSERT INTO students VALUES
(1,'Rahul','Reddy','2002-04-12','M',1,'2021-06-10'),
(2,'Sneha','Sharma','2003-01-22','F',2,'2021-06-10'),
(3,'Vikas','Kumar','2002-09-18','M',3,'2021-06-10'),
(4,'Divya','Nair','2003-03-10','F',4,'2021-06-10'),
(5,'Karthik','Patel','2002-12-01','M',5,'2021-06-10'),
(6,'Pooja','Das','2002-05-21','F',1,'2021-06-10'),
(7,'Amit','Singh','2003-06-14','M',2,'2021-06-10'),
(8,'Neha','Verma','2002-11-19','F',3,'2021-06-10'),
(9,'Ravi','Gupta','2003-07-09','M',4,'2021-06-10'),
(10,'Anita','Rao','2002-08-30','F',5,'2021-06-10'),
(11,'Suresh','Yadav','2002-02-15','M',1,'2021-06-10'),
(12,'Lakshmi','Iyer','2003-10-11','F',2,'2021-06-10'),
(13,'Manoj','Shah','2002-01-27','M',3,'2021-06-10'),
(14,'Kavya','Menon','2003-04-05','F',4,'2021-06-10'),
(15,'Arun','Babu','2002-09-09','M',5,'2021-06-10'),
(16,'Nisha','Kapoor','2003-02-18','F',1,'2021-06-10'),
(17,'Varun','Mehta','2002-07-23','M',2,'2021-06-10'),
(18,'Ritu','Agarwal','2003-03-28','F',3,'2021-06-10'),
(19,'Tarun','Joshi','2002-06-17','M',4,'2021-06-10'),
(20,'Swathi','Reddy','2003-05-13','F',5,'2021-06-10');

INSERT INTO courses VALUES
(201,'Database Systems',4,1,101),
(202,'Data Structures',3,1,106),
(203,'Digital Electronics',4,2,102),
(204,'Signals and Systems',3,2,107),
(205,'Thermodynamics',4,3,103),
(206,'Machine Design',3,3,108),
(207,'Structural Engineering',4,4,104),
(208,'Construction Management',3,4,109),
(209,'Calculus',4,5,105),
(210,'Linear Algebra',3,5,110);

INSERT INTO exams VALUES
(301,201,'2024-05-10','Midterm'),
(302,202,'2024-05-12','Midterm'),
(303,203,'2024-05-15','Midterm'),
(304,205,'2024-05-18','Final'),
(305,209,'2024-05-20','Final');


INSERT INTO enrollments VALUES
(1,1,201,GETDATE()),
(2,2,202,GETDATE()),
(3,3,203,GETDATE()),
(4,4,204,GETDATE()),
(5,5,205,GETDATE()),
(6,6,206,GETDATE()),
(7,7,207,GETDATE()),
(8,8,208,GETDATE()),
(9,9,209,GETDATE()),
(10,10,210,GETDATE()),
(11,11,201,GETDATE()),
(12,12,202,GETDATE()),
(13,13,203,GETDATE()),
(14,14,204,GETDATE()),
(15,15,205,GETDATE()),
(16,16,206,GETDATE()),
(17,17,207,GETDATE()),
(18,18,208,GETDATE()),
(19,19,209,GETDATE()),
(20,20,210,GETDATE()),
(21,1,202,GETDATE()),
(22,2,203,GETDATE()),
(23,3,204,GETDATE()),
(24,4,205,GETDATE()),
(25,5,206,GETDATE()),
(26,6,207,GETDATE()),
(27,7,208,GETDATE()),
(28,8,209,GETDATE()),
(29,9,210,GETDATE()),
(30,10,201,GETDATE());


INSERT INTO marks VALUES
(1,1,301,85),
(2,2,302,78),
(3,3,303,90),
(4,4,304,67),
(5,5,305,88),
(6,6,301,75),
(7,7,302,82),
(8,8,303,69),
(9,9,304,91),
(10,10,305,73),
(11,11,301,80),
(12,12,302,77),
(13,13,303,84),
(14,14,304,66),
(15,15,305,92),
(16,16,301,70),
(17,17,302,85),
(18,18,303,79),
(19,19,304,88),
(20,20,305,74),
(21,1,302,81),
(22,2,303,76),
(23,3,304,89),
(24,4,305,68),
(25,5,301,90),
(26,6,302,72),
(27,7,303,83),
(28,8,304,65),
(29,9,305,87),
(30,10,301,78);