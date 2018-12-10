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

namespace Lecture_12___2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            scanUsers();
        }

        Dictionary<string, string> dicUsers = new Dictionary<string, string>();

        private void btnaddstudent_Click(object sender, RoutedEventArgs e)
        {
            string srStudent = txtid.Text + ";" + txtname.Text + ";" + txtscore.Text;
            string srStudentId = txtid.Text;

            if(dicUsers.ContainsKey(srStudentId))
            {
                dicUsers[srStudentId] = srStudent;
            }
            else
            {
                dicUsers.Add(srStudentId, srStudent);
            }

            writeToFile();
        }

        private void writeToFile()
        {
            StringBuilder srBuilder = new StringBuilder();
            foreach (var vrUserItem in dicUsers)
            {
                srBuilder.AppendLine(vrUserItem.Value);
            }

            File.WriteAllText("users.txt", srBuilder.ToString());

            scanUsers();
        }

        private void scanUsers()
        {
            if(!File.Exists("users.txt"))
                return;

            dicUsers.Clear();
            lstStudents.Items.Clear();

            foreach (var vrItem in File.ReadAllLines("users.txt"))
            {
                var vrStudentId = vrItem.Split(';')[0];
                dicUsers.Add(vrStudentId, vrItem);
                lstStudents.Items.Add(vrItem);
            }

        }

        private void lstStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var vrSelectedItem = lstStudents.SelectedValue;

            if (vrSelectedItem == null)
                return;

            txtid.Text = vrSelectedItem.ToString().Split(';')[0];
            txtname.Text = vrSelectedItem.ToString().Split(';')[1];
            txtscore.Text = vrSelectedItem.ToString().Split(';')[2];
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            dicUsers.Remove(txtid.Text);
            writeToFile();
        }
    }
}
