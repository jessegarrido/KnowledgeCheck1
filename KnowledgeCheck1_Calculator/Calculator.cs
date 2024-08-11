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
        public int UserInput()  // get userinput, require an integer
        {
            string input;
            int? valInt = null;
            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int userVal))
                {
                    valInt = userVal;
                } else
                {
                    Console.WriteLine($"{input} is not valid, please try again.");
                }
            } while (valInt == null);
            return valInt ?? 0; // coalesce to guarantee non-null return value
        }
    }
}
