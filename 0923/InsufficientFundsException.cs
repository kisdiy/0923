using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0923
{
    class InsufficientFundsException: Exception
    {
        public InsufficientFundsException(string ms) : base(ms)
        {

        }
    }
}
