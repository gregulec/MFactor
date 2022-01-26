using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            ManufacturerPizza manufacturer = new ManufacturerPizza();
            Pizza[] tab = new Pizza[3];

            tab[0] = manufacturer.producePizza("Margherita");
            Console.WriteLine("--------------------------------------------------------------");
            tab[1] = manufacturer.producePizza("Capricciosa");
            Console.WriteLine("--------------------------------------------------------------");
            tab[2] = manufacturer.producePizza("Pepperoni");
            Console.ReadLine();
        }
    }
}
