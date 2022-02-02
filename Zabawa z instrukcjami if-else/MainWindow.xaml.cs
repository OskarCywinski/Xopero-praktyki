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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            changeText.Click += changeText_Click;    
        }
        private void changeText_Click(object sender, RoutedEventArgs e)
        {
            if (enableCheckbox.IsChecked == true)
            {

                if (labelToChange.Text == "Z Prawej")
                {
                    labelToChange.Text = "Z Lewej";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    labelToChange.Text = "Z Prawej";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Right;
                }

            }
            else
            {
                labelToChange.Text = "Możliwość zmiany tekstu została wyłączona";
                labelToChange.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
