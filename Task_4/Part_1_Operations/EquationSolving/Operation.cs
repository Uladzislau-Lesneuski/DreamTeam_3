using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EquationSolving
{
    public class Operation
    {
        public int MatrixAStringCount { get; set; }
        public int MatrixAColumnCount { get; set; }
        public int MatrixBStringCount { get; set; }
        public int MatrixBColumnCount { get; set; }

        public float SolveLinearEquation(float coefficientA, float coefficientB)
        {
            float radical = (float)-coefficientB / coefficientA;
            return radical;
        }

        public List<double> SolveQuadraticEquation(float coefficientA, float coefficientB, float coefficientC)
        {
            List<double> roots = new List<double>(); 
            float D = ((coefficientB * coefficientB) - (4 * coefficientA * coefficientC));
            if (D == 0)
            {
                double x1 = (-coefficientB + Math.Sqrt(D)) / (2 * coefficientA);
                roots.Add(x1);
                
            } else if (D < 0)
            {
                
            } else if (D > 0)
            {
                double x1 = (-coefficientB + Math.Sqrt(D)) / (2 * coefficientA);
                double x2 = (-coefficientB - Math.Sqrt(D)) / (2 * coefficientA);
                roots.Add(x1);
                roots.Add(x2);
                
            }
            return roots;
        }
        
        public float[,] MatrixMultiplication(List<float[,]> matrixxx)
        {

            if (MatrixAColumnCount != MatrixBStringCount)
            {
                Console.WriteLine("Multiplication is impossible. Invalid sizes: " , 
                    "columns count of first matrix not equal string count of second matrix");
                return null;
            }
            else
            {
                float[,] resultMatrix = new float[MatrixAStringCount, MatrixBColumnCount];
                for (int i = 0; i < MatrixAStringCount; i++)
                {
                    for (int j = 0; j < MatrixBColumnCount; j++)
                    {
                        for (int k = 0; k < MatrixBStringCount; k++)
                        {
                            resultMatrix[i, j] += matrixxx[0][i, k] * matrixxx[1][k, j];
                        }
                    }
                }
                return resultMatrix;
            }
        }

        public List<float[,]> ParseMatrix(List<string> source)
        {
            const string DIGITS = @"\d";
            Regex regex = new Regex(DIGITS);
            List<float[,]> digitMatrix = new List<float[,]>();

            for (int i = 0; i < 2; i++)
            {
                var stringArray = source[i].Split(';');
                int stringCount = stringArray.Length;
                var elemArray = stringArray[0].Split(',');
                int columnCount = elemArray.Length;
                elemArray = null;
                int iterator = 0;

                if (i == 0)
                {
                    MatrixAColumnCount = columnCount;
                    MatrixAStringCount = stringCount;
                }
                if (i == 1)
                {
                    MatrixBColumnCount = columnCount;
                    MatrixBStringCount = stringCount;
                }

                float[,] matrix = new float[stringCount, columnCount];

                foreach (var str in stringArray)
                {
                    elemArray = str.Split(',');
                    for (int k = 0; k < elemArray.Length; k++)
                    {
                        string element = (regex.Match(elemArray[k])).ToString();

                        float.TryParse(element, out matrix[iterator, k]);
                        //Console.WriteLine(matrix[iterator, k]);
                    }
                    iterator++;
                }
                digitMatrix.Add(matrix);      
            }
            return digitMatrix;
        }

    }
}
