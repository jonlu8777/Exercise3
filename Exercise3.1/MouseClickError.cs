using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._1
{
    internal class MouseClickError : UserError
    {
        public override string UEMessage()
        {
            return "Your mouse gave invalid input.This fired an error!";
        }
    }
}
