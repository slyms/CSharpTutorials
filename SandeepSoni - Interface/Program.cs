using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IFigure
{
    //Dimension - change from Field to Property
    int Dimension
    {get;set;}
    double Area();
    double Perimeter();
}

//Cirecle Implements IFigure - thus implements Dimension, Area & Perimeter
class Circle : IFigure 
{
    public Circle()
    { }
    //base deleted - it is for Parent Class, not Interface
    public Circle(int radius)
    {
        _Radius = radius;
    }

    //Dimension - implementation
    private int _Radius;
    public int Dimension
    {
        get
        {
            return _Radius;
        }
        set
        {
            _Radius = value;
        }
    }
    //override deleted - override is for Parent Class, not Interface
    public double Area()
    {
        return Math.PI * Dimension * Dimension;
    }
    public double Perimeter()
    {
        return 2 * Math.PI * Dimension;
    }
}

class Square : IFigure
{
    public Square()
    { }

    //_Side replaced with Dimension - _Side is not needed
    public Square(int side)
    {
        Dimension = side;
    }

    //_Side is not needed
    //private int _Side;

    //Dimension - used as Property; will automatically take care of implementation thru some Property
    public int Dimension
    //Short version if no validation is needed
    { get; set; }

    //Explicit implementation of Interface Member
    //Omit public -> write explicitly IFigure.Area()
    double IFigure.Area()
    {
        return Dimension * Dimension;
    }
    //Public implementation of Interface Member
    public double Perimeter()
    {
        return 4 * Dimension;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Variable of type Interface can reffer to an Object of a Class which implements that Interface: Circle & Square
        IFigure fig;

        //Polymorphism thru Classes
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide either C or S as command line argument");
            return;
        }
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
