using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsola
{
    


    

    class Program
    {
        static void Main(string[] args)
        {
            Motor m = new Motor();
            Vehiculo v = new Vehiculo();

            Console.WriteLine("Potencia");
            m.Potencia = double.Parse(Console.ReadLine());
            Console.WriteLine("Tipo");
            m.Tipo = Console.ReadLine();
            Console.WriteLine("ingresa el color");
            v.Color = Console.ReadLine();
            

            v.Motor = m;
            Console.WriteLine("Vehiculo" + v.ToString());
            Console.ReadKey();
        }
    }

}