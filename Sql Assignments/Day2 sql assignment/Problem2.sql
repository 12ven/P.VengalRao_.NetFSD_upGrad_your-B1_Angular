use AssignmentDB

create table brands(
	brandid int primary key,
	brandName varchar(50)
)

create table categories(
	categoriesId int primary key,
	categoriesName varchar(50)
)

create table products(
	productId int primary key,
	productName varchar(50),
	brandId int,
	categoriesId int,
	modelyear int,
	listPrice decimal(10,2),
	foreign key (brandId) references brands(brandId),
	foreign key (categoriesId) references categories(categoriesId)
)



INSERT INTO brands VALUES
(1,'Trek'),
(2,'Giant'),
(3,'Specialized');

INSERT INTO categories VALUES
(1,'Mountain Bikes'),
(2,'Road Bikes'),
(3,'Electric Bikes');

INSERT INTO products VALUES
(101,'Trek X-Caliber 8',1,1,2022,850),
(102,'Giant Escape 3',2,2,2023,450),
(103,'Specialized Turbo',3,3,2022,1200),
(104,'Trek Marlin 7',1,1,2023,650);

-- 1. Display product_name, brand_name, category_name, model_year, and list_price.

select p.productName, b.brandName, c.categoriesName, p.modelYear, p.listPrice
from products p
join brands b
on p.brandId = b.brandid
join categories c
on p.categoriesId= c.categoriesId

-- 2. Filter products with list_price greater than 500.

select p.productName, b.brandName, c.categoriesName, p.modelYear, p.listPrice
from products p
join brands b
on p.brandId = b.brandid
join categories c
on p.categoriesId= c.categoriesId
where p.listPrice>500


-- 3. Sort results by list_price in ascending order.

select p.productName, b.brandName, c.categoriesName, p.modelYear, p.listPrice
from products p
join brands b
on p.brandId = b.brandid
join categories c
on p.categoriesId= c.categoriesId
where p.listPrice>500
order by listPrice