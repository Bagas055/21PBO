using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        string nama;
        string password;

        Program(string name, string pasword)
        {
            nama = name;
            password = pasword;
        }

        static void Main(string[] args)
        {
            Program program1 = new Program("Bagas", "akubagas");

            Console.WriteLine("Nama : " + program1.nama);
            Console.WriteLine("Password : " + program1.password);
            Console.ReadLine();
        }
        ~Program()
        {
            Console.WriteLine("Destructor was called");
        }

    }
}
