using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    internal class Program
    {

        class rectangle
        {
            //attributes
            private int length=20;
            private int width=10;
            public void displaylength()
            {
                Console.WriteLine("length " + length);
            }
            public void displaywidth()
            {
                Console.WriteLine("width " + width);
            }

        }
        static void Main(string[] args)
        {
            rectangle rec1 = new rectangle();
            rec1.displaylength();
            rec1.displaywidth();

            Console.ReadKey();
        }

        
        
    }

 
}

