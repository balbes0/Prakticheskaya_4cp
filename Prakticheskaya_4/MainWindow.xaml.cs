using System.Windows;
using System.IO;
using ConverterLib;

namespace Prakticheskaya_4
{
    public partial class MainWindow : Window
    {
        List<Test> testlist = new List<Test>();
        string password = "смайл фейс";
        private bool isEnglish = false;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Тест.json"))
            {
                using (File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Тест.json")) { }
                MyConverter.MySerialize(testlist);
            }
        }

        private void OpenTest_Click(object sender, RoutedEventArgs e)
        {
            WindowTest windowTest = new WindowTest(isEnglish);
            windowTest.Show();
            windowTest.EditTest.IsEnabled = false;
            this.Close();
        }

        private void OpenEditTest_Click(object sender, RoutedEventArgs e)
        {
            if (password == Password.Text)
            {
                WindowTest windowTest = new WindowTest(isEnglish);
                windowTest.Show();
                this.Close();
            }
        }

        private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            var dictionary = new ResourceDictionary();
            if (isEnglish)
            {
                dictionary.Source = new Uri("pack://application:,,,/LocalizationLibrary;component/Resources/lang.ru-ru.xaml", UriKind.Absolute);
                isEnglish = false;
            }
            else
            {
                dictionary.Source = new Uri("pack://application:,,,/LocalizationLibrary;component/Resources/lang.en-us.xaml", UriKind.Absolute);
                isEnglish = true;
            }
            var oldDictionary = Application.Current.Resources.MergedDictionaries[2];
            Application.Current.Resources.MergedDictionaries.Remove(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}