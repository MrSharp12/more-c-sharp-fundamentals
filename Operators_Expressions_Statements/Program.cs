using System;

namespace Operators_Expressions_Statements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // variable declaration
            int x, y, a, b;

            // assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // there are many mathematical operators

            // addition operator
            x = 3 + 4;

            // subtraction operator
            x = 4 - 3;

            // multiplication operator
            x = 10 * 5;

            // division operator
            x = 10 / 5;

            // order of operations using parenthesis
            x = (x + y) * (a - b);

            // there are many operators used to evaluate values

            //equality operator
            if (x == y)
            {
                
            }

            // greater than operator
            if (x > y)
            {
                
            }

            // less than operator
            if (x < y)
            {
                
            }

            // greater or equal to operator
            if (x >= y)
            {
                
            }

            // less than or equal to operator
            if (x <= y)
            {
                
            }

            // there are two "conditional" operators as well that can
            // be used to expand / enhance an evaluation
            // and they can be combined together multiple times

            // conditional AND operator
            if ((x > y) && (a > b))
            {
                
            }

            // conditional OR operator
            if ((x > y) || (a > b))
            {
                
            }

            // also, here's the in-line conditional operator we
            // learned in the previous lesson
            string message = (x == 1) ? "Car" : "Boat";

            // member access and Method invocation
            Console.WriteLine("Hey there");

        }
    }
}
