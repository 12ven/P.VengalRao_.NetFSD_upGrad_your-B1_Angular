interface Payment{
    amount: number;
    pay(): void;
}

interface Refundable{
    refund(): void;
}

class CreditCardpayment implements Payment, Refundable{
    amount:number;

    constructor(amount:number){
        this.amount = amount
    }
    pay():void{
        console.log(`Paid ₹${this.amount} using Credit Card`);
    }
    refund():void{
        console.log("Refunded initiated to credit card");
    }
}

class UPIpayment implements Payment{
    amount:number;

    constructor(amount:number){
        this.amount = amount;
    }


    pay():void{
        console.log(`Paid ₹${this.amount} using UPI`);
    }
}

const creditCardPayment = new CreditCardpayment(1000);
creditCardPayment.pay();
creditCardPayment.refund();

const upiPayment = new UPIpayment(500);
upiPayment.pay();
