using CompilersAndInterpreters_1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CompilersAndInterpreters_1.ViewModels
{
    public enum IsCorrect
    {
        Undefined,
        Correct,
        InCorrect
    }

    public class MainViewModel : BaseViewModel
    {
        private IsCorrect isCorrect = IsCorrect.Undefined;
        public IsCorrect IsCorrect
        {
            get { return isCorrect; }
            set
            {
                isCorrect = value;
                OnPropertyChanged(nameof(isCorrect));
            }
        }



        private string conditions;
        /// <summary>
        /// Множество состояний
        /// </summary>
        public string Conditions
        {
            get => conditions;
            set
            {
                conditions = value;
                OnPropertyChanged(nameof(conditions));
            }
        }

        private string alphabet;
        /// <summary>
        /// Алфавит
        /// </summary>
        public string Alphabet
        {
            get => alphabet;
            set
            {
                alphabet = value;
                OnPropertyChanged(nameof(alphabet));
            }
        }

        private string finalCondition;
        /// <summary>
        /// Заключительные состояния
        /// </summary>
        public string FinalCondition
        {
            get => finalCondition;
            set
            {
                finalCondition = value;
                OnPropertyChanged(nameof(finalCondition));
            }
        }

        private string input;
        /// <summary>
        /// Множество входных значений
        /// </summary>
        public string Input
        {
            get => input;
            set
            {
                input = value;
                OnPropertyChanged(nameof(input));
            }
        }

        private string analysis;
        /// <summary>
        /// Анализ
        /// </summary>
        public string Analysis
        {
            get => analysis;
            set
            {
                analysis = value;
                OnPropertyChanged(nameof(analysis));
            }
        }

        private Data basicData;
        /// <summary>
        /// Данные
        /// </summary>
        public Data BasicData
        {
            get => basicData;
            set
            {
                basicData = value;
                OnPropertyChanged(nameof(basicData));
            }
        }

        private DataTable dataTable;
        /// <summary>
        /// Таблица 
        /// </summary>
        public DataTable DataTable
        {
            get => dataTable;
            set
            {
                dataTable = value;
                OnPropertyChanged(nameof(dataTable));
            }
        }
    }
}
