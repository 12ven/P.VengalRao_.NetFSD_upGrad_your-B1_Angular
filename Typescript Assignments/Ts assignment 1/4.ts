class Student{
    RollNo:number;
    StudentName:string;
    MarksInEnglish:number;
    MarksInMaths:number;
    MarksInScience:number;

    constructor(RollNo:number,StudentName:string,MarksInEnglish:number,MarksInMaths:number,MarksInScience:number){
        this.RollNo = RollNo;
        this.StudentName = StudentName;
        this.MarksInEnglish = MarksInEnglish;
        this.MarksInMaths = MarksInMaths;
        this.MarksInScience = MarksInScience;
    }

    displayResults():void{
        let totalMarks = this.MarksInEnglish + this.MarksInMaths + this.MarksInScience;
        let percentage = (totalMarks / 300) * 100;
        console.log(`Total Marks: ${totalMarks}`);
        console.log(`Percentage: ${percentage.toFixed(2)}%`);
    }
}

const student1 = new Student(1,"Vengal",85,90,80);
student1.displayResults();