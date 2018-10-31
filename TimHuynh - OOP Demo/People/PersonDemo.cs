using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//By sharing namespace with Program.cs, we don't have to include another Namespace
//in Program.cs to have access to this Class
namespace TimHuynh___OOP_Demo
{
    class PersonDemo
    {
        public static void OOPExample()
        {
            Programmer p1 = new Programmer();
            //Name property comes from Person.cs
            //Banker & Progrgammer are derived Classes - have access to it like it is their own
            p1.Name = "John";
            p1.SetSkill();
            Console.WriteLine("Name: {0}, Skill: {1}", p1.Name, p1.Skill);

            Banker p2 = new Banker();
            p2.Name = "Josh";
            p2.SetSkill();
            Console.WriteLine("Name: {0}, Skill: {1}", p2.Name, p2.Skill);

            //Instantiation of an Objeect of Person.cs = Compile error
            //== Abstract Class cannot be instantiated
            //Person p = new Person();

            //Polymorphism
            var people = new List<Person>()
            {
                new Programmer(),
                new Banker()
            };
            foreach (var p in people)
            {
                p.SetSkill();
                Console.WriteLine(p.Skill);
            }
        }
    }
}
