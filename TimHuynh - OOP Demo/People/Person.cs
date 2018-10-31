using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___OOP_Demo
{
    public abstract class Person
    {
        public string Name { get; set; }

        public string Skill { get; set; }

        public virtual void SetSkill()
        {
            Skill = "Running";
        }
    }
}
