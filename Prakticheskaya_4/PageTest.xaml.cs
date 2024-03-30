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
    public partial class PageTest : Page
    {
        List<Test> testlist = new List<Test>();
        int index = 0;
        int correct = 0;
        int incorrect = 0;
        
        private void SetPage()
        {
            if (index < testlist.Count)
            {
                NameTest.Content = testlist[index].Name;
                Button1.Content = testlist[index].Option1;
                Button2.Content = testlist[index].Option2;
                Button3.Content = testlist[index].Option3;
                Description.Content = testlist[index].Description;
            }
        }

        public PageTest()
        {
            InitializeComponent();
            testlist = JSONchik.myDeserialize<List<Test>>();
            SetPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(testlist[index].CorrectOption) == 2)
            {
                correct = correct + 1;
            }
            else
            {
                incorrect = incorrect + 1;
            }
            if (index < testlist.Count - 1)
            {
                index = index + 1;
                SetPage();
            }
            else if (index == testlist.Count - 1)
            {
                Button1.Visibility = Visibility.Hidden; Button2.Visibility = Visibility.Hidden; Button3.Visibility = Visibility.Hidden;
                Description.Visibility = Visibility.Hidden; 
                NameTest.Content = $"Тест был пройден, кол-во правильных ответов {correct}, кол-во неправильных {incorrect}";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(testlist[index].CorrectOption) == 1)
            {
                correct = correct + 1;
            }
            else
            {
                incorrect = incorrect + 1;
            }
            if (index < testlist.Count - 1)
            {
                index = index + 1;
                SetPage();
            }
            else if (index == testlist.Count - 1)
            {
                Button1.Visibility = Visibility.Hidden; Button2.Visibility = Visibility.Hidden; Button3.Visibility = Visibility.Hidden;
                Description.Visibility = Visibility.Hidden;
                NameTest.Content = $"Тест был пройден, кол-во правильных ответов {correct}, кол-во неправильных {incorrect}";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(testlist[index].CorrectOption) == 0)
            {
                correct = correct + 1;
            }
            else
            {
                incorrect = incorrect + 1;
            }
            if (index < testlist.Count - 1)
            {
                index = index + 1;
                SetPage();
            }
            else if (index == testlist.Count - 1)
            {
                Button1.Visibility = Visibility.Hidden; Button2.Visibility = Visibility.Hidden; Button3.Visibility = Visibility.Hidden;
                Description.Visibility = Visibility.Hidden;
                NameTest.Content = $"Тест был пройден, кол-во правильных ответов {correct}, кол-во неправильных {incorrect}";
            }
        }
    }
}
