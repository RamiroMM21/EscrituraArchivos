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
        public class Carro
        {
            public string NombreCarro, Marca;
            public int Año;


            public Carro(string NombreCarro, int Año, string Marca)
            {
                this.NombreCarro = NombreCarro;
                this.Año = Año;
                this.Marca = Marca;
            }
            

            static void Main(string[] args)
            {
                StreamWriter sw = new StreamWriter("ejemplo.txt", true);

                string NombreCarro, Marca;
                int Año;

                Console.Write("Escriba el nombre del carro: ");
                NombreCarro = Console.ReadLine();

                Console.Write("\nEscriba el año del carro: ");
                Año = int.Parse(Console.ReadLine());

                Console.Write("\nEscriba la marca del carro: ");
                Marca = Console.ReadLine();

                Carro car = new Carro(NombreCarro, Año, Marca);

                sw.WriteLine(car.NombreCarro + "  " + car.Año + "  " + car.Marca);
                
                sw.Close(); 

                Console.WriteLine("Escribiendo en el archivo.........");
                Console.ReadLine();
            }
        }
    }
}
