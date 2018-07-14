using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public bool IsOlderThanOrEqualTo18()
        {
            //Simpler: return Age >= 18;
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintAsteriskEqualToAge()
        {
            for (int i = 0; i < Age; i++)
            {
                Console.Write("*");
            }
        }

        public int CalculateDogAge()
        {
            int dogAge = 0;
            dogAge = Age * 7;
            return dogAge;
        }

        public void MethodA()
        {
            MethodB();
        }

        public void MethodB()
        {
            MethodC();
        }

        public void MethodC()
        {
        }
    }
}
