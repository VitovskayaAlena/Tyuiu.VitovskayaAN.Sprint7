using System.ComponentModel;
using Tyuiu.VitovskayaAN.Sprint7.Project.V7.Lib;

namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7
{
    public partial class FormStatistics : Form
    {
        private string filePath;
        public FormStatistics(string path = @"C:\DataSprint7\InPutFileProjectV7.csv")
        {
            InitializeComponent();
            filePath = path; 
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                string FilePath = filePath ?? @"C:\DataSprint7\InPutFileProjectV7.csv";
                DataService ds = new DataService();

                // загружаем данные в таблицу 
                string[,] arrayValues = LoadFromFileData(FilePath);
                int rows = arrayValues.GetLength(0);
                int columns = arrayValues.GetLength(1);

                // очищаем таблицу
                dataGridViewMatrix_VAN.Columns.Clear();
                dataGridViewMatrix_VAN.Rows.Clear();

                // создаем 6 колонок
                dataGridViewMatrix_VAN.ColumnCount = 6;
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

                // заполняем таблицу
                for (int r = 0; r < rows; r++)
                {
                    int rowIndex = dataGridViewMatrix_VAN.Rows.Add(); // добавляем новую строку
                    for (int c = 0; c < 6; c++) 
                    {
                        if (c < columns) // проверяем что данные есть
                        {
                            dataGridViewMatrix_VAN.Rows[rowIndex].Cells[c].Value = arrayValues[r, c];
                        }
                    }
                }

                // вычисление через библиотеку
                textBoxCountK_VAN.Text = ds.CountApartments(FilePath).ToString();
                textBoxCountCh_VAN.Text = ds.SumFamilyMembers(FilePath).ToString();
                textBoxCountD_VAN.Text = ds.SumChildren(FilePath).ToString();
                textBoxMin_VAN.Text = ds.MinFamilyMembers(FilePath).ToString();
                textBoxMax_VAN.Text = ds.MaxFamilyMembers(FilePath).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // метод загрузки данных из файла
        public static string[,] LoadFromFileData(string filePath)
        {
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

        private void buttonPoisk_VAN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix_VAN.Rows.Count - 1; i++)
            {
                dataGridViewMatrix_VAN.Rows[i].Selected = false; // снимаем выделение
                for (int j = 0; j < dataGridViewMatrix_VAN.Columns.Count; j++)
                {
                    if (dataGridViewMatrix_VAN.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridViewMatrix_VAN.Rows[i].Cells[j].Value.ToString().Contains(textBoxPoisk_VAN.Text))
                        {
                            dataGridViewMatrix_VAN.Rows[i].Selected = true; // выделяем строку
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
                dataGridViewMatrix_VAN.Rows[i].Visible = false; // скрываем строку
                for (int j = 0; j < dataGridViewMatrix_VAN.Columns.Count; j++)
                {
                    if (dataGridViewMatrix_VAN.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridViewMatrix_VAN.Rows[i].Cells[j].Value.ToString().Contains(textBoxFiltr_VAN.Text))
                        {
                            dataGridViewMatrix_VAN.Rows[i].Visible = true; // показываем строку
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
                dataGridViewMatrix_VAN.Rows[i].Visible = true; // показываем все строки
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