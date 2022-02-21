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

namespace Lab01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DatePicker_DateChanged(object Sender, SelectionChangedEventArgs e)
        {
            if (!DateCalculator.IsDateCorrect((DateTime)datePicker.SelectedDate))
            {
                MessageBox.Show("Date is incorrect");
                return;
            }
            if (DateCalculator.IsBirthday((DateTime)datePicker.SelectedDate))
            {
                MessageBox.Show("Happy Birthday!");
            }
            textBlock1.Text = DateCalculator.GetAge((DateTime)datePicker.SelectedDate).ToString();
            textBlock2.Text = DateCalculator.GetWesternZodiac((DateTime)datePicker.SelectedDate);
            textBlock3.Text = DateCalculator.GetChineseZodiac((DateTime)datePicker.SelectedDate);
        }

    }
}
