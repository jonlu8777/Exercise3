using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._1 
{
    internal class FileNameError : UserError
    {
        public override string UEMessage()
        {
            return "File Name Not Valid. This fired an error!";
        }
    }
}
