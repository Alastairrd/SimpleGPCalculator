using GPCalcBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GPCalcBackend.Factories;

namespace GPCalcBackend
{
    public class Calculator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public float OutputValue = 0;
        public CalcType CurrentCalcType { get; set; }

        public List<CalcType> CalcTypes { get; set; }

        public Calculator()
        {
            CalcTypes = new List<CalcType>();

            CalcTypes.Add(CalcTypeFactory.LoadCalcType(1)); //cost calc
            CalcTypes.Add(CalcTypeFactory.LoadCalcType(2)); //gp calc
            CalcTypes.Add(CalcTypeFactory.LoadCalcType(3)); //sale calc

            CurrentCalcType = CalcTypes.FirstOrDefault(c => c.ID == 2); //sets default to gp

            OnPropertyChanged();
        }

        public float Calculate(float input1, float input2)
        {
            float output = 0;

            int id = CurrentCalcType.ID;

            switch(id)
            {
                case 1: //Cost price calculation // TO DO MATHS NOT WORKING

                    output = input1 - input2 * input1 / 100; //sale - gp * sale / 100

                    return output;
                    

                case 2: //gp margin calculator

                    output = (input1 - input2) / input1; //(sale - cost) / sale * 100;

                    return output;
                    

                case 3: //sale price calculator //TODO MATHS NOT WORKING

                    output = input2 / (1 - (input1 / 100)); // costinput / (1 - (gpinput / 100));

                    return output;
                    

                default:
                    throw new ArgumentOutOfRangeException("Selected CalcType id matches no known id");
                    
            }
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
