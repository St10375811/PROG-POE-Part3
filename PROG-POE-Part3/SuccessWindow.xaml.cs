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
using System.Windows.Shapes;



namespace PROG_POE_Part3
{
    public partial class SuccessWindow : Window
    {
        
        public SuccessWindow(string message)
        {
            InitializeComponent();
            SuccessMessagelbl.Content = message;
        }

        
        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {//Closebtn begin
            this.Close();
        }
    }
}
