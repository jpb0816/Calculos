using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos1
{
    public class Datos
    {
        public void Obtenerdatos()
        {
            Operaciones op = new Operaciones();
            Console.WriteLine("Ingrese numero 1:");
            double num1 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
