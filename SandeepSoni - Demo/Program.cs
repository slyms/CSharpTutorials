using SandeepSoni___Demo;
using System;
using System.Speech.Synthesis;
using System.Threading.Tasks;

//Program1 - set as Startup Object for Project
class Program1
{
    //Main - Entry Point & Exit Point of App
    static int Main(string[] args)
    {
        Console.WriteLine("Hello World 1" + args[0]);
        //Console.ReadLine();

        DataTypes.Casting();

        return 0;
    }

    //Main - but parameter not particular for Entry Point
    static int Main(string s)
    {
        return 0;
    }
}

class Program2
{
    //Main - but Program1 set as Startup Object for Project
    static int Main(string[] args)
    {
        Console.WriteLine("Hello World 2" + args[0]);
        Console.ReadLine();

        return 0;
    }
}

public class ProgramMain
{
    public static void Main(string[] args)
    {
        /*
        string s;
        s = "Micro";
        s = s + "soft";
        Console.WriteLine("s: " + s);

        //String - value is not changed
        s.Replace("c", "K");
        Console.WriteLine("s.Replace: " + s);

        //Creating new string - changed is made
        s = s.Replace("c", "K");
        Console.WriteLine("s.Replace: " + s);

        s = "";
        for (int i = 0; i < 100; i++)
        {
            s += "A";
        }
        Console.WriteLine("for loop: " + s);

        //String Builder
        s = "";
        System.Text.StringBuilder sb = new System.Text.StringBuilder(s);
        for (int i = 0; i < 100; i++)
        {
            sb.Append("A");
            Console.WriteLine(sb.Length + " " + sb.Capacity);
        }
        s = sb.ToString();
        Console.WriteLine("String Builder: " + s);

        //String - convertion to other Data Types
        //Casting - not allowed
        //s = (string) n;
        int n = 10;
        s = n + "";
        s = n.ToString();
        Console.WriteLine("n.ToString(): " + n);
        byte b = 100;
        s = b.ToString();
        Console.WriteLine("b.ToString(): " + s);
        bool bln = true;
        s = bln.ToString();
        Console.WriteLine("bln.ToString(): " + s);

        //Parsing
        s = "100";
        n = int.Parse(s);
        Console.WriteLine("n: " + s);

        s = "true";
        bool bo = bool.Parse(s);
        Console.WriteLine("bo: " + s);

        s = "10.01";
        double d = double.Parse(s);
        Console.WriteLine("d: " + s);

        //Char & String - different Data Types
        s = "A";
        //char c = s;
        char c = char.Parse(s);
        Console.WriteLine("c: " + s);

        //Char "A" assiged to int = 65
        //String "A" assigned to int = Exception
        s = "A";
        //n = int.Parse();
        Console.WriteLine(n);

        //Parse - check
        s = "100a";
        bool success;
        success = int.TryParse(s, out n);
        Console.WriteLine("TryParse: " + n + " " + success);

        s = "truee";
        bool bol;
        success = bool.TryParse(s, out bol);
        Console.WriteLine("TryParse: " + bol + " " + success);

        //Sum of two numbers
        int n1, n2;
        n1 = int.Parse(args[0]);
        n2 = int.Parse(args[1]);
        Console.WriteLine("n1 + n2: " + (n1 + n2));

        NumberInput();

        //Object type - allows any Data Type
        ObjectMethod(10);
        ObjectMethod(true);
        ObjectMethod("Demo");
        ObjectMethod(10.01);

        ObjectBoxing();

        VarTypeInference();

        var vtir = VarTypeInferenceReturn();
        Console.WriteLine("vtir: " + vtir);
        //Data Type fo Var cannot be changed after infering in declaration
        //vtir = "true";

        DynamicType();

        Constant();

        Enum();

        OperatorsArithmetic();

        OperatorsLogic();

        OperatorsTernary();

        OperatorsIncrement();

        OperatorBitwise();

        ControlStatementsIfElse();

        Console.WriteLine("Input for ControlStatementsEvenOdd(argsEvenOdd): ");

        string[] argsEvenOdd = new string[] { Console.ReadLine() };
        ControlStatementsEvenOdd(argsEvenOdd);

        ControlSwitch();

        ControlWhile();

        ControlFor();

        ControlForEach();

        Exercise();
       
        ImperialMarch();

        ArrayDemo.ArrayMethod();

        ArrayDemo.ArrayMethodMax();

        ArrayDemo.ArrayMethodMulti();
        */
        MethodsDemo.SayHello("Sylwester");
        MethodsDemo.SayHello("Annie");

        MethodsDemo.Adding();

    }

    //Convert numeric input to character
    static void NumberInput()
    {
        string str;
        Console.WriteLine("Input a number: ");
        str = Console.ReadLine();
        int n = 100;
        if (int.TryParse(str, out n))
            Console.WriteLine("n: " + n + "(char)n: " + ((char)n));
        else
            Console.WriteLine("Invalid number");

    }

    //Object Type
    static void ObjectMethod(object n)
    {
        Console.WriteLine(n);
    }

    //Object Boxing & Unboxing
    static void ObjectBoxing()
    {
        int n = 10;
        object ob;
        ob = n; //Boxing - Value Type to Reference Type (Object)
                //Math operations not allowed on Object Type
                //ob = ob + 1;

        //InvalidCastException
        int m;
        ob = "ABC";
        //Exception <- string casted to int
        //m = (int)ob; //Unboxing - Reference Type Object -> Value Type
    }

    //Var - Type Inference
    static void VarTypeInference()
    {
        var m = 99;
        Console.WriteLine("var m: " + m);

        var s = "String";
        Console.WriteLine("var s: " + s);
    }

    static double VarTypeInferenceReturn()
    {
        return 0;
    }

    //Dynamic Type
    static void DynamicType()
    {
        int n1 = 10;
        var n2 = 10;
        object o1, o2;
        o1 = 1;
        o2 = "String";
        //Opertaion not allowed
        //Console.WriteLine(o1 + o2);

        dynamic d1, d2, d3, d4;
        d1 = "Ver ";
        d2 = 1;
        d3 = 2.2;
        d4 = d1 + (d2 + d3);
        Console.WriteLine("Dynamic Data Type: " + d4 + "\r\n" + "Ver Length: " + d4.Length);
    }

    //Constant
    static void Constant()
    {
        const double PI = 3.14;

        double area = PI * 10 * 10;

        Console.WriteLine("area: " + area);
    }

    //Enum
    static void Enum()
    {
        string wd = "Monday";
        wd = "Holiday";

        Weekday firstday;
        firstday = Weekday.Sun;

        int n = 10;
        n = 1;
        firstday = (Weekday)n;
        //Enum can be converted to String
        Console.WriteLine("Enum:" + firstday.ToString() + " " + firstday + " " + (int)firstday);

        n = 8;
        firstday = (Weekday)n;
        Console.WriteLine("Enum:" + firstday.ToString() + " " + firstday + " " + (int)firstday);

        Status status;
        status = Status.Active;
    }
    enum Weekday
    {
        Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat
    }

    enum Status
    {
        Active, Inactive, Unknown
    }

    static void OperatorsArithmetic()
    {
        float n1, n2;
        n1 = -31;
        n2 = 5;
        float res = n1 % n2;

        if (float.IsInfinity(res))
            Console.WriteLine("res Infinity");
        else if (float.IsNaN(res))
            Console.WriteLine("res NAN");
        else
            Console.WriteLine("res: " + res);
    }

    static void OperatorsLogic()
    {
        bool n1, n2, n3;
        n1 = false;
        n2 = true;
        n1 = n1 && n2; //AND
        n1 = n1 || n2; //OR
        n2 = n1 ^ n2;  //XOR
        n3 = !n1;      //NOT
        Console.WriteLine("n1 && n2: " + n1);
        Console.WriteLine("n1 ^ n2: " + n2);
        Console.WriteLine("n3: " + n3);
    }

    static void OperatorsTernary()
    {
        int n1, n2, max;
        n1 = 10;
        n2 = 50;
        max = (n1 > n2) ? n1 : n2;
        Console.WriteLine("max: " + max);
    }

    static void OperatorsIncrement()
    {
        int n1, n2, n3, n4;
        n1 = 10;
        n2 = n1++;
        n3 = n2;
        n4 = ++n1;
        Console.WriteLine(
            "n1: 10" + "\r\n" +
            "n2 = n1++ : " + n2 + "\r\n" +
            "n3 = n2 : " + n3 + "\r\n" +
            "n4 = ++n1 : " + n4
            );
    }

    static void OperatorBitwise()
    {
        int n1, n2, n3, n4;
        n1 = 11; //bit: 0000 1011
        n2 = n1 << 1; //bit: 0001 0110
        n3 = n1 & 10; // 1011 && 1000 = 1000
        n4 = n1 | 10; // 1011 || 1000 = 1011
        Console.WriteLine("n2 = n1 << 1: " + n2);
        Console.WriteLine("n3 = n1 & 10: " + n3);
        Console.WriteLine("n4 = n1 | 10: " + n4);
    }

    static void ControlStatementsIfElse()
    {
        //IF ELSE
        int n1, n2;
        n1 = n2 = 10;
        if (n1 > n2)
            Console.WriteLine("n1 is greater");
        else if (n2 > n1)
            Console.WriteLine("n2 is greater");
        else
            Console.WriteLine("n1 and n2 are equal");
    }

    static void ControlStatementsEvenOdd(string[] argsEvenOdd)
    {
        int n1;
        //Check if argsEvenOdd is provided
        if (argsEvenOdd.Length == 0)
            Console.WriteLine("argsEvenOdd is not provided in input");
        //argsEvenOdd is string[]
        //Try to parse argsEvenOdd to int, if succeded, put result in n1
        else if (int.TryParse(argsEvenOdd[0], out n1))
        {
            //Check if n1 is odd or not
            if (n1 % 2 == 0)
                Console.WriteLine("n1 is even");
            else
                Console.WriteLine("n1 is odd");
        }
        else
            Console.WriteLine("Only number is allowed");
    }

    public static void ControlSwitch()
    //Print person's grades
    {
        int n;
        Console.WriteLine("Enter Rating (1-10): ");
        int.TryParse(Console.ReadLine(), out n);

        switch (n)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Poor");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Average");
                break;
            case 7:
            case 8:
                Console.WriteLine("Good");
                break;
            case 9:
            case 10:
                Console.WriteLine("Excellent");
                break;
            default:
                Console.WriteLine("Invalid Grade");
                break;
        }
    }

    public static void ControlWhile()
    {
        int n = 0;
        while (n < 10)
        {
            n++;
            Console.WriteLine("Hello n" + n);
        }

        int m = 0;
        while (true)
        {
            m++;
            if (m == 5)
                continue; //continue - stop executing rest of loop & continue with next iteration
            if (m == 7)
                break;   //break - come out of loop
            Console.WriteLine("Hello m" + m);
        }
    }

    public static void ControlFor()
    {
        int n;
        Console.WriteLine("Table of: ");
        int.TryParse(Console.ReadLine(), out n);
        string s = "";
        for (int i = 1; i <= 10; i++)
            s += n + "*" + i + "=" + n * i + "\n";//s = 2 * 1 = 2
        Console.WriteLine(s);
    }

    public static void ControlForEach()
    {
        Console.WriteLine("ControlForEach() Input: ");
        string[] argsForEach = new string[] { Console.ReadLine() };

        for (int i = 0; i < argsForEach.Length; i++)
        {
            Console.WriteLine("For: " + argsForEach[i]);
        }

        foreach (string s in argsForEach)
        {
            Console.WriteLine("ForEach: " + s);
        }
    }

    public static void Exercise()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                    break; //CHANGE TO CONTINUE
                Console.WriteLine("i + j: " + i + " " + j);
            }
        }
    }

    public static void ImperialMarch()
    {
        SpeechSynthesizer synthIM = new SpeechSynthesizer();
        synthIM.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
        synthIM.SpeakAsync("Greetings weaklings! Start Imperial March! Start SharePoint Team Automatic Test oh yeeeeaaah! Vafankulo!");

        for (int i = 0; i < 1; i++)
        {
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);

            /*
            Task.Run(() =>
            {
                Console.Beep(520, 215);
                Console.Beep(520, 265);
                Console.Beep(520, 265);
                Console.Beep(520, 215);
                Console.Beep(560, 215);
                Console.Beep(520, 215);
            }
            );
            Task.Run(() =>
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                synth.SpeakAsync("Every night in my dreams");
            }
            );


            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(300, 300);
            Console.Beep(250, 300);
            Console.Beep(200, 300);

            Console.Beep(300, 200);
            Console.Beep(300, 500);
            Console.Beep(300, 200);
            Console.Beep(150, 200);
            Console.Beep(150, 500);

            Console.Beep(300, 200);
            Console.Beep(300, 200);
            Console.Beep(350, 200);
            Console.Beep(350, 200);

            Console.Beep(500, 200);
            Console.Beep(400, 200);
            Console.Beep(300, 500);
            Console.Beep(400, 250);
            Console.Beep(300, 250);

            Console.Beep(200, 200);
            Console.Beep(450, 200);
            Console.Beep(350, 500);

            */
        }
    }
}


