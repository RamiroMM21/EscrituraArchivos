using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejemplo_stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            StreamWriter sw = new StreamWriter("Ejemplo.txt", true);
            //si el archivo no existe lo creara
            //si ya existe, escribira en el

            Console.Write("Escriba un nombre con apellidos: ");
            Nombre = Convert.ToString(Console.ReadLine());

            string[] Lines = {Nombre};

            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }
            sw.Close();//se debe cerrare el archivo

            Console.WriteLine("Escrbiendo en el archivo.....");
            Console.ReadLine();
        }
    }
}
