using System.Windows;
using System.Windows.Controls;
using ConverterLib;

namespace Prakticheskaya_4
{
    public partial class PageTest : Page
    {
        List<Test> testlist = new List<Test>();
        int index = 0;
        int correct = 0;
        int incorrect = 0;
        private bool IsEnglish;

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

        public PageTest(bool IsEnglish_)
        {
            InitializeComponent();
            testlist = MyConverter.MyDeserialize<List<Test>>();
            SetPage();
            IsEnglish = IsEnglish_;
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
                ShowResult();
            }
        }

        private void ShowResult()
        {
            Button1.Visibility = Visibility.Hidden; Button2.Visibility = Visibility.Hidden; Button3.Visibility = Visibility.Hidden;
            Description.Visibility = Visibility.Hidden;
            if (IsEnglish)
            {
                NameTest.Content = "Test completed, number of correct answers " + correct + ", number of incorrect answers " + incorrect;
            }
            else
            {
                NameTest.Content = "Тест был пройден, кол-во правильных ответов " + correct + ", кол-во неправильных " + incorrect;
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
                ShowResult();
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
                ShowResult();
            }
        }
    }
}
