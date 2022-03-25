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

namespace Sokoban
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        #region Properties
        // properties
        public static string UserName { get; set; }
        #endregion

        // constructor
        public MainWindow()
        {
            InitializeComponent();
            txtBoxUserName.Focus();
        }

        // when clicking the start button it ensures there is an input in the text box
        // username, so it is then displayed when playing the game
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxUserName.Text == "")
            {
                MessageBox.Show("Please Input a user name");
                return;
            }
            else
            {
                UserName = txtBoxUserName.Text;
            }
            MainPage appPage1 = new MainPage("Sokoban");
            appPage1.Show();
            this.Close();
        }
    }
}
