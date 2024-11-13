using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ASM1KTNC
{
    public class UserProfile
    {
        public string Name { get; set; }

        public string GetName()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new NullReferenceException("Hồ sơ rộng hoặc tên người dùng không có");
            }
            return Name;
        }
    }
}
