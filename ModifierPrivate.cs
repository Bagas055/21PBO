﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifierPrivate
{
    class Person
    {
        private string name = "Bagas";
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.name);
        }
    }
}
