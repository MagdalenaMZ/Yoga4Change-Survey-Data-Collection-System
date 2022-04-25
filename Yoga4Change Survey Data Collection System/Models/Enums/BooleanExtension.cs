using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yoga4Change_Survey_Data_Collection_System.Models.Enums
{
public static class BooleanExtensions
{
        public static string ToYesNoString(this bool b)
        {
            return b ? "Yes" : "No";
        }
    }
}
