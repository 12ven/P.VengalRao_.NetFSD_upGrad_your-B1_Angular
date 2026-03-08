class Student{
    constructor(name,marks){
        this.name=name;
        this.marks=marks;
    }

    addMark(mark){
        this.marks.push(mark);
        return this.marks;
    }

    getAverage(){
        let total =0;
        for(let mark of this.marks)
            total+=mark;
        let avg = total/this.marks.length;
        return avg;
    }

    getGrade(){
        let avg = this.getAverage();
        
        if(avg>=90) return `${avg} got A Grade`
        else if(avg>=75) return `${avg} got B Grade`
        else if(avg>=50) return `${got} got C Grade`
        else return `${avg} got Fail`
           
    }

}
const student1 = new Student('vengal',[34,34,23,12]);
console.log(student1.addMark(45));
console.log(student1.getAverage());
console.log(student1.getGrade());