using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalcBackend
{
    public class GPInput
    {
        public float Input;

        public GPInput(float input)
        {
            if (input > 0)
            {
                Input = input;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"{input} is not a valid input, as it is below 0");
            }
        }
    }
}
