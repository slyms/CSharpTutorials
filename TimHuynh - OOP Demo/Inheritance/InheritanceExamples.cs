using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimHuynh___OOP_Demo
{
    #region sealed class

    //A sealed Class cannot be inherited by other Classes. Can be used to express the end of inheritance line
    public sealed class SealedClass { }

    //The line below generated compile error: 'DerivedClass' cannot derive from sealed type 'SealedClass'
    //public class DerivedClass : SealedClass { }

    #endregion

    #region sealed method

    public class FirstlevelClass
    {
        public virtual void Test() { }
    }

    public class ClassWithSealedMethod : FirstlevelClass
    {
        public sealed override void Test() { }
    }

    //The Method() declaration line generates compile error: 'DerivedClassWithSealedMethod.Test()': cannot override
    //inherited member 'ClassWithSealedMethod.Test() because it is sealed
    //public class DerivedClassWithSealedMethod : ClassWithSealedMethod
    //{
    //    public override void Test() { }
    //}

    #endregion

    #region multiple inheritance

    public class A { }

    public class B : A { }

    //Generates compile error: Class 'C' cannot have multiple base classes 'A' and 'B'
    //public class C : A , B { }

    //Okay because 'C' inherits from 'B', and in turn, 'B' also inherits from 'A'
    public class C : B { }

    #endregion
}
