

let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];


let totalValue = cart.reduce((sum, item) => sum + item.price * item.qty, 0);
console.log("Total Cart Value: ₹" + totalValue);


let updatedQty = cart.map(item =>
  item.id === 2 ? { ...item, qty: item.qty + 1 } : item
);
console.log("After increasing quantity of Headphones:", updatedQty);


let removedProduct = cart.filter(item => item.id !== 3);
console.log("After removing Mouse:", removedProduct);


let discountedCart = cart.map(item =>
  item.price > 10000 ? { ...item, price: item.price * 0.9 } : item
);
console.log("After 10% discount on items > ₹10,000:", discountedCart);


let sortedCart = [...cart].sort((a, b) => (a.price * a.qty) - (b.price * b.qty));
console.log("Cart sorted by total item price:", sortedCart);


let hasExpensive = cart.some(item => item.price > 50000);
console.log("Any product costs more than ₹50,000?", hasExpensive);


let allInStock = cart.every(item => item.qty > 0);
console.log("All items in stock?", allInStock);


let invoice = cart.map(item => `${item.product} x${item.qty} - ₹${item.price * item.qty}`).join(" | ");
console.log("Invoice:", invoice);


let mostExpensive = cart.reduce((max, item) => (item.price > max.price ? item : max), cart[0]);
console.log("Most Expensive Product:", mostExpensive);


let gst = totalValue * 0.18;
console.log("GST (18%): ₹" + gst.toFixed(2));