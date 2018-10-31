using System;

class Point : Object
{
    public int X, Y;

    //ToString() is a virtual Method -> it can be overriden in Child Class
    public override string ToString()
    {
        return X + " " + Y;
    }

    //Equals - override to compare data
    public override bool Equals(object obj)
    {
        //Casting <- obj (Parent Class Member) cannot access Child Class
        Point p = (Point)obj;

        //Value of current point == value of param
        //True <- same data
        return (this.X == p.X) && (this.Y == p.Y);
    }

    //Rule: override GetHashCode <- if Equals is overriden
    public override int GetHashCode()
    {
        int hashX = X.GetHashCode();
        int hashY = Y.GetHashCode();

        //Some algorithm to return hash
        int hash = 10;
        hash = (hash * 7) + hashX;
        hash = (hash * 7) + hashY;

        return hash;
        //return base.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Constructor Default + Object initializers
        Point pt1 = new Point() { X = 10, Y = 20 };
        Console.WriteLine(pt1);
        Console.WriteLine(pt1.ToString());

        Point pt2 = new Point() { X = 10, Y = 20 };
        //False <- data is same, but Objects are different
        Console.WriteLine(pt1 == pt2);

        //Equals - compares References, not data 
        Console.WriteLine(pt1.Equals(pt2));

        //If Equals = true, GetHashCode should return: true
        Console.WriteLine(pt1.GetHashCode() + " " + pt2.GetHashCode());

        Type tp1 = pt1.GetType();
        Type tp2 = pt2.GetType();
        Console.WriteLine(tp1 == tp2);

        Object ob = new Object();
        Console.WriteLine("ob: " + ob);
    }
}

