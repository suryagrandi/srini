using System;

namespace ConsoleApp1
{
    class Class4
    {
        void display()
        {
            // calling fuction show() 
            this.show();

            Console.WriteLine("Inside display function");
        }

        void show()
        {
            Console.WriteLine("Inside show funcion");
        }

        // Main Method 
        public static void Main(String[] args)
        {
            Class4 t1 = new Class4();
            t1.display();
            Console.ReadLine();
        }
    }
}
