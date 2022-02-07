using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalcBackend.Models
{
    public class CostCalcType
    {
        public string Name { get; set; }
        public string SaleInput 
        {
            get { return "Sale Price"; }
            set { SaleInput = value; }
        }

        public string GPInput
        {
            get { return "GP Percentage"; }
            set { GPInput = value; }
        }
    }
}
