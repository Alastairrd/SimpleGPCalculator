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
        private string _input1;
        private string _input2;
        public string Input1
        {
            get => _input1; 
            set => _input1 = value;
        }

        public string Input2
        {
            get => _input2; 
            set => _input2 = value; 
        }
    }
}
