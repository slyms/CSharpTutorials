using System;

//13. Data Types
public class DataTypes
{
    static void DataTypesDemo()
    {
      //Variables
        int n1, n2, m;
        n2 = 10;
        n1 = n2;
        {
            //int m = 10;
        }
        //m - local variable - available only inside it's block
        //Console.WriteLine(m);

        //Stack = Bar over Foo, Foo over DataTypesDemo
        Foo();
    }

    static void Foo()
    {
        int a, b;
        Bar();
    }

    static void Bar()
    {
        int c, d;
    }

    //14. Casting
    public static void Casting()
    {
        int n;
        byte b;
        n = 10;
        b = 10;
        n = b; //Implicit casting
        b = (byte) n; //Explicit casting

        long l = 10;
        float f = 10F;
        l = (long) f; //Explicit casting
        f = l; //Implicit casting

        //Exception: decimal requires Explicit in both directions
        decimal d = 10.01M;
        f = (float) d; //Explicit casting both directions
        d = (decimal) f; //Explicit casting both directions

        byte b1, b2, b3;
        b1 = 10;
        b2 = 15;
        //Compiler error
        //Compiler compiles Variables to ints - min. Data Type of any Expression is int
        //b3 = b1 + b2;
        b3 = (byte)(b1 + b2);

        int m;
        byte e;
        m = 256;

        //Unchecked - overwrite Compiler Type safe Arithmetic overflow Exception setting
        unchecked
        {
            e = (byte)m;
        }
        //Result: 0 - m = 256, Compiler takes only 8 last digits for byte casting
        Console.WriteLine("e = (byte)m: " + e);

        //Char
        int p;
        char c = 'A';
        n = c; //Implicit casting
        Console.WriteLine("n (number representation): " + n);
        //c = n; //Invalid
        c = (char)n; //Explicit
        Console.WriteLine("c (character representation): " + c);

        //Bool - no casting available
        bool bo = true;
        //bo = n;
        //n = bo;
        //bo = (bool)n;
        //n = (int)bo;
    }
}