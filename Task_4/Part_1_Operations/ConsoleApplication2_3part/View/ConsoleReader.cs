using System;
using EquationSolving;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_3part
{
    public class ConsoleReader
    {
        private static Logger LOG = new Logger();
        public Equation Validate()
        {
            Console.WriteLine("Choose what type of operation u wanna to do:");
            Console.WriteLine("Enter '1' for LINEAR or '2' for QUADRATIC or '3' for matrix multiplying");
            Console.WriteLine("Rule for coefficients: must be numbers from -999 to 999");
          
            int EquationType = int.Parse(Console.ReadLine());


            float coefficient1 = 0;
            float coefficient2 = 0;
            float coefficient3 = 0;
            bool flag = false;

            //считывание коэффициентов для линейного ур-я
            if (EquationType == 1)
            {
                while (flag == false)
                {
                    Console.WriteLine("Enter first coefficient");
                    coefficient1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second coefficient");
                    coefficient2 = float.Parse(Console.ReadLine());
                    if (coefficient1 != 0 && coefficient1 > -1000 && coefficient1 < 1000 && coefficient2 > -1000 && coefficient2 < 1000)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Check coefficients, it must be numbers from -999 to 999; coefficient A must be not equal zero");
                        LOG.WriteCoefficientsToLog(coefficient1, coefficient2);
                    }
                }
                Equation equation = new Equation(EquationType, coefficient1, coefficient2);
                return equation;
            }

            //считывание коэффициентов для квадратного ур-я
            else if (EquationType == 2)
            {
                while (flag == false)
                {
                    Console.WriteLine("Enter first coefficient");
                    coefficient1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second coefficient");
                    coefficient2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter third coefficient");
                    coefficient3 = float.Parse(Console.ReadLine());
                    if (coefficient1 != 0 && coefficient1 > -1000 && coefficient1 < 1000 && coefficient2 > -1000 && coefficient2 < 1000
                        && coefficient3 > -1000 && coefficient3 < 1000)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Check coefficients, it must be numbers from -999 to 999; coefficient A must be not equal zero");
                        LOG.WriteCoefficientsToLog(coefficient1, coefficient2, coefficient3);
                    }
                }
                Equation equation = new Equation(EquationType, coefficient1, coefficient2, coefficient3);
                return equation;
            }

            else if (EquationType == 3)
            {
                // немного быдлокода, хоть manager и вызывается в слое view, хотелось бы знать ConsoleReader изза общения с юзером во Вью должен быть или в Утилитах?
                Console.WriteLine("Solve Matrix Multiplying");
                Console.WriteLine();
                HandleManager manager = new HandleManager();
                manager.SolveMatrix();

                //костыль, дабы не рушить логику работы программы, просто возвращаем тройку как результат выбранной операции
                Equation equation = new Equation(3);
                return equation;
            } else Console.WriteLine("Enter valid number next time :)");

            return null;
        }
    }
}
