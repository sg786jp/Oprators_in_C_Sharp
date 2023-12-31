using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithnatic_Oprator_C_
{
    public class Assignment_Oprator
    {
      public void Assignment(int num)
        {
            Console.Write("Enter number for Assignment Oprator: ");
            num += Convert.ToInt32(Console.Read());
            Console.WriteLine(num);
            num -= Convert.ToInt32(Console.Read());
            Console.WriteLine(num);
            num *= Convert.ToInt32(Console.Read());
            Console.WriteLine(num);
            num %= Convert.ToInt32(Console.Read());
            Console.WriteLine(num);
        }
    }
}
