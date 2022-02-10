using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalcBackend.Models
{
    public class CalcType
    {
        public string Name { get; set; }
        public int ID;
        public string Input1
        {
            get { return Input1; }
            set { Input1 = value; }
        }

        public string Input2
        {
            get { return Input2; }
            set { Input2 = value; }
        }
    }
}
