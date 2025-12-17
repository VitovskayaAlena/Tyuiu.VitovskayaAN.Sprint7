using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.VitovskayaAN.Sprint7.Project.V7.Lib;

namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Файл не найден: {filePath}");
                return new string[0, 0];
            }

            string[] lines = File.ReadAllLines(filePath);
            int rows = lines.Length;

            if (rows == 0) return new string[0, 0];

            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns && c < line_r.Length; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                string FilePath = @"C:\DataSprint7\InPutFileProjectV7.csv";

                if (!File.Exists(FilePath))
                {
                    MessageBox.Show($"Файл не найден: {FilePath}");
                    return;
                }

                // Загружаем данные
                string[,] arrayValues = LoadFromFileData(FilePath);
                int rows = arrayValues.GetLength(0);
                int columns = arrayValues.GetLength(1);

                if (rows == 0)
                {
                    MessageBox.Show("Файл пустой");
                    return;
                }

                // Очищаем таблицу
                dataGridViewMatrix_VAN.Columns.Clear();
                dataGridViewMatrix_VAN.Rows.Clear();

                // Устанавливаем 6 колонок (без задолженности)
                dataGridViewMatrix_VAN.ColumnCount = 6;

                // Настраиваем колонки
                dataGridViewMatrix_VAN.Columns[0].HeaderText = "Номер подъезда";
                dataGridViewMatrix_VAN.Columns[0].Width = 75;

                dataGridViewMatrix_VAN.Columns[1].HeaderText = "Номер квартиры";
                dataGridViewMatrix_VAN.Columns[1].Width = 75;

                dataGridViewMatrix_VAN.Columns[2].HeaderText = "Кол-во комнат";
                dataGridViewMatrix_VAN.Columns[2].Width = 75;

                dataGridViewMatrix_VAN.Columns[3].HeaderText = "Фамилия квартиросъёмщика";
                dataGridViewMatrix_VAN.Columns[3].Width = 125;

                dataGridViewMatrix_VAN.Columns[4].HeaderText = "Количество членов семьи";
                dataGridViewMatrix_VAN.Columns[4].Width = 100;

                dataGridViewMatrix_VAN.Columns[5].HeaderText = "Количество детей в семье";
                dataGridViewMatrix_VAN.Columns[5].Width = 100;

                // Заполняем таблицу (только первые 6 колонок)
                for (int r = 0; r < rows; r++)
                {
                    int rowIndex = dataGridViewMatrix_VAN.Rows.Add();
                    for (int c = 0; c < 6; c++) // Только 6 колонок
                    {
                        if (c < columns)
                        {
                            dataGridViewMatrix_VAN.Rows[rowIndex].Cells[c].Value = arrayValues[r, c];
                        }
                    }
                }

                // Статистика
                if (dataGridViewMatrix_VAN.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для статистики");
                    return;
                }

                int sumAll = 0;
                int sumKids = 0;
                int apartmentCount = 0;
                int minMembers = int.MaxValue;
                int maxMembers = int.MinValue;

                // Считаем статистику
                for (int i = 0; i < dataGridViewMatrix_VAN.Rows.Count - 1; i++)
                {
                    // Количество квартир
                    if (dataGridViewMatrix_VAN.Rows[i].Cells[1].Value != null)
                    {
                        apartmentCount++;
                    }

                    // Члены семьи
                    if (dataGridViewMatrix_VAN.Rows[i].Cells[4].Value != null)
                    {
                        if (int.TryParse(dataGridViewMatrix_VAN.Rows[i].Cells[4].Value.ToString(), out int members))
                        {
                            sumAll += members;

                            // Находим минимум и максимум
                            if (members < minMembers) minMembers = members;
                            if (members > maxMembers) maxMembers = members;
                        }
                    }

                    // Дети
                    if (dataGridViewMatrix_VAN.Rows[i].Cells[5].Value != null)
                    {
                        if (int.TryParse(dataGridViewMatrix_VAN.Rows[i].Cells[5].Value.ToString(), out int kids))
                        {
                            sumKids += kids;
                        }
                    }
                }

                // Заполняем текстовые поля
                textBoxCountK_VAN.Text = apartmentCount.ToString();
                textBoxCountCh_VAN.Text = sumAll.ToString();
                textBoxCountD_VAN.Text = sumKids.ToString();

                // Минимум и максимум
                if (minMembers != int.MaxValue)
                    textBoxMin_VAN.Text = minMembers.ToString();
                else
                    textBoxMin_VAN.Text = "0";

                if (maxMembers != int.MinValue)
                    textBoxMax_VAN.Text = maxMembers.ToString();
                else
                    textBoxMax_VAN.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void buttonPoisk_VAN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix_VAN.Rows.Count - 1; i++)
            {
                dataGridViewMatrix_VAN.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewMatrix_VAN.Columns.Count; j++)
                {
                    if (dataGridViewMatrix_VAN.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridViewMatrix_VAN.Rows[i].Cells[j].Value.ToString().Contains(textBoxPoisk_VAN.Text))
                        {
                            dataGridViewMatrix_VAN.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void buttonFiltr_VAN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix_VAN.Rows.Count - 1; i++)
            {
                dataGridViewMatrix_VAN.Rows[i].Visible = false;
                for (int j = 0; j < dataGridViewMatrix_VAN.Columns.Count; j++)
                {
                    if (dataGridViewMatrix_VAN.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridViewMatrix_VAN.Rows[i].Cells[j].Value.ToString().Contains(textBoxFiltr_VAN.Text))
                        {
                            dataGridViewMatrix_VAN.Rows[i].Visible = true;
                            break;
                        }
                    }
                }
            }
        }

        private void buttonSbros_VAN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix_VAN.Rows.Count - 1; i++)
            {
                dataGridViewMatrix_VAN.Rows[i].Visible = true;
            }
        }

        private void buttonSort_VAN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSort_VAN.Text, out int numSort))
            {
                if (numSort >= 0 && numSort < dataGridViewMatrix_VAN.Columns.Count)
                {
                    dataGridViewMatrix_VAN.Sort(dataGridViewMatrix_VAN.Columns[numSort], ListSortDirection.Ascending);
                }
                else
                {
                    MessageBox.Show($"Введите число от 0 до {dataGridViewMatrix_VAN.Columns.Count - 1}");
                }
            }
            else
            {
                MessageBox.Show("Введите число от 0 до 5");
            }
        }
    }
}