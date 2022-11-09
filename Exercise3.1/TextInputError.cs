using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._1
{
    internal class TextInputError : UserError
    {

        public override string UEMessage()
        {
            return "You tried to use a textinput in a numeric only field. This fired an error!";

        }
    }
}
