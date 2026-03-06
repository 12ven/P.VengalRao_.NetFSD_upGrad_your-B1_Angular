use AssignmentDB

CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
)

CREATE TABLE store_orders (
    order_id INT PRIMARY KEY,
    store_id INT,
    order_status INT,
    FOREIGN KEY (store_id) REFERENCES stores(store_id)
)

CREATE TABLE store_order_items (
    item_id INT PRIMARY KEY,
    order_id INT,
    quantity INT,
    list_price DECIMAL(10,2),
    discount DECIMAL(4,2),
    FOREIGN KEY (order_id) REFERENCES store_orders(order_id)
)

INSERT INTO stores VALUES
(1,'New York Store'),
(2,'Los Angeles Store'),
(3,'Chicago Store')

INSERT INTO store_orders VALUES
(101,1,4),
(102,2,4),
(103,3,2),
(104,1,4)

INSERT INTO store_order_items VALUES
(1,101,2,500,0.10),
(2,101,1,800,0.05),
(3,102,3,300,0.00),
(4,103,2,400,0.10),
(5,104,1,1000,0.20);


--1,2. Display store_name and total sales amount.

SELECT 
s.store_name,
(oi.quantity * oi.list_price * (1 - oi.discount)) AS sales_amount
FROM stores s
INNER JOIN Store_orders o
ON s.store_id = o.store_id
INNER JOIN store_order_items oi
ON o.order_id = oi.order_id;

--3. Include only completed orders (order_status = 4).

SELECT 
s.store_name,
(oi.quantity * oi.list_price * (1 - oi.discount)) AS sales_amount
FROM stores s
INNER JOIN Store_orders o
ON s.store_id = o.store_id
INNER JOIN store_order_items oi
ON o.order_id = oi.order_id
where o.order_status =4

--4. Group results by store_name.

SELECT 
s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN store_orders o
ON s.store_id = o.store_id
INNER JOIN store_order_items oi
ON o.order_id = oi.order_id
WHERE o.order_status = 4
GROUP BY s.store_name;

--5. Sort total sales in descending order.

SELECT 
s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN store_orders o
ON s.store_id = o.store_id
INNER JOIN store_order_items oi
ON o.order_id = oi.order_id
WHERE o.order_status = 4
GROUP BY s.store_name
order by total_sales desc




