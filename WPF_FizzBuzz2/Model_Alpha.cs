using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FizzBuzz2
{
    public class Model_Alpha : IFizzBuzz
    {
        public bool IsValidInput(string input)
        {
            return int.TryParse(input, out _);
        }

        //a CORRECT FizzBuzz implementation
        public string DoTheFizzBuzz(string input)
        {
            StringBuilder ret = new StringBuilder();
            if (!int.TryParse(input, out int n)) return ret.ToString();
            if (n < 1) return ret.ToString();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ret.Append("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    ret.Append("Buzz");
                }
                else if (i % 3 == 0)
                {
                    ret.Append("Fizz");
                }
                else
                {
                    ret.Append(i.ToString());
                }
            }
            return ret.ToString();
        }
    }
}
