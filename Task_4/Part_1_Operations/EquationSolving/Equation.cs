using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationSolving
{
    public class Equation
    {
        public int EquationType { get; set; }
        public float coefficientA { get; set; }
        public float coefficientB { get; set; }
        public float coefficientC { get; set; }

        public Equation(int type, float a, float b)
        {
            EquationType = type;
            coefficientA = a;
            coefficientB = b;
        }

        public Equation(int type, float a, float b, float c)
        {
            EquationType = type;
            coefficientA = a;
            coefficientB = b;
            coefficientC = c;
        }

        //special for matrix
        public Equation(int type)
        {
            EquationType = type;
        }
    }
}
