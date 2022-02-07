using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GPCalcBackend
{
    public class Calculator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public float OutputValue = 0;
        public string CurrentCalcType { get; set; }


        public List<string> CalcTypes { get; set; }

        //TODO remake calc type classes into single calctype class
        //set calctypes as list of calctypes instead of list of string
        public Calculator()
        {
            CurrentCalcType = "Gp Output";

            CalcTypes = new List<string>();
            CalcTypes.Add("Sale Output");
            CalcTypes.Add("GP Output");
            CalcTypes.Add("Cost Output");

            OnPropertyChanged();
        }
        public float GPCalculation(float costinput, float salepriceinput)
        {
            float output;

            output = (salepriceinput - costinput) / salepriceinput * 100;

            return output;
        }

        public float SaleCalculation(float costinput, float gpinput)
        {
            float output;

            output = costinput / (1 - (gpinput / 100));

            return output;
        }

        public float CostCalculation(float saleinput, float gpinput)
        {
            float output;

            output = saleinput - gpinput * saleinput / 100;

            return output;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
