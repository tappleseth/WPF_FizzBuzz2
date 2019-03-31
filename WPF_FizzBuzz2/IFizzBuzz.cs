using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_FizzBuzz2
{
    interface IFizzBuzz
    {
        string DoTheFizzBuzz(string input);
        bool IsValidInput(string input);
    }
}
