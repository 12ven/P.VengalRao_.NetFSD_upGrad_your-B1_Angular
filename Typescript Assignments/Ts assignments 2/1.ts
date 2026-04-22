class Vehicle{
    brand:string;
    speed:number;
    constructor(brand:string,speed:number){
        this.brand = brand;
        this.speed = speed;
    }

    move():void{
        console.log("Vehicle is moving");
    }
}

class Car extends Vehicle{
    fuelType:string;
    constructor(brand:string,speed:number,fuelType:string){
        super(brand,speed);
        this.fuelType = fuelType;
    }

    move():void{
        console.log("Car is moving at ${this.spped} km/h");
    }
}

class Bike extends Vehicle{
    hasGear:boolean;

    constructor(brand:string,speed:number,hasGear:boolean){
        super(brand,speed);
        this.hasGear = hasGear;
    }

    move():void{
        console.log("Bike is moving at ${this.speed} km/h");
    }
}

const car1 = new Car("Toyota", 120, "Petrol");
car1.move();
const bike1 = new Bike("Honda", 80, true);
bike1.move();