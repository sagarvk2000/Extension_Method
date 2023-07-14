using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    public static class ExtensionClass
    {
        public static int Square(this Calculation c,int a)
        {
            return a * a;
        }
        public static int Multiply(this Calculation c, int a,int b)
        {
            return a * b;
        }

    }
}

