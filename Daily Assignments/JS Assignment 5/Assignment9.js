class Product {
    constructor({ name, price, category = "General" }) {
        this.name = name;
        this.price = price;
        this.category = category;
    }

    showInfo = () => {
        return `Product: ${this.name}, Price: ₹${this.price}, Category: ${this.category}`;
    };

    applyDiscount(...discounts) {
        let totalDiscount = discounts.reduce((acc, d) => acc + d, 0);
        this.price -= totalDiscount;
        return `New Price after discounts: ₹${this.price}`;
    }
}

let p1 = new Product({ name: "Laptop", price: 50000 });
console.log(p1.showInfo());
console.log(p1.applyDiscount(2000, 1500));
console.log(p1.showInfo());

let p2 = new Product({ name: "Shoes", price: 3000, category: "Fashion" });
console.log(p2.showInfo());