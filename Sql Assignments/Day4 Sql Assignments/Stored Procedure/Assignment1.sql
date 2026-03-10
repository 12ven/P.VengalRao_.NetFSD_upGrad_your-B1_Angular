--Assignment 1 – Insert Student Procedure


--create procedure

create procedure sp_InsertStudents
@firstname varchar(20),
@lastname varchar(20),
@gender char(1),
@departmentid int,
@admissiondate date

as
begin
insert into students(firstname,lastname,gender,departmentid,admission)
values(@firstname,@lastname,@gender,@departmentid,@admissiondate)
end

--execution 
exec sp_InsertStudents
	@firstname = 'vengal',
	@lastname ='rao',
	@gender ='M',
	@departmentid = 21,
	@admissiondate = '2026-03-10'


--Verify Inserted Data
select * from students

