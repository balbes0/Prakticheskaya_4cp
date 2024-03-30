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
using Newtonsoft.Json;
using System.IO;

namespace Prakticheskaya_4
{
    public partial class MainWindow : Window
    {
        List<Test> testlist = new List<Test>();
        string password = "смайл фейс";
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Тест.json"))
            {
                using (File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Тест.json")) { }
                JSONchik.mySerialize(testlist);
            }
        }

        private void OpenTest_Click(object sender, RoutedEventArgs e)
        {
            WindowTest windowTest = new WindowTest();
            windowTest.Show();
            windowTest.EditTest.IsEnabled = false;
            this.Close();
        }

        private void OpenEditTest_Click(object sender, RoutedEventArgs e)
        {
            if (password == Password.Text)
            {
                WindowTest windowTest = new WindowTest();
                windowTest.Show();
                this.Close();
            }
        }
    }
}