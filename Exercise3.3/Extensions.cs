using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
public static class Extensions
    {
     
       public static string makeStringofProperties(this object obj )
        {
            var props = obj.GetType().GetProperties();
            var sb = new StringBuilder();
            foreach ( var prop in props )
            {
                sb.AppendLine( prop.Name + ": " + prop.GetValue(obj, null));

            }
            return sb.ToString();

        }
    
    
    }
}
