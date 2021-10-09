using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningEnumValuesOverAPI.Helpers
{
    public class Enum<T> where T : Enum
    {
        public static IEnumerable<T> GetAllValuesAsIEnumerable()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
