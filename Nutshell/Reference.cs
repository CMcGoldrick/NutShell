using System;
using System.Collections.Generic;
using System.Text;

namespace Nutshell
{
    class Reference
    {
        public void Show()
        {
            /*** VERBATIM IDENTIFIER ***/             
            //you want to use a keyword as an identifier (variable name)
            string[] @for = { "John", "James", "Joan", "Jamie" };
            for (int ctr = 0; ctr<@for.Length; ctr++)
            {
               Console.WriteLine($"Here is your gift, {@for[ctr]}!");
            }

            //you want to define a verbatim string literal
            //e.g. escape characters will not be treated as escape characters but as literal parts of the string
            string filename1 = @"c:\documents\files\u0066.txt";
            string filename2 = "c:\\documents\\files\\u0066.txt";



        }
}
}
