using System;
using System.Collections.Generic;
using System.Text;

namespace oopsconcepts
{
    public class Shape
    {  
    public virtual void draw()
    {  
        Console.WriteLine("drawing...");  
    }  
    }  
public class Rectangle: Shape  
{  
    public override void draw()  
    {  
        Console.WriteLine("drawing rectangle...");  
    }  
      
}  
}

