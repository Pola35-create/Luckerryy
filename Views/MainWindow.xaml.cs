using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Luckerryy.Models;
using Luckerryy.ViewModels;
using Luckerryy.Services;

namespace Luckerryy.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(new LotteryService());
        }

        private void LotteryBox_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ötöslottó details page coming soon!");
        }
    }
}