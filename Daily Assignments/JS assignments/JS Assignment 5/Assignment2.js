class BankAccount{
    constructor(accountHolder,balance){
        this.accountHolder=accountHolder;
        this.balance=balance;
    }

    deposit(amount){
        this.balance+=amount;
        return 'Amount deposited'

    }

    withdraw(amount){
        if(amount>this.balance) return 'Insufficient amount'
        else{
            this.balance-=amount;
            return `${amount} is withdraw`
        } 
    }

    checkBalance(){
        return this.balance
    }
}

const person = new BankAccount('Vengal',1000);
console.log(person.deposit(1000));
console.log(person.withdraw(500));
console.log(person.checkBalance());