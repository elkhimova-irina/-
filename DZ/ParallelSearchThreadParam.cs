using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ
{
    class ParallelSearchThreadParam
    {

        /// Массив для поиска
        /// </summary>
        public List<string> tempList { get; set; }

        /// <summary>
        /// Слово для поиска
        /// </summary>
        public string wordPattern { get; set; }

        /// <summary>
        /// Пороговое расстояние для поиска
        /// </summary>
        public int maxDist { get; set; }

        /// <summary>
        /// Номер потока
        /// </summary>
        public int ThreadNum { get; set; }
    }
}
