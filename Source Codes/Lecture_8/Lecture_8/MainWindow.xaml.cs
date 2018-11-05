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
using System.IO;

namespace Lecture_8
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

        private void btnAddList_Click(object sender, RoutedEventArgs e)
        {
            //name of the listbox
            lstList1.Items.Add(txtAdd.Text);
        }

        private void btnDeleteSelected_Click(object sender, RoutedEventArgs e)
        {
            if (lstList1.SelectedIndex < 0)
            {
                MessageBox.Show("you did not select any element to delete!");
                return;
            }

            lstList1.Items.RemoveAt(lstList1.SelectedIndex);
        }

        private void deleteWrittenElement_Click(object sender, RoutedEventArgs e)
        {
            lstList1.Items.Remove(txtElementDelete.Text);
        }

        private void btnWritetoFile_Click(object sender, RoutedEventArgs e)
        {

            //StreamWriter writer = new StreamWriter(txtFileName.Text);

            //    for (int i = 0; i < lstList1.Items.Count; i++)
            //    {
            //        writer.WriteLine(lstList1.Items[i]);
            //    }

            //writer.Close();//you have to either close streamwriter or use using approach

            using (StreamWriter writer2 = new StreamWriter(txtFileName.Text))
            {
                writer2.AutoFlush = true;
                for (int i = 0; i < lstList1.Items.Count; i++)
                {
                    writer2.WriteLine(lstList1.Items[i]);
                    writer2.Flush();//either auto flush true or call this function
                }
            }

            using (StreamWriter writer2 = new StreamWriter(txtFileName.Text, true))
            {
                writer2.AutoFlush = true;
                writer2.WriteLine("bu satır dosyanın üzerine eklenecek");
            }

            List<string> lstListBoxItems = new List<string>();

            for (int i = 0; i < lstList1.Items.Count; i++)
            {
                lstListBoxItems.Add(lstList1.Items[i].ToString());
            }

            File.WriteAllLines(txtFileName.Text, lstListBoxItems);

            List<string> lstToWrite = new List<string> { "öğe 1", "öğe 2", "öğe 3" };

            File.WriteAllLines("direk_liste.txt", lstToWrite);
        }
    }
}
