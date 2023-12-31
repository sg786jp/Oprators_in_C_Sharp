using Arithnatic_Oprator_C_;
using System;

namespace Arithmatic
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Result;

            // Arithmetic Operations
            Result = 78 + 78;
            Console.WriteLine($"Addition : {Result}");
            Result = 98 - 89;
            Console.WriteLine($"Subtraction : {Result}");
            Result = 89 * 78;
            Console.WriteLine($"Multiplication : {Result}");
            Result = 78 / 2;
            Console.WriteLine($"Division: {Result}");
            Result = 89 % 2;
            Console.WriteLine($"Mod: {Result}");

            // Assignment Operator
            Assignment_Oprator assignment_OPrator = new Assignment_Oprator();
            assignment_OPrator.Assignment(89);

            // Relational Operator
            RelationalOperator ro = new RelationalOperator();
            bool result = ro.Relational(56, 89);
            Console.WriteLine($"{result}");
        }
    }
}
