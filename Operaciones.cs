using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos1
{
    public class Operaciones
    {
        public double Calculararea(double Ladoa)
        {
            double area = Ladoa * Ladoa;
            return area;
        }

        public double Calculararea(double ladoa,double ladob,int valor)
        {
             valor = 2;
            double area = (ladoa * ladob) / valor;
            return area;
        }

        public double Calculararea(double ladoa,double ladob)
        {
            double area = ladoa * ladob;
            return area;
        }


    }
}
