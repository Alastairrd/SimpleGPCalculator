using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalcBackend.Models
{
    public class GPCalcType
    {
        public string Name { get; set; }
        public string SaleInput
        {
            get { return "Sale Price"; }
            set { SaleInput = value; }
        }

        public string CostInput
        {
            get { return "Cost Price"; }
            set { CostInput = value; }
        }
    }
}
