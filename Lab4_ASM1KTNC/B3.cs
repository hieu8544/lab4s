using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ASM1KTNC
{
    public class B3
    {
        public double b3(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArithmeticException("KDanh sách không được null");
            }

            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Count;
        }
    }
}
