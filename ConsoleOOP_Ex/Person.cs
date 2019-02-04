using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOOP_Ex
{
    class Person
    {
        public string Name { get; set; }
        public List<string> Licenses { get; set; }

        public Person(string name)
        {
            this.Name = name;
            Licenses = new List<string>();
        }
    }
}
