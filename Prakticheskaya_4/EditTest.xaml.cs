using ConverterLib;
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

namespace Prakticheskaya_4
{
    public partial class EditTest : Page
    {
        List<Test> testlist = new List<Test>();
        public EditTest()
        {
            InitializeComponent();
            testlist = MyConverter.MyDeserialize<List<Test>>();
            DataGridX.ItemsSource = testlist;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Test> testlist2 = new List<Test>();
            foreach (var item in DataGridX.Items)
            {
                if (item is Test item2)
                {
                    testlist2.Add(item2);
                }
            }
            MyConverter.MySerialize(testlist2);
        }
    }
}
