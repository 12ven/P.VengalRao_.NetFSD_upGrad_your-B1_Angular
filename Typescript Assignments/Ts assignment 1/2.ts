class Shapes{
    public RectangleArea(Length:number,Breadth:number):number{
        return Length*Breadth;
    }
    public SquareArea(Side:number):number{
        return Side*Side;
    }
    public CircleArea(Radius:number):number{
        return 3.14*Radius*Radius;
    }
    public TriangleArea(Base:number,Height:number):number{
        return 0.5*Base*Height;
    }   
}

const shape1 = new Shapes();
console.log("Area of Rectangle: "+shape1.RectangleArea(5,10));
console.log("Area of Square: "+shape1.SquareArea(5));
console.log("Area of Circle: "+shape1.CircleArea(5));
console.log("Area of Triangle: "+shape1.TriangleArea(5,10));