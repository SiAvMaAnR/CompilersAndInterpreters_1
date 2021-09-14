using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CompilersAndInterpreters_1.Models
{
    public class Logic
    {
        public static Data GetCorrectData(string conditions, string alphabet, string finalCondition, string input)
        {
            return new Data()
            {
                Conditions = conditions.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                Alphabet = alphabet.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                FinalCondition = finalCondition.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                Input = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList()
            };
        }


        public static bool IsCorrect(List<string> conditions, List<string> alphabet, List<string> finalCondition, List<string> input, out string Analysis)
        {


            Analysis = "";
            return true;
        }


        public static DataTable GetTable(List<string> Conditions, List<string> Alphabet)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Z").ReadOnly = true;
            foreach (var item in Alphabet)
            {
                dataTable.Columns.Add(item);
            }

            
            return dataTable;
        }
    }
}
