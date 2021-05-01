using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OddEven
    {
        static public void mod(int x, out string R)
        {
            if (x % 2 == 0)
                R = "Even";
            else
                R = "Odd";
        }
        static public void BitWise(int x, out string R)
        {
            if ((x & 1) == 0)
                R = "Even";
            else
                R = "Odd";
        }
        static public void div(int x, out string R)
        {
            if (((x / 2) * 2) == x)
                R = "Even";
            else
                R = "Odd";
        }
        static public void shift(int x, out string R)
        {
            if (((x >> 1) << 1) == x)
                R = "Even";
            else
                R = "Odd";
        }
        static public void LastDigit(int x, out string R)
        {
            string tempstr = x.ToString();
            int index = tempstr.Length - 1;
            if (tempstr[index] == '0' || tempstr[index] == '2' ||
                tempstr[index] == '4' || tempstr[index] == '6' ||
                tempstr[index] == '8')
                R = "Even";
            else
                R = "Odd";
        }
    }

}
