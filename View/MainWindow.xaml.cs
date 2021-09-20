using CompilersAndInterpreters_1.Models;
using CompilersAndInterpreters_1.MyMessageBox;
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

        public string MessageAnalysis = "";

        public MainWindow()
        {
            InitializeComponent();
            DataContext = Model;

            Model.Conditions = "p,q,k,r";
            Model.Alphabet = "a,b,c";
            Model.FinalCondition = "r";
            Model.Input = "a,b,c,b,a,c,a,b";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Start();
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
                Table();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetData()
        {
            Model.BasicData = Logic.GetCorrectData(Model.Conditions, Model.Alphabet, Model.FinalCondition, Model.Input);

            Logic.CheckDataCorrection(Model.BasicData);
        }

        //Запуск
        private void Start()
        {
            GetData();

            Logic.CheckTableCorrection(Model.DataTable, Model.BasicData);

            Model.Admittance = Logic.IsCorrect(Model.DataTable, Model.BasicData.Conditions, Model.BasicData.Alphabet, Model.BasicData.FinalCondition, Model.BasicData.Input, out MessageAnalysis);
        }

        //Таблица
        private void Table()
        {
            GetData();

            Model.DataTable = Logic.GetStartTable(Model.BasicData.Conditions, Model.BasicData.Alphabet);

            Logic.CreateTable(Model.DataTable);
        }

        //Анализ
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(MessageAnalysis))
            {
                MyMessBox myMessageBox = new MyMessBox();
                myMessageBox.PrintAnalysis(MessageAnalysis);
                myMessageBox.Show();
            }
        }
    }
}
