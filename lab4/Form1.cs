using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab5;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "текстовые файлы|*.txt";

            if (f.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();

                string text = File.ReadAllText(f.FileName);

                //разделительные знаки
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };

                string[] textArray = text.Split(separators);

                foreach (string strTemp in textArray)
                {
                    //удаление пробелов
                    string str = strTemp.Trim();
                    //добавление строки в список, если строка не содерж в списке
                    if (!list.Contains(str)) list.Add(str);
                }

                t.Stop();
                this.textBoxFileReadTime.Text = t.Elapsed.ToString();

            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }

        private void buttonExact_Click(object sender, EventArgs e)
        {
            string word = this.textBoxFind.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();

                Stopwatch t = new Stopwatch();
                t.Start();

                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }

                t.Stop();
                this.textBoxExactTime.Text = t.Elapsed.ToString();
                this.listBoxResult.BeginUpdate();

                //очистка списка
                this.listBoxResult.Items.Clear();
                //вывод результатов
                foreach (string str in tempList)
                {
                    this.listBoxResult.Items.Add(str);
                }
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Выберите файл и введите слово для поиска");
            }
        }

        private void buttonApprox_Click(object sender, EventArgs e)
        {

            //Слово для поиска
            string word = this.textBoxFind.Text.Trim();
            //Если слово для поиска не пусто
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                int maxDist;
                if (!int.TryParse(this.textBoxMaxDist.Text.Trim(), out maxDist))
                {
                    MessageBox.Show("Необходимо указать максимальное расстояние");
                    return;
                }
                if (maxDist < 1 || maxDist > 5)
                {
                    MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
                    return;
                }
                //Слово для поиска в верхнем регистре
                string wordUpper = word.ToUpper();
                //Временные результаты поиска
                List<Tuple<string, int>> tempList = new List<Tuple<string, int>>();
                Stopwatch t = new Stopwatch();
                t.Start();
                foreach (string str in list)
                {
                    //Вычисление расстояния Дамерау-Левенштейна
                    int dist = EditDistance.Distance(str.ToUpper(), wordUpper);
                    //Если расстояние меньше порогового, то слово добавляется в результат
                    if (dist <= maxDist)
                    {
                        tempList.Add(new Tuple<string, int>(str, dist));

                    }
                }
                t.Stop();
                this.textBoxApproxTime.Text = t.Elapsed.ToString();
                this.listBoxResult.BeginUpdate();
                //Очистка списка
                this.listBoxResult.Items.Clear();
                //Вывод результатов поиска
                foreach (var x in tempList)
                {
                    string temp = x.Item1 + " (расстояние = " + x.Item2.ToString() + ")";
                    this.listBoxResult.Items.Add(temp);
                }
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

        private void buttonExact_Click_1(object sender, EventArgs e)
        {
            
            string word = this.textBoxFind.Text.Trim();

            //Если слово для поиска не пусто
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                //Слово для поиска в верхнем регистре
                string wordUpper = word.ToUpper();

                //Временные результаты поиска
                List<string> tempList = new List<string>();

                Stopwatch t = new Stopwatch();
                t.Start();

                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }

                t.Stop();
                this.textBoxExactTime.Text = t.Elapsed.ToString();

                this.listBoxResult.BeginUpdate();

                //Очистка списка
                this.listBoxResult.Items.Clear();

                //Вывод результатов поиска 
                foreach (string str in tempList)
                {
                    this.listBoxResult.Items.Add(str);
                }
                this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonSaveReport_Click(object sender, EventArgs e)
        {
            //Имя файла отчета
            string TempReportFileName = "Report_" + DateTime.Now.ToString("dd_MM_yyyy_hhmmss");

            //Диалог сохранения файла отчета
            SaveFileDialog fd = new SaveFileDialog();
            fd.FileName = TempReportFileName;
            fd.DefaultExt = ".html";
            fd.Filter = "HTML Reports|*.html";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string ReportFileName = fd.FileName;

                //Формирование отчета
                StringBuilder b = new StringBuilder();
                b.AppendLine("<html>");

                b.AppendLine("<head>");
                b.AppendLine("<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>");
                b.AppendLine("<title>" + "Отчет: " + ReportFileName + "</title>");
                b.AppendLine("</head>");

                b.AppendLine("<body>");

                b.AppendLine("<h1>" + "Отчет: " + ReportFileName + "</h1>");
                b.AppendLine("<table border='1'>");

                b.AppendLine("<tr>");
                b.AppendLine("<td>Время чтения из файла</td>");
                b.AppendLine("<td>" + this.textBoxFileReadTime.Text + "</td>");
                b.AppendLine("</tr>");

               /* b.AppendLine("<tr>");
                b.AppendLine("<td>Количество уникальных слов в файле</td>");
                b.AppendLine("<td>" + this.textBoxFileReadCount.Text + "</td>");
                b.AppendLine("</tr>"); */

                b.AppendLine("<tr>");
                b.AppendLine("<td>Слово для поиска</td>");
                b.AppendLine("<td>" + this.textBoxFind.Text + "</td>");
                b.AppendLine("</tr>");

                b.AppendLine("<tr>");
                b.AppendLine("<td>Максимальное расстояние для нечеткого поиска</td>");
                b.AppendLine("<td>" + this.textBoxMaxDist.Text + "</td>");
                b.AppendLine("</tr>");

                b.AppendLine("<tr>");
                b.AppendLine("<td>Время четкого поиска</td>");
                b.AppendLine("<td>" + this.textBoxExactTime.Text + "</td>");
                b.AppendLine("</tr>");

                b.AppendLine("<tr>");
                b.AppendLine("<td>Время нечеткого поиска</td>");
                b.AppendLine("<td>" + this.textBoxApproxTime.Text + "</td>");
                b.AppendLine("</tr>");

                b.AppendLine("<tr valign='top'>");
                b.AppendLine("<td>Результаты поиска</td>");
                b.AppendLine("<td>");
                b.AppendLine("<ul>");

                foreach (var x in this.listBoxResult.Items)
                {
                    b.AppendLine("<li>" + x.ToString() + "</li>");
                }

                b.AppendLine("</ul>");
                b.AppendLine("</td>");
                b.AppendLine("</tr>");


                b.AppendLine("</table>");

                b.AppendLine("</body>");
                b.AppendLine("</html>");

                //Сохранение файла
                File.AppendAllText(ReportFileName, b.ToString());

                MessageBox.Show("Отчет сформирован. Файл: " + ReportFileName);
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
