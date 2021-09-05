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
using System.Windows.Shapes;
using WPFProject.ViewModel;

namespace WPFProject.View
{
    /// <summary>
    /// Interaction logic for TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        public TableWindow()
        {
            InitializeComponent();
        }

        bool isPressed1 = false;
        private void Table1_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button bt)
            {
                bt.IsEnabled = false;
                Helper.Helper.UserFilmMenuUC.TableListBox.Items.Add(bt.Content);
            }
            isPressed1 = true;
            if (isPressed1 == true)
            {
                MessageBox.Show("Table is selected!");

            }
        }
    }
}
