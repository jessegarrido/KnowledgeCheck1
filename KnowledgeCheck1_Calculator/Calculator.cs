using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
            // throw new NotImplementedException();
        }

        public double Divide(double first, double second)
        {
             return first / second;
        }
        public int UserInput()  // acquire an integer from user
        {
            string input;
            int? validInt = null;
            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int userVal))
                {
                    validInt = userVal;
                } else
                {
                    Console.WriteLine($"{input} is not valid.");
                }
            } while (validInt == null);
            return validInt ?? 0; // coalesce to promise non-null return
        }
    }
}
