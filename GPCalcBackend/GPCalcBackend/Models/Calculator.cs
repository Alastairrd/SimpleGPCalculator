using GPCalcBackend.Factories;
using GPCalcBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace GPCalcBackend
{
    public class Calculator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private CalcType _currentCalcType { get; set; }
        public CalcType CurrentCalcType
        {
            get { return _currentCalcType; }

            set
            {
                _currentCalcType = value;
                OnPropertyChanged();
            }
        }

        public List<CalcType> CalcTypes { get; set; }

        public Calculator()
        {
            CalcTypes = new List<CalcType>();

            CalcTypes.Add(CalcTypeFactory.LoadCalcType(1)); //cost calc
            CalcTypes.Add(CalcTypeFactory.LoadCalcType(2)); //gp calc
            CalcTypes.Add(CalcTypeFactory.LoadCalcType(3)); //sale calc

            OnPropertyChanged();
        }

        public float Calculate(float input1, float input2)
        {
            float output = 0;

            int id = CurrentCalcType.ID;

            switch (id)
            {
                case 1: //Cost price calculation 

                    output = input1 - input2 * input1 / 100; //sale - gp * sale / 100

                    return output;


                case 2: //gp margin calculator

                    output = (input1 - input2) / input1 * 100; //(sale - cost) / sale * 100;

                    return output;


                case 3: //sale price calculator 

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
