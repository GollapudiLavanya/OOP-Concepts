using System;
  
namespace Demoabstraction
{
   abstract class animal  
    {  
        public abstract void eat();  
        public void sound()  
        {  
            Console.WriteLine("dog can sound");  
        }  
    }  
    class dog : animal  
    {  
        public override void eat()  
        {  
            Console.WriteLine("dog can eat");  
        }  
    }  
 }
