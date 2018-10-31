using System;

class CParent
{
    public int N;
    public void Foo()
    {
        Console.WriteLine("Foo() in CParent: Shadowing Parent + Static");
    }

    //Virtual / Override / Abstract
    public virtual void Doo()
    {

    }

    public virtual void Koo()
    {
        Console.WriteLine("Koo() in CParent: Shadowing Parent + Dynamic");
    }

    public virtual void Too()
    {
        Console.WriteLine("Too() in CParent");
    }
}

class CChild : CParent
{
    //Shadowing Variable N in Parent
    public new int N;

    //Method Overload - same Method as in Parent, but different param
    public void Foo(int a)
    {
        Console.WriteLine("Foo() in CChild - Parameterless");
    }

    //Method Shadowing - same Method as in Parent, "new" in Child Class
    public new void Foo()
    {
        Console.WriteLine("Foo() in CChild");
    }

    public new void Koo()
    {
        Console.WriteLine("Koo() in CChild");
    }

    //Method Overriding - - same Method as in Parent, "override" in Child Class
    public override void Doo()
    {
        Console.WriteLine("Doo() in CChild: Override Parent + Dynamic");
    }

    public override sealed void Too()
    {
        Console.WriteLine("Too() in CChiled: Override Parent + Cannot be Overrided by CGrandChild");
    }
}

class CGrandChild : CChild
{
    public override void Doo()
    {
        Console.WriteLine("Doo() in CGrandChild: Override Parent&Child + Dynamic");
    }

    //Cannot override sealed Too() in CChild
//    public override void Too()
//    {
//        Console.WriteLine("Too() in CGranChild");
//    }
}

class BindingDemoProgram
{
    static void Main(string[] args)
    {
        CParent p = new CChild();
        p.Foo();
        p.Doo();
        p.Koo();

        //Variable is of type Parent - Reference is to Parent Class N
        //p.N = 10;
        //Variable - use Child Class thru Variable -> Casting
        ((CChild)p).N = 10;

        CParent pg = new CGrandChild();
        pg.Foo();
        pg.Doo();
        pg.Koo();
    }
}