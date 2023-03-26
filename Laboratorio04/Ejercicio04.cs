using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio04
    {
        public int[] CalcularBilletes(int cantidad, int[] billetes)
        {
            // cantidad = 689 -> cantidad es el numero de dinero a denominar 
            int[] result = new int[billetes.Length]; // billetes: se guiara por .Lenght identificará si son unidades, decenas, centenas...

             for (int i = 0; i < billetes.Length; i++)
            {
                result[i] = cantidad / billetes[i]; // denominacion primero tomará 100, luego 50, 20 y asi sucesivamente 
                // r = 680 / 100 -> 6.8 es decir 6 -> 6 billetes de 100 
                // 1 de 50, 2 de 20, 1 de 10, 9 de 1
                cantidad = cantidad % billetes[i];   
            }

            return result;


        }
    }
}
