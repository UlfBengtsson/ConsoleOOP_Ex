using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOOP_Ex
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegPlate { get; set; }
        Person driver;
        public Person Driver
        {
            get { return driver; }
            set
            {
                if (value.Licenses.Contains("B"))
                {
                    driver = value;
                }
                else
                {
                    Console.WriteLine("Pleace select another driver with B license.");
                }
            }
        }

        public Car(string brand, string model, string regPlate)
        {
            Brand = brand;
            Model = model;
            RegPlate = regPlate;
        }
        public Car(string brand, string model, string regPlate, Person driver) : this(brand, model, regPlate)
        {
            Driver = driver;
        }

        public void Info()
        {
            Console.WriteLine(
                "--- Car ---\n" +
                $"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Registration Plate: {RegPlate}\n" +
                "Driver: " + ( driver != null ? driver.Name : "No driver" ) + "\n" 
                );
        }
    }
}
