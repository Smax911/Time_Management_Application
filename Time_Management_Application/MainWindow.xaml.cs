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
using Time_Managements;

namespace Time_Management_Application
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

        public object ListHandler { get; private set; }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Management_Library d = new Management_Library();
                string Code = Convert.ToString(txbCode.Text);
                string Name = Convert.ToString(txbName.Text);
                d.NumberOfCredits = Convert.ToInt32(txbNumberOfCredits.Text);
                d.ClassHourPerWeek = Convert.ToDouble(txbClassHourPerWeek.Text);
                d.NumberOfWeeks = Convert.ToInt32(txbClassHourPerWeek.Text);
                DateTime StartDate = Convert.ToDateTime(dpStartDate_.Text);
               
                lstResults.Items.Add(Code);
                lstResults.Items.Add(Name);
                lstResults.Items.Add(StartDate);
                lstResults.Items.Add(d.SelfStudying);

               
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
