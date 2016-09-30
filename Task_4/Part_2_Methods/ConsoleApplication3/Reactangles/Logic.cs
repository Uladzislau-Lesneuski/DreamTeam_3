using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Reactangles
{
    public class Logic
    {
        public int HowMany(Rectangle rect1, Rectangle rect2)
        {
            int howMany = (int)(rect1.Square / rect2.Square);
            return howMany;
        }
        public void DoTask()
        {
            Rectangle rect1 = new Rectangle(4.0, 5.0);
            Rectangle rect2 = new Rectangle(1.0, 2.0);
            Console.WriteLine(HowMany(rect1, rect2));
        }
    }
}
