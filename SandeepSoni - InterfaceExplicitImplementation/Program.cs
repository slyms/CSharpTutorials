using System;

//Method implemented publicly can be access using:
//1.Variable of type Interface
//2.Variable of Class which implements Interface

class Program
{
    static void Main(string[] args)
    {
        IA1 a1; IA2 a2; CA a;
        a1 = new CA();
        a2 = new CA();
        a = new CA();

        //In all cases Foo2 in CA is called, cause there is only 1 implementation
        //Methods from Interfaces cannot be called
        a1.Foo2();
        a2.Foo2();
        a.Foo2();

        a1.Foo3();
        a2.Foo3();
        //Explicit Interface implementation cannot be reached directly thru Class Variable
        //-> Casting
        ((IA1)a).Foo3(); //Calling IA1.Foo3() of Object referrenced by "a"
        a.Foo3();

        //Implicit casting
        //Interface Variable = Class Variable
        a1 = a;

        //a = a1;//Not valid <- there is at least 1 value valid for a1 but not valid for 1
        //-> Explicit casting <- same Interface can be implemented by other Classes
        //Class Variable = (casting operator)Interface
        a = (CA)a1; //"a" is reffering to Object of Class CA, it's valid and that reference will be assigned to "a". But if "a1" reffers to Object of CA1 it's invalid cast exception

        //Explicit casting needed <- two unrelated Interface Variables
        a1 = new CA();
        a2 = new CA();
        a1 = (IA1) a2;//<- a2 = a1;
        a2 = (IA2) a1;//<- a1 = a2; "a1" must refer to Object of Class which has also implemented IA2 - else: InvalidCastException
    }
}

interface IA1
{
    void Foo1();
    void Foo2(); //Same Method in both Interfaces
    void Foo3();
}

interface IA2
{
    void Foo2();
    void Foo3();
}

//CA implements 2 Interfaces
//-> CA has to provide functionality for 3 Methods
class CA : IA1, IA2
{
    public void Foo1()
    { }
    public void Foo2()
    {
        Console.WriteLine("Foo2 - CA");
    }

    //Explicit Implementation
    //<- different implementation for Foo3 according to each Interface
    //Methods are reached only thru Interface Variable - it cannot be access thru Class Variable
    void IA1.Foo3()
    {
        Console.WriteLine("Foo3 - CA/IA1");
    }
    //It's possible to have Excplicit implementation & simple public implicit implementation
    public void Foo3()
    {
        Console.WriteLine("Foo3 - CA");
    }
}