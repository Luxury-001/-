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

namespace set_1
{
    /// <summary>
    /// Логика взаимодействия для CRUD.xaml
    /// </summary>
    public partial class CRUD : Window
    {
        public CRUD(int x)
        {
            InitializeComponent();
            switch(x)
            {
                case 1:
                    Chan Chan = new Chan();
                    MainFrame.Content = Chan;
                    break;
            }
        }
    }
}
