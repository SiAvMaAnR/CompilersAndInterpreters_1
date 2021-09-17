using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilersAndInterpreters_1.Models
{
    public class Data
    {
        /// <summary>
        /// Множество состояний
        /// </summary>
        public List<string> Conditions { get; set; }

        /// <summary>
        /// Алфавит
        /// </summary>
        public List<string> Alphabet { get; set; }

        /// <summary>
        /// Заключительные состояния
        /// </summary>
        public List<string> FinalCondition { get; set; }

        /// <summary>
        /// Множество входных значений
        /// </summary>
        public List<string> Input { get; set; }
    }
}
