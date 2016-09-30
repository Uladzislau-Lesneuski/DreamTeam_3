using System;
using System.Collections.Generic;
using System.IO;
using EquationSolving;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_3part
{
    public class Logger
    {
        DateTime time = DateTime.Now;

        //логирование успешно решенного уравнения
        public void WriteEquantionToLog(Equation equ, List<double> roots)
        { 
            FileStream file = new FileStream( "D:/logFile.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            if (equ.EquationType == 1)
            {
                writer.Write(time.ToString() + " Linear equation, root: " + "{0:F2}", roots[0] + "\n");
            } else
            {
                writer.Write(time.ToString() + " Quadratic equation, roots: " + "{0:F2}", roots[0] + " " + "{0:F2}", roots[1] + "\n");
            }
            writer.Close();
        }

        //логирование некорректных коэффициентов(2)
        public void WriteCoefficientsToLog(float a, float b)
        {
            FileStream file = new FileStream("D:/logFile.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(time.ToString() + " Equation solving is failed, coeffs: " + a + " , " + b + "\n");
            writer.Close();
        }

        // перегрузка логирования некорректных коэффициентов(3)
        public void WriteCoefficientsToLog(float a, float b, float c)
        {
            FileStream file = new FileStream("D:/logFile.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(time.ToString() + " Equation solving is failed, coeffs: " + a + " , " + b + " , " + c + "\n");
            writer.Close();
        }
    }
}
