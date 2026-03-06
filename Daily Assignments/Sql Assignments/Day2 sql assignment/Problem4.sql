use AssignmentDB

CREATE TABLE products_Stock (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100)
);

CREATE TABLE product_stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
);

CREATE TABLE product_stocks (
    store_id INT,
    product_id INT,
    quantity INT,
    PRIMARY KEY (store_id, product_id),
    FOREIGN KEY (store_id) REFERENCES product_stores(store_id),
    FOREIGN KEY (product_id) REFERENCES products_stock(product_id)
);

CREATE TABLE product_order_items (
    item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT
);

INSERT INTO products_stock VALUES
(1,'Mountain Bike'),
(2,'Road Bike'),
(3,'Electric Bike');

INSERT INTO product_stores VALUES
(1,'New York Store'),
(2,'Los Angeles Store');

INSERT INTO product_stocks VALUES
(1,1,50),
(1,2,40),
(2,1,30),
(2,3,20);

INSERT INTO product_order_items VALUES
(1,101,1,5),
(2,102,1,3),
(3,103,2,7);

--1. Display product_name, store_name, available stock quantity, and total quantity sold.

SELECT 
p.product_name,
s.store_name,
st.quantity AS available_stock,
oi.quantity AS sold_quantity
FROM product_stocks st
INNER JOIN products_stock p
ON st.product_id = p.product_id
INNER JOIN product_stores s
ON st.store_id = s.store_id
LEFT JOIN product_order_items oi
ON st.product_id = oi.product_id;

--2. Include products even if they have not been sold (use appropriate join).

SELECT 
p.product_name,
s.store_name,
st.quantity AS available_stock,
SUM(oi.quantity) AS total_quantity_sold
FROM product_stocks st
INNER JOIN products_stock p
ON st.product_id = p.product_id
INNER JOIN product_stores s
ON st.store_id = s.store_id
LEFT JOIN product_order_items oi
ON st.product_id = oi.product_id
GROUP BY 
p.product_name,
s.store_name,
st.quantity
ORDER BY p.product_name;


--3. Group results by product_name and store_name.

SELECT 
p.product_name,
s.store_name,
st.quantity AS available_stock,
SUM(oi.quantity) AS total_quantity_sold
FROM product_stocks st
INNER JOIN products_stock p
ON st.product_id = p.product_id
INNER JOIN product_stores s
ON st.store_id = s.store_id
LEFT JOIN product_order_items oi
ON st.product_id = oi.product_id
GROUP BY 
p.product_name,
s.store_name,
st.quantity

--4. Sort results by product_name.

SELECT 
p.product_name,
s.store_name,
st.quantity AS available_stock,
SUM(oi.quantity) AS total_quantity_sold
FROM product_stocks st
INNER JOIN products_stock p
ON st.product_id = p.product_id
INNER JOIN product_stores s
ON st.store_id = s.store_id
LEFT JOIN product_order_items oi
ON st.product_id = oi.product_id
GROUP BY 
p.product_name,
s.store_name,
st.quantity
order by p.product_name

