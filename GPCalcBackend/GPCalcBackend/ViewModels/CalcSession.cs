using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GPCalcBackend.Models;
using GPCalcBackend.Factories;

namespace GPCalcBackend.ViewModels
{
    public class CalcSession : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Calculator Calculator { get; set; }
        public CalcType CurrentCalcType
        {
            get { return _currentCalcType; }

            set
            {
                _currentCalcType = value;
                Calculator.CurrentCalcType = value;
                OnPropertyChanged();
            }
        }
        public float Input1
        {
            get { return _input1; }

            set
            {
                _input1 = value;
                OnPropertyChanged();
            }
        }
        public float Input2
        {
            get { return _input2; }

            set
            {
                _input2 = value;
                OnPropertyChanged();
            }
        }
        public float Output
        {
            get { return _output; }

            set
            {
                _output = value;
                OnPropertyChanged();
            }
        }


        private float _input1;
        private float _input2;
        private float _output;
        private CalcType _currentCalcType;
        public CalcSession()
        {

            Calculator = new Calculator();
            CurrentCalcType = Calculator.CurrentCalcType;
        }

        public void Calculate()
        {
            Output = Calculator.Calculate(Input1, Input2);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
