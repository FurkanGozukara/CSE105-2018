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

namespace Lecture_10
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

        private void txtPasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            lblPasswordRevelaed.Content = txtPasswordBox.Password.ToString();
        }

        int irMaxNumberofTabs = 4;//maximum number of available tabs
        int irCurrentSelectedTab = 1;//this is the index of active tab

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            setActiveTab(-1);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            setActiveTab(1);
        }

        private void setActiveTab(int incremment)
        {
            int irNewTab = irCurrentSelectedTab + incremment;
            if (irNewTab > irMaxNumberofTabs)
                irNewTab = 1;
            if (irNewTab < 1)
            {
                irNewTab = irMaxNumberofTabs;
            }

            switch (irNewTab)
            {
                case 4:
                    tab4.Focus();
                    irCurrentSelectedTab = 4;
                    break;
                case 3:
                    tab3.Focus();
                    irCurrentSelectedTab = 3;
                    break;
                case 2:
                    tab2.Focus();
                    irCurrentSelectedTab = 2;
                    break;
                case 1:
                    tab1.Focus();
                    irCurrentSelectedTab = 1;
                    break;
            }
        }

        private void btnEnabledisable_Click(object sender, RoutedEventArgs e)
        {
            var status = tab3.IsEnabled;
            var status2 = !tab3.IsEnabled;
            tab3.IsEnabled = !tab3.IsEnabled;
        }

        MathCalculate myCalculator = new MathCalculate();

        private void btnCalculateMath_Click(object sender, RoutedEventArgs e)
        {
            decimal myDecResult = 0;

            try
            {
                 myDecResult = myCalculator.Eval(txtMath.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("Error happened\r\n" + 
                    E.Message.ToString() + 
                    "\r\nInner Exception:" +
                    E?.InnerException?.Message.ToString());
                return;
            }

            lstBoxMathResults.Items.Insert(0, txtMath.Text + " = " + myDecResult);

        }

        private void btnExampleUsage_Click(object sender, RoutedEventArgs e)
        {
            class1.ExampleClass myTempClass = new class1.ExampleClass();
            var sonuc = myTempClass.returnSquare(12);

            var sonuc2 = myTempClass.callThreeSquare(12);
        }
    }
}
