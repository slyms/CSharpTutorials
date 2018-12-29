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

    //Constructor Parameterized
    public Parent(int pubA, int priA, int proA)
    {
        PubA = pubA;
        PriA = priA;
        ProA = proA;
    }

    public void ParentReturn()
    {
    }
}

class Child : Parent
{
    public int PubB;
    public void Foo()
    {
        this.PubA = 1;
        //PriA = 1; //private = No access outside Parent Class
        this.ProA = 1;

        Child c = new Child();
        c.PubA = 1;
        c.ProA = 1;

        Parent p = new Parent();
        p.PubA = 1;
        //p.ProA = 1;//No access thru Reference of type Parent - special case

        //What does this mean?
        Parent cp = new Child();
    }

    //Constructor Parameterless
    public Child()
        : base(0, 0, 0) //Link to specific Parent Class Constructor - Child Class Constructor can call any Parent Constructor
    {
        PubA = 22;
    }

    //Passing data from Child Class to Parent
    //Constructor Parameterized
    public Child(int pubA, int priA, int proA, int pubB) //All data we want
        : base(pubA, priA, proA) //Pass data to Parent Class Constructor
    {
        //PriA = priA; //Protected Variable from Parent Class - all Parent&Child Class Members are allocated memory as one unit, so all Members must be provided with a Constructor
        //ProA = proA; //Comment <- initialized in Parent Class Constructor
        //PubA = pubA; //Comment <- initialized in Parent Class Constructor
        PubB = pubB; //Thus only Child Member can be initialized in Child Constructor
    }

    public void ChildReturn()
    {
    }
}

class Program
{
    static void Main()
    {
        Child c, cc;
        Parent p, pp;

        c = new Child();
        p = new Child();

        //cc = new Parent(); - Cannot implicilty convert type Parent to Child
        cc = new Child();
        pp = new Parent();

        c.ChildReturn();
        cc.ChildReturn();
        //p.ChildReturn(); - Parent does not contain a definition for ChildReturn()
        //pp.ChildReturn(); - Parent does not contain a definition for ChildReturn()

        c.ParentReturn();
        cc.ParentReturn();
        p.ParentReturn();
        pp.ParentReturn();

        c = (Child) p;
        //c = (Child) pp; //Invalid casting Exception - pp is referrencing to Object of Class Parent
        p = c;
        pp = c;

        c = new Child();

        p = c;
        p = new Child();
        //Casting
        c = (Child)p;

        p = new Parent();
        //c = (Child)p; //Invalid casting Exception - p is referrencing to Object of Class Parent

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
        cAs = pAs as Child; //<=> c = p as Child;

        Console.WriteLine("cAs == null: " + (cAs == null));

        //Is operator
        p = new Child();
        if (p is Child) //If p is referencing to Object of Child or GrandChild (SubClass)
        {
            c = (Child)p;
            Console.WriteLine("is operator: " + c);
        }
        else
        {
            c = null;
            Console.WriteLine("is operator: " + c);
        }

        //?? operator
        object a = p ?? pAs; //a = p; unless p is null, then a = pAs
        //Equivalent of:
        if (p == null)
            a = pAs;
        else
            a = p;
    }
}
