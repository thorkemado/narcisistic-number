using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace narcisistic_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Narcissistic(153);

           
        }

        public static bool Narcissistic(int value)
        {
          var array= value.ToString().Select(x => int.Parse(x.ToString()));
            int result = 0;
            int index = array.Count();
           foreach(int Val in array)
            {
                result = result + (int) Math.Pow(Val, index);
            }
            return (result==value);
        }
    }
}
