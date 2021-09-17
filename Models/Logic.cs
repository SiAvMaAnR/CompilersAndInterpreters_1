﻿using System;
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

        public static void CheckDataCorrection(Data data)
        {
            if (data.Conditions.Count == 0 || data.Alphabet.Count == 0 || data.FinalCondition.Count == 0 || data.Input.Count == 0)
            {
                throw new Exception("Заполните пустые поля!");
            }

            if (data.Conditions.Distinct().ToList().Count != data.Conditions.Count)
            {
                throw new Exception("Не корректное состояние!");
            }

            if (data.Alphabet.Distinct().ToList().Count != data.Alphabet.Count)
            {
                throw new Exception("Не корректный алфавит!");
            }

            if (!data.FinalCondition.All(x => data.Conditions.Contains(x)))
            {
                throw new Exception("Заключение не корректно!");
            }

            if (!data.Input.All(x => data.Alphabet.Contains(x)))
            {
                throw new Exception("Вход не корректен!");
            }
            #region Temp

            //string str = string.Join(" ", data.Conditions) + "\n"
            //           + string.Join(" ", data.Alphabet) + "\n"
            //           + string.Join(" ", data.FinalCondition) + "\n"
            //           + string.Join(" ", data.Input) + "\n"
            //           + string.Join(" ", data.Admittance) + "\n"
            //           + string.Join(" ", data.Analysis);

            //MessageBox.Show(str);
            #endregion
        }

        public static void CheckTableCorrection(DataTable dataTable, Data basicData)
        {
            for (int i = 1; i < dataTable.Columns.Count; i++)
            {
                if (!dataTable.AsEnumerable().All(x => basicData.Conditions.Contains(x[i]) || x[i].ToString() == ""))
                {
                    throw new Exception("Не корректная Таблица!");
                }
            }
        }

        public static void CreateTable(DataTable dataTable)
        {
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    for (int j = 1; j < dataTable.Columns.Count; j++)
            //    {
            //        dataTable.Rows[i][j] = "p";
            //    }
            //}

            dataTable.Rows[0][1] = "p";//a
            dataTable.Rows[0][2] = "q";//b
            dataTable.Rows[0][3] = "";//c

            dataTable.Rows[1][1] = "k";
            dataTable.Rows[1][2] = "";
            dataTable.Rows[1][3] = "p";

            dataTable.Rows[2][1] = "";
            dataTable.Rows[2][2] = "r";
            dataTable.Rows[2][3] = "q";

            dataTable.Rows[3][1] = "";
            dataTable.Rows[3][2] = "";
            dataTable.Rows[3][3] = "";
        }

        public static bool IsCorrect(DataTable dataTable, List<string> conditions, List<string> alphabet, List<string> finalCondition, List<string> input, out string Analysis)
        {
            string startPoint = conditions[0];//+




            Analysis = "XXX";
            return false;
        }


        public static DataTable GetStartTable(List<string> Conditions, List<string> Alphabet)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Z").ReadOnly = true;

            foreach (var item in Alphabet)
            {
                dataTable.Columns.Add(item);
            }

            foreach (var item in Conditions)
            {
                dataTable.Rows.Add(new object[] { item });
            }

            return dataTable;
        }
    }
}
