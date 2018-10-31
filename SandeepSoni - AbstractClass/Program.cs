using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Figure
{
    protected int Dimension;

    //Constructor
    public Figure()
    {}
    public Figure(int dimension)
    {
        Dimension = dimension;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Figure
{
    public Circle()
    { }
    public Circle(int radius)
        : base(radius)
    { }

    public override double Area()
    {
        return Math.PI * Dimension * Dimension;
    }
    public override double Perimeter()
    {
        return 2 * Math.PI * Dimension;
    }
}

class Square : Figure
{
    public Square()
    { }
    public Square(int side)
        : base(side)
    { }

    public override double Area()
    {
        return Dimension * Dimension;
    }
    public override double Perimeter()
    {
        return 4 * Dimension;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure fig;

        //Polymorphism thru Classes
        if (args[0] == "C")
            fig = new Circle(11);
        else
            fig = new Square(22);
        //Comment - value for dimension is set when calling Methods
        //and Dimension in Parent Class is protected
        //fig.Dimension = 10;
        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.Perimeter());
    }
}
