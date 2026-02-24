
let books = [
  { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
  { id: 2, title: "React Guide", price: 650, stock: 5 },
  { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
  { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];


let titles = books.map(book => book.title);
console.log("Book Titles: " + titles);


let totalValue = books.reduce((sum, book) => sum + (book.price * book.stock), 0);
console.log("Total Inventory Value: " + totalValue);


let costlyBooks = books.filter(book => book.price > 500);
console.log("Books above ₹500:", costlyBooks);


let updatedPrices = books.map(book => ({
  ...book, 
  price: book.price * 1.05 
}));
console.log("Books with 5% price increase:", updatedPrices);


let sortedBooks = [...books].sort((a, b) => a.price - b.price);
console.log("Books sorted by price:", sortedBooks);


let removeId = 2; 
let remainingBooks = books.filter(book => book.id !== removeId);
console.log("After removing book ID 2:", remainingBooks);


let outOfStock = books.some(book => book.stock === 0);
console.log("Any book out of stock?", outOfStock);


let grouped = {
  low: books.filter(book => book.price < 400),
  mid: books.filter(book => book.price >= 400 && book.price <= 600),
  high: books.filter(book => book.price > 600)
};
console.log("Grouped by price range:", grouped);


let discounted = books.map(book =>
  book.price > 600 ? { ...book, price: book.price * 0.9 } : book
);
console.log("Discounted books:", discounted);


let invoice = books.map(book => `${book.title} - ₹${book.price}`).join(" | ");
console.log("Invoice:", invoice);