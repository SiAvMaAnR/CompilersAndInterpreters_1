using CompilersAndInterpreters_1.ViewModels;
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

namespace CompilersAndInterpreters_1.MyMessageBox
{
    /// <summary>
    /// Логика взаимодействия для MyMessBox.xaml
    /// </summary>
    public partial class MyMessBox : Window
    {
        MyMessBoxViewModel Model = new MyMessBoxViewModel();

        public MyMessBox()
        {
            InitializeComponent();
            DataContext = Model;
        }

        public void PrintAnalysis(string Analysis)
        {
            Model.Message = Analysis;
        }
    }
}
