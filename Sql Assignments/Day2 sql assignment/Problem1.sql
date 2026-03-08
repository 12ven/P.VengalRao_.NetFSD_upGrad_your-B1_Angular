use AssignmentDB

create table Customers(
	customerId int primary key,
	firstname varchar(20),
	lastname varchar(20)
)

create table orders(
	order_Id int primary key,
	customerId int,
	order_Date Date,
	order_status int,
	foreign key (customerid) references customers(customerId)
)

insert into Customers(customerId,firstname,lastname) values
(1,'vengal','rao'),
(2,'nithin','kumar'),
(3,'raghu','ram'),
(4,'phani','reddy')

insert into orders(order_Id,customerId,order_Date,order_status) values
(101,1,'2023-06-10',1),
(102,2,'2023-06-12',4),
(103,3,'2023-06-15',2),
(104,1,'2023-06-20',4)


--1. Retrieve customer first name, last name, order_id, order_date, and order_status.

select c.firstname, c.lastname, o.order_id,o.order_date,o.order_status
from Customers c 
join orders o 
on c.customerId= o.customerId

--2. Display only orders with status Pending (1) or Completed (4).

select c.firstname, c.lastname, o.order_id,o.order_date,o.order_status
from Customers c 
join orders o 
on c.customerId= o.customerId
where o.order_status in(1,4)

--3. Sort the results by order_date in descending order.

select c.firstname, c.lastname, o.order_id,o.order_date,o.order_status
from Customers c 
join orders o 
on c.customerId= o.customerId
where o.order_status in(1,4)
order by order_Date desc





