class Wallet {
    #balance = 0;

    addMoney(amount) {
        if (amount > 0) {
            this.#balance += amount;
            return `Added ₹${amount}. Current Balance: ₹${this.#balance}`;
        } else {
            return "Amount must be positive.";
        }
    }

    spendMoney(amount) {
        if (amount > this.#balance) {
            return "Insufficient balance.";
        } else {
            this.#balance -= amount;
            return `Spent ₹${amount}. Current Balance: ₹${this.#balance}`;
        }
    }

    getBalance() {
        return this.#balance;
    }
}

let myWallet = new Wallet();
console.log(myWallet.addMoney(2000));
console.log(myWallet.spendMoney(500));
console.log(myWallet.getBalance());