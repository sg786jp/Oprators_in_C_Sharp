using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithnatic_Oprator_C_
{
    public class RelationalOperator
    {
        public bool Relational(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is Greater");
                return true;
            }
            else if (num1 < num2)
            {
                Console.Write($"{num2} is Greater");
                return true;
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Both are Equal");
                return true;
            }
            else
            {
               return false;
            }
        }
    }

}
