using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ASM1KTNC
{
    public class B4
    {
        public int GetElementAtIndex(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException($"Chỉ số {index} vượt quá giới hạn của mảng.");
            }

            return array[index];
        }
    }
}
