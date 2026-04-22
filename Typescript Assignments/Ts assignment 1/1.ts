class Book{
    isbn:string;
    bookname:string;
    booktitle:string;
    bookauthor:string;
    quantityofbooks:number;
    bookprice:number;

    constructor(isbn:string,bookname:string,booktitle:string,bookauthor:string,quantityofbooks:number,bookprice:number){
        this.isbn = isbn;
        this.bookname=bookname;
        this.booktitle=booktitle;
        this.bookauthor=bookauthor;
        this.quantityofbooks=quantityofbooks;
        this.bookprice=bookprice;
    }

    displayDetails():void{
        console.log(`ISBN: $(this.isbn)`);
        console.log(`Book Name: $(this.bookname)`);
        console.log(`Book Title: $(this.booktitle)`);
        console.log(`Book Author: $(this.bookauthor)`);
        console.log(`Quantity of Books: $(this.quantityofbooks)`);
        console.log(`Book Price: $(this.bookprice)`);
    }

    calculateTotalPrice():number{
        return this.quantityofbooks * this.bookprice;
    }       

}

const book1 = new Book("1","To get success","Aim","Ram",5,50);
book1.displayDetails();
console.log("Bill Amount: "+book1.calculateTotalPrice());
