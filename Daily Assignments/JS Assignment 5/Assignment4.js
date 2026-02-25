class Vehicle{
    constructor(brand,speed){
        this.brand = brand;
        this.speed = speed;
    }
    start(){
        if(this.speed>0) return "Vehical Started."
        else return "Increase the speed."
    }
}

class Car extends Vehicle{
    constructor(brand,speed,fuelType){
        super(brand,speed);
        this.fuelType = fuelType;
    }
    showDetails(){
        return `Brand : ${this.brand} Speed : ${this.speed} Status: ${this.start()} FuelType: ${this.fuelType}`
    }
}

const car1 = new Car('Toyota',24,'diesel');
console.log(car1.showDetails());