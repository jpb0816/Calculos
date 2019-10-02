using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            int opc = 0;
            Console.WriteLine("Ingrese la opcion que desea calcular:");
            Console.WriteLine("\n1.Cuadrado");
            Console.WriteLine("\n2.Triangulo");
            Console.WriteLine("\n3.Rectangulo");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                
                case 1:
                    Console.WriteLine("Ingrese numero 1:");
                    double num1 = Convert.ToInt32(Console.ReadLine());


                    double areac = op.Calculararea(num1);
                    Console.WriteLine("El area es: "+areac);
                    break;

                case 2:
                    int valor = 2;
                    Console.WriteLine("Ingrese numero 1:");
                    double triangulo1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese numero 2:");
                    double triangulo2 = Convert.ToInt32(Console.ReadLine());
                    double areat = op.Calculararea(triangulo1,triangulo2,valor);

                    Console.WriteLine("El area es: "+areat);
                    break;

                case 3:
                    Console.WriteLine("Ingrese numero 1:");
                    double rec1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese numero 2:");
                    double rec2 = Convert.ToInt32(Console.ReadLine());

                    double arear = op.Calculararea(rec1,rec2);
                    Console.WriteLine("El area es: "+arear );
                    break;
            }

            Console.ReadKey();
        }
    }
}
