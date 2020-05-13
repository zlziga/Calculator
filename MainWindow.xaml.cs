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

namespace Calculator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        double lastNumber, result;

        public MainWindow() {
            InitializeComponent();
            acButton.Click += acButton_Click;
            plusMinusButton.Click += plusMinusButton_Click;
            percentButton.Click += PercentButton_Click;
            equalsButton.Click += EqualsButton_Click;
        }
        private void OperationsButton_Click(object sender, RoutedEventArgs e) {

        }



        private void EqualsButton_Click(object sender, RoutedEventArgs e) {

        }

        private void PercentButton_Click(object sender, RoutedEventArgs e) {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber)) {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void acButton_Click(object sender, RoutedEventArgs e) {
            resultLabel.Content = "0";
        }
        private void plusMinusButton_Click(object sender, RoutedEventArgs e) {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber)) {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }


        private void numberButton_Click(object sender, RoutedEventArgs e) {
            int selectedValue = 0;

            if (sender == zeroButton) {
                selectedValue = 0;
            }
            if (sender == oneButton) {
                selectedValue = 1;
            }
            if (sender == twoButton) {
                selectedValue = 2;
            }
            if (sender == threeButton) {
                selectedValue = 3;
            }
            if (sender == fourButton) {
                selectedValue = 4;
            }
            if (sender == fiveButton) {
                selectedValue = 5;
            }
            if (sender == sixButton) {
                selectedValue = 6;
            }
            if (sender == sevenButton) {
                selectedValue = 7;
            }
            if (sender == eightButton) {
                selectedValue = 8;
            }
            if (sender == nineButton) {
                selectedValue = 9;
            }

            if (resultLabel.Content.ToString() == "0") {
                resultLabel.Content = $"{selectedValue}";
            }
            else {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }

    }
}
