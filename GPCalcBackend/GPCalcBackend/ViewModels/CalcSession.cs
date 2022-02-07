using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GPCalcBackend.ViewModels
{
    public class CalcSession : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Calculator Calculator { get; set; }
        public string CurrentCalcType { get; set; }

        public CalcSession()
        {
            Calculator = new Calculator();
            CurrentCalcType = Calculator.CurrentCalcType;

        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
