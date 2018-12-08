/*
 1. Fields
 - hold data for Object
 2. Properties
 - way to handle data of given Field
 - get data
 - set data
 3. Constructor
 - model for Object & data it should have
 4. Create Object
 - Gregory.HP = Grgegory._HP <- HP is a Property of _HP Field 
 - Gregory._Strength - omits Strength Property = omits validation: "Strength cannot be < 0"
 */

using System;
using System.Windows.Forms;

public class OOPExercise
{
    public static void Main()
    {
        //4. Create Object
        Contender Gregory;
        Gregory = new Contender("Gregory", -100, 200);

        MessageBox.Show("Gregory\nName: " + Gregory.Name + "\nHP: " + Gregory.HP + "\nStrength: " + Gregory.Strength);
        //Console.WriteLine("");
        MessageBox.Show("Gregory\nName: " + Gregory.Name + "\nHP: " + Gregory._HP + "\nStrength: " + Gregory._Strength);
    }
}

public class Contender
{
    //1. Fields
    private string _Name;
    public int _HP;
    public int _Strength;

    //2. Properties
    public string Name
    {
        get { return this._Name; }
        set { _Name = value; }
    }

    public int HP
    {
        get { return this._HP; }
        set
        {
            if(value < 0)
                MessageBox.Show("Strength cannot be < 0");
            _HP = value;
        }
    }

    public int Strength
    {
        get { return this._Strength; }
        set { _Strength = value; }
    }

    //3. Constructor
    public Contender(string name, int hp, int strength)
    {
        Name = name;
        HP = hp;
        _Strength = strength;
    }
}
