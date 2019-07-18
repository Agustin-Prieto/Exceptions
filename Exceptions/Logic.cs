using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Logic
    {
        public void ThrowEx()
        {
            throw new Exception();
        }

        public void NewEx()
        {
            throw new NewException();
        }
    }
}
