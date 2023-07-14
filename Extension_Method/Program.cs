using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            int res=c.Square(4);
            Console.WriteLine(res);
            int res2 = c.Multiply(5,6);
            Console.WriteLine(res2);
        }
    }
}
