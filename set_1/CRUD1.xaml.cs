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

namespace set_1
{
    /// <summary>
    /// Логика взаимодействия для CRUD.xaml
    /// </summary>
    public partial class CRUD1 : Window
    {
        public CRUD1(int x)
        {
            InitializeComponent();
            switch(x)
            {
                case 1:
                    AddData addData = new AddData();
                    MainFrame.Content = addData;
                    break;
                case 2:
                    DelPage delPage = new DelPage();
                    MainFrame.Content = delPage;
                    break;
                case 3:
                    UpdPage updPage = new UpdPage();
                    MainFrame.Content = updPage;
                    break;
                case 4:
                    AcPage acPage = new AcPage();
                    MainFrame.Content = acPage;
                    break;
            }
        }
    }
}
