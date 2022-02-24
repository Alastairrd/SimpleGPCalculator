using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPCalcBackend.Models;

namespace GPCalcBackend.Factories
{
    public static class CalcTypeFactory
    {
        private static List<CalcType> _calcTypes = new List<CalcType>();
        static CalcTypeFactory()
        {
            CreateCalcType("Cost Price", 1, "Sale Price", "GP Margin");
            CreateCalcType("GP Margin", 2, "Sale Price", "Cost Price");
            CreateCalcType("Sale Price", 3, "GP Margin", "Cost Price");
        }

        private static void CreateCalcType(string name, int id, string input1, string input2)
        {
            CalcType newCalcType = new CalcType();

            newCalcType.Name = name;
            newCalcType.ID = id;
            newCalcType.Input1 = input1;
            newCalcType.Input2 = input2;

            _calcTypes.Add(newCalcType);
        }

        public static CalcType LoadCalcType(int id)
        {
            return _calcTypes.FirstOrDefault(c => c.ID == id);
        }
    }
}
