using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalcBackend.Models
{
    public class SaleCalcType
    {
        // todo get rid of, change to single calc type with factory
        public string Name { get; set; }
        public string CostInput
        {
            get { return "Cost Price"; }
            set { CostInput = value; }
        }

        public string GPInput
        {
            get { return "GP Percentage"; }
            set { GPInput = value; }
        }
    }
}
