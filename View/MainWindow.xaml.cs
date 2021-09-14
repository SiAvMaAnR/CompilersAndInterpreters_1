using CompilersAndInterpreters_1.Models;
using CompilersAndInterpreters_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace CompilersAndInterpreters_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel Model = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = Model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model.BasicData = Logic.GetCorrectData(Model.Conditions, Model.Alphabet, Model.FinalCondition, Model.Input);

                //MessageBox.Show(Model.DataTable.Rows[0][0].ToString() + Model.DataTable.Rows[0][1].ToString() + Model.DataTable.Rows[1][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Model.DataTable = Logic.GetTable(Model.BasicData.Conditions, Model.BasicData.Alphabet);
                PrintData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void PrintData()
        {
            try
            {
                string str = string.Join(" ", Model.BasicData.Conditions) + "\n"
                        + string.Join(" ", Model.BasicData.Alphabet) + "\n"
                        + string.Join(" ", Model.BasicData.FinalCondition) + "\n"
                        + string.Join(" ", Model.BasicData.Input);

                MessageBox.Show(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
