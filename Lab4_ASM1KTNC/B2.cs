using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ASM1KTNC
{
    public class B2
    {
        public double b2(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Không thể chia cho không");
            }
            return (double)a / b;
        }
    }
}
