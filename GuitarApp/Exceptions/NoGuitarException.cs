using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Exceptions
{
    internal class NoGuitarException:Exception
    {
        public NoGuitarException(string error):base(error)
        {
            
        }

    }
}
