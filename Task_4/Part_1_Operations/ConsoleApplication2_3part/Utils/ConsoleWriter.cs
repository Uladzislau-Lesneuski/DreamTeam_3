using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_3part.Utils
{
    class ConsoleWriter
    {
        public void WriteResultMatrix(float[,] matrix)
        {
            Console.WriteLine("Result matrix :");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0:F2} ",matrix[i,k]);
                }
                Console.WriteLine();
            }
        }
    }
}
