using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ASM1KTNC
{
    public class B1
    {
        public int b1(object x, object y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("Inputs cannot be null.");
            }

            if (!(x is int) || !(y is int))
            {
                throw new ArgumentException("Both inputs must be integers.");
            }

            return (int)x * (int)y;
        }
    }
    
}
