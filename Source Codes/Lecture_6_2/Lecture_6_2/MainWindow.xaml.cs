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

namespace Lecture_6_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            init_Combo_Box();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            decimal dc_number_1 = 0;
            decimal dc_number_2 = 0;

            bool blNumber1 =
                decimal.TryParse(txt_input_1.Text, out dc_number_1);

            bool blNumber2 =
               decimal.TryParse(txt_input_2.Text, out dc_number_2);

            //this is OR
            if (blNumber1 == false || blNumber2 == false)
            {
                MessageBox.Show("Error! You have typed incorrect value in the number text boxes!");
                return;
            }

            //when returns it doesnt continue from here

            if (cmbBoxOperation.SelectedIndex < 1)
            {
                MessageBox.Show("Error! You have to select a math operation!");
                return;
            }

            calculateAndPrint(dc_number_1, dc_number_2, cmbBoxOperation.SelectedIndex);
        }

        private void calculateAndPrint
            (
            decimal dcNum1, 
            decimal dcNum2, 
            int irSelectedOpIndex
            )
        {
            decimal dcResult = 0;
            string srOperation = "";

            switch (irSelectedOpIndex)
            {
                case 1:
                    dcResult = dcNum1 + dcNum2;
                    srOperation = "+";
                    break;
                case 2:
                    dcResult = dcNum1 - dcNum2;
                    srOperation = "-";
                    break;
                case 3:
                    dcResult = dcNum1 * dcNum2;
                    srOperation = "*";
                    break;
                case 4:
                    dcResult = dcNum1 / dcNum2;
                    srOperation = "/";
                    break;
            }

            lblResult.Content = string.Format("{0} {1} {2} = {3}", dcNum1,
                srOperation, dcNum2, dcResult);
        }

        private void init_Combo_Box()
        {
            cmbBoxOperation.Items.Add("Select an Operation");//index 0
            cmbBoxOperation.Items.Add("Plus (+)");
            cmbBoxOperation.Items.Add("Subtract (-)");
            cmbBoxOperation.Items.Add("Multiply (X)");
            cmbBoxOperation.Items.Add("Divide (/)");
            cmbBoxOperation.SelectedIndex = 0;
        }

        private void txt_input_1_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_input_1.Text = "";
        }

        private void txt_input_2_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_input_2.Text = "";
        }

        private void txt_input_1_LostFocus(object sender, RoutedEventArgs e)
        {
            if(txt_input_1.Text.Length==0)
            {
                txt_input_1.Text = "number 1";
            }
        }

        private void txt_input_2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txt_input_2.Text.Length == 0)
            {
                txt_input_2.Text = "number 2";
            }
        }
    }
}
