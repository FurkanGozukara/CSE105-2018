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

namespace Lecture_11___2
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

        Dictionary<Int64, ogrenci> dicOgrenciler = new Dictionary<long, ogrenci>();

        private void addOgrenci_Click(object sender, RoutedEventArgs e)
        {
            ogrenci myOgrenci = new ogrenci();
            try
            {
                myOgrenci.irOgrenciNo = Convert.ToInt64(txtStudenNo.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message.ToString());
                return;
            }

            myOgrenci.srOgrenciName = txtStudentName.Text;

            double outResult = 0;

            if (!double.TryParse(txtVize.Text, out outResult))
            {
                MessageBox.Show("You have entered incorrect value for the midterm score!");
                return;
            }

            myOgrenci.dblVizeNot = outResult;

            outResult = 0;

      if (double.TryParse(txtFinalNotu.Text, out outResult) == false)
            {
                MessageBox.Show("You have entered incorrect value for the final score!");
                return;
            }

            myOgrenci.dblFinal = outResult;
            //if that student exists, update his/her scores
            if (dicOgrenciler.ContainsKey(myOgrenci.irOgrenciNo))
            {
                //dicOgrenciler[key]=value
                dicOgrenciler[myOgrenci.irOgrenciNo] = myOgrenci;
            }
            else//else add that student to the records
                dicOgrenciler.Add(myOgrenci.irOgrenciNo, myOgrenci);

            refreshListBox();
        }
        
        private void refreshListBox()
        {
            lstOgrenciler.Items.Clear();
            dicOgrenciler= dicOgrenciler.OrderBy(pr => pr.Value.irOgrenciNo).ToDictionary(pr => pr.Key, pr => pr.Value);

            foreach (var wholeValue in dicOgrenciler)
            {
                lstOgrenciler.Items.Add(
                    string.Format("NO: {0} , İsim: {1} , Vize: {2} , Final: {3}",
                    wholeValue.Value.irOgrenciNo,   //0
                    wholeValue.Value.srOgrenciName, //1
                    wholeValue.Value.dblVizeNot,    //2
                    wholeValue.Value.dblFinal)      //3
                    );    
            }
        }
    }
}
