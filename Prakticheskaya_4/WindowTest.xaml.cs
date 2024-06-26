﻿using ConverterLib;
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

namespace Prakticheskaya_4
{
    public partial class WindowTest : Window
    {
        private bool IsEnglish;
        public WindowTest(bool isEnglish_)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            IsEnglish = isEnglish_;
        }

        private void EditTest_Click(object sender, RoutedEventArgs e)
        {
            PgFrame.Content = new EditTest();
        }

        private void ProytiTest_Click(object sender, RoutedEventArgs e)
        {
            List<Test> testlist = MyConverter.MyDeserialize<List<Test>>();
            if (testlist == null || testlist.Count == 0)
            {
                PgFrame.Content = new NetTesta();
            }
            else if (testlist != null && testlist.Count > 0)
            {
                PgFrame.Content = new PageTest(IsEnglish);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
