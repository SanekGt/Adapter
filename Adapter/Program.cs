using System;

namespace Adapter
{

    // Mainapp test application 

    class MainApp
    {
        static void Main()
        {
            // Create adapter and place a request 
            Target target = new Adapter();
            target.Request();

            // Wait for user 
            Console.Read();
        }
    }

    // "Target" 

    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    // "Adapter" 

    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work 
            // and then call SpecificRequest 
            adaptee.SpecificRequest();
            adaptee.SpecificRequest2();
        }
    }

    // "Adaptee" - адаптируемый класс

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }

        public void SpecificRequest2()
        {
            Console.WriteLine("Called SpecificRequest2()");
        }
    }
}

