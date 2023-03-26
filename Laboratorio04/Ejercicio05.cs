using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio05
    {
        public int[] CalcularBilletes(int cantidad, int[,] billetes)
        {
            int[] resultado = new int[billetes.GetLength(0)];

            for (int i = 0; i < resultado.Length; i++)
            {
                int denominacion = billetes[i, 0];
                int limite = billetes[i, 1]; 

                int posiblesBilletes = cantidad / denominacion; //enteros

                if (limite < 0 || posiblesBilletes <= limite) //Si el limite de denominaciones es 0 o menos o ingual a cero no hay limite para esta denominacion
                {
                    resultado[i] = posiblesBilletes;

                }
                else
                {
                    resultado[i] = limite;

                }
                cantidad = cantidad - (resultado[i] * denominacion);

            }
            return resultado;
        }
    }
}
