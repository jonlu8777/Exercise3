using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._1
{
    internal class WhiteSpaceInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered value whitespace. This fired an error!";
        }
    }
}
