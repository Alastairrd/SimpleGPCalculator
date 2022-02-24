using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GPCalcBackend.ViewModels;

namespace WPFCalcUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CalcSession _calcSession = new CalcSession();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = _calcSession;

            
        }

        public void OnClick_Calculate(object sender, RoutedEventArgs e)
        {
            float input1;
            float input2;
            
            if (float.TryParse(Input1.Text, out input1)) //checking to see if input is a float
            {
                _calcSession.Input1 = input1;
            }
            

            if (float.TryParse(Input2.Text, out input2)) //checking to see if input is a float
            {
                _calcSession.Input2 = input2;
            }
            

            _calcSession.Calculate();
        }
    }
}
