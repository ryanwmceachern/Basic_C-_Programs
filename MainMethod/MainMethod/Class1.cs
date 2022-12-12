using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{

    internal class Class1
    {

        //creating the methods

        //integer method
        public int math(int num)
        {
            int One = num / 10;
            return One;
        }

        //decimal method
        public int math(decimal num)
        {
            decimal Decimal = num + 10;
            int Two = Convert.ToInt32(Decimal);
            return Two;
        }

        //string method
        public int math(string num)
        {
            try
            {
                int String2 = Convert.ToInt32(num) * 10;
                return String2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}