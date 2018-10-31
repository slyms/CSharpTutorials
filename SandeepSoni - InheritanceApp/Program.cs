using System;

class Parent
{
    public int PubA; //Access from outside the Class
    private int PriA; //Access from within the Class
    protected int ProA; //Access as public from Child Class - private for other

    //Constructor Parameterless
    public Parent()
    {
        PubA = 11;
    }

    //Constructor Parameterlized
    public Parent(int priA, int proA, int pubA)
    {
        PriA = priA;
        ProA = proA;
        PubA = pubA;
    }
}

class Child : Parent
{
    public int PubB;
    public void Foo()
    {
        this.PubA = 1;
        this.ProA = 1;
        //PriA = 1; //No access

        Child c = new Child();
        c.PubA = 1;
        c.ProA = 1;

        Parent p = new Parent();
        p.PubA = 1;
        //p.ProA = 1;//No access thru Reference of type Parent - special case
    }

    //Constructor Parameterless
    public Child()
        : base(0, 0, 0) //Link to specific Parent Class Constructor
    {
        PubA = 22;
    }

    //Constructor Parameterlized
    public Child(int priA, int proA, int pubA, int pubB)
        : base(priA, proA, pubA) //Pass data to Parent Class Constructor
    {
        //PriA = priA; //Protected Variable from Parent Class - all Parent&Child Class Members are allocated memory as one unit, so all Members must be provided with a Constructor
        //ProA = proA; //Comment <- initialized in Parent Class
        //PubA = pubA; //Comment <- initialized in Parent Class
        PubB = pubB; //Thus only Child Member can be initialized in Child Constructor
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child c;
        Parent p;

        c = new Child();

        p = c;
        p = new Child();
        //Casting
        c = (Child)p;

        p = new Parent();
        //c = (Child)p; //Invalid casting Exception - p is refferencing to Object of Class Parent

        Console.WriteLine(c.PubA);

        c = new Child(1, 2, 3, 4);
        Console.WriteLine(c.PubA);

        p = new Parent();

        p = new Child(); //Reference Variable of type Parent reffers to an Object of Class Child
        //c = new Parent(); //Incorrect - Reference Variable of type Child reffers to an Object of Class Parent

        //As operator
        Parent pAs;
        Child cAs;

        pAs = new Parent();
        cAs = pAs as Child;

        Console.WriteLine("cAs == null: " + (cAs == null));

        //Is operator
        if (p is Child) //If p is refferencing to Object of Child or GrandChild (SubClass)
            c = (Child)p;
        else
            c = null;

        //?? operator
        object a = p ?? pAs; //a = p, unless p is null, then a = pAs
        //Equivalent of:
        if (p == null)
            a = pAs;
        else
            a = p;
    }
}
