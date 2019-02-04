using System;

namespace ConsoleOOP_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Person uffe = new Person("Ulf Bengtsson");
            uffe.Licenses.Add("B");

            Car bmw = new Car("BMW", "525i", "SPB704", uffe);

            bmw.Info();

            Console.ReadKey();
        }
    }
}
