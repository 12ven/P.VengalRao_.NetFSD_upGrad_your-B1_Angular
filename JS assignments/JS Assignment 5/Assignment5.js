class Employee{
    constructor(name,salary) {
        this.name = name;
        this.salary = salary;
    }
    getDetails(){
        return `Name : ${this.name} Salary: ${this.salary}`;
    }
}

class Manager extends Employee{
    constructor(name,salary,bouns){
        super(name,salary);
        this.bouns =bouns;
    }
    getTotalSalary(){
        let totalSalary = this.salary+this.bouns;
        return `Total Salary :${totalSalary}`;
    }
}

class Director extends Manager{
    constructor(name,salary,bouns,stockOptions) {
        super(name,salary,bouns);
        this.stockOptions = stockOptions;
    }
    getFullCompensation(){
        let fullCompensation = this.salary+this.bouns+this.stockOptions;
        return `Full Compensation: ${fullCompensation}`;

    }
}

const director1 = new Director('Vengal',45000,5000,300);
console.log(director1.getDetails());
console.log(director1.getTotalSalary());
console.log(director1.getFullCompensation());