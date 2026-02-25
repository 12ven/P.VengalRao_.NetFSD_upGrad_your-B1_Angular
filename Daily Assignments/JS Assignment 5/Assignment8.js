class Payment{
    pay(amount){
        return 'Payment method not selected'
    }
}

class CreditCardPayment extends Payment{
    pay(amount){
        return `Payment of ${amount} done through Credit Card.`
    }
}

class UPIPayment extends Payment{
    pay(amount){
        return `Payment of ${amount} done through UPI.`
    }
}

class Cashpayment extends Payment{
    pay(amount){
        return `Payment of ${amount} done through Cash.`
    }
}

let paymentMethod = [
    new CreditCardPayment(),
    new UPIPayment(),
    new Cashpayment()
]
paymentMethod.forEach(method=>console.log(method.pay(1000)));