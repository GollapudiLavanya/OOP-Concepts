using System;

namespace oopsconcepts
{

    class program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Display("Latha", 20);
            Console.WriteLine();
            User u = new User();

            // set accessor will invoke
            u.Name = "Abhigna";
            // set accessor will invoke
            u.Location = "Banglore";
            // get accessor will invoke
            Console.WriteLine("Name: " + u.Name);
            // get accessor will invoke
            Console.WriteLine("Location: " + u.Location);
            Console.ReadLine();

           dog mydog = new dog();  
           animal thePet = mydog;  
           thePet.eat();  
           mydog.sound();

            Calculate c = new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);
            Console.ReadLine();

             Shape s;  
             s = new Shape();  
             s.draw();  
             s = new Rectangle();  
             s.draw();  
             s = new Circle();  
             s.draw(); 

        }

    }
}
