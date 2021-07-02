using System;
using System.Collections.Generic;
using System.Text;

namespace oopsconcepts
{
    public class BClass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Learn C# Tutorial");
        }
    }
    // Derived Class
    public class DClass : BClass
    {
        public override void GetInfo()
        {
            Console.WriteLine("Welcome to oopsconcepts");
        }
    }

}

