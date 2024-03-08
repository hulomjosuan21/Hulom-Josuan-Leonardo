using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(123,23123);
            rectangle1.CalculatePerimeter();
            // Animal animal1 = new Animal();
            // animal1.Name = "Dog";
            // animal1.Traits = "Friendly";
            // animal1.Teeth = "Sharp";
            // animal1.WhoAmI();

        }
    }

    class Animal
    {
        public string? Name {get; set;}
        public string? Traits {get; set;}
        public string? Teeth {get; set;}

        public void Cry()
        {
            Console.WriteLine("Woof!");
        }

        public void WhoAmI()
        {
            if(Name != null) Console.WriteLine("I am "+Name);

            if(Traits != null) Console.WriteLine("My Traits are "+Traits);

            if(Teeth != null) Console.WriteLine("I have a "+Teeth+" teeth");
            
    
        }
    }
}