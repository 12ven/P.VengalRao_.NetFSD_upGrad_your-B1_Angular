--Assignment 3

--1. Add a column PhoneNumber to Students table.

alter table students
add phonenumber varchar(15)


--2. Add column Salary to Teachers table.

alter table teachers 
add salary int

--3. Modify Salary datatype.

alter table teachers
alter column salary decimal(10,2)

--4. Add CHECK constraint to Salary (salary > 20000).

alter table teachers
add constraint salary check(salary>20000)

--5. Drop PhoneNumber column.

alter table students
drop column phonenumber

--6. Rename a column.

EXEC sp_rename 'Teachers.teachername', 'teachersname', 'COLUMN';