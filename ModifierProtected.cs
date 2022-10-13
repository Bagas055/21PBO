using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifierProtected
{
    class Person
    {
        protected string name = "Bagas";
    }

    // derived class
    class Program : Person
    {
        static void Main(string[] args)
        {

            // creating object of derived class
            Program program = new Program();

            // accessing name field and printing it
            Console.WriteLine("Name: " + program.name);
            Console.ReadLine();
        }
    }
}
