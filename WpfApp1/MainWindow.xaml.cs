﻿using System;
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

namespace WpfApp1
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

        //this method will run when the window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create 3 expense objects 
            Expense e1 = new Expense()
            {
                Category = "Travel",
                Amount = 19.95m,
                ExpenseDate = new DateTime(2019, 6, 30)
            };

            Expense e2 = new Expense()
            {
                Category = "Entertainment",
                Amount = 99.95m,
                ExpenseDate = new DateTime(2019, 7, 30)
            };
            Expense e3 = new Expense()
            {
                Category = "Office",
                Amount = 9.99m,
                ExpenseDate = new DateTime(2019, 6, 25)
            };

            //add those to a list



            //display list in list box


        }
    }
}
