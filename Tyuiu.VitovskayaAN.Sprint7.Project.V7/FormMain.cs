using System.ComponentModel;
using System.Text;

namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        string filePath = @"C:\DataSprint7\InPutFileProjectV7.csv";

        public FormMain()
        {
            InitializeComponent();
            CreateDataGridViewColumns(); // создаем колонки сразу
        }

        // метод для создания колонок DataGridView
        private void CreateDataGridViewColumns()
        {
            // очищаем существующие колонки (если есть)
            dataGridViewMatrix_VAN.Columns.Clear();

            // создаем колонки
            dataGridViewMatrix_VAN.Columns.Add("Column1", "Подъезд");
            dataGridViewMatrix_VAN.Columns.Add("Column2", "Квартира");
            dataGridViewMatrix_VAN.Columns.Add("Column3", "Комнаты");
            dataGridViewMatrix_VAN.Columns.Add("Column4", "Фамилия");
            dataGridViewMatrix_VAN.Columns.Add("Column5", "Члены семьи");
            dataGridViewMatrix_VAN.Columns.Add("Column6", "Дети");
        }

        // кнопка загрузки файла
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_VAN.Filter = "CSV файлы|*.csv";
                if (openFileDialog_VAN.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog_VAN.FileName;

                    // убедимся что колонки созданы
                    if (dataGridViewMatrix_VAN.Columns.Count == 0)
                    {
                        CreateDataGridViewColumns();
                    }

                    // читаем файл
                    string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                    // очищаем таблицу
                    dataGridViewMatrix_VAN.Rows.Clear();

                    // добавляем строки из файла
                    foreach (string line in lines)
                    {
                        if (line.Trim() != "")
                        {
                            string[] parts = line.Split(';');
                            if (parts.Length == 6)
                            {
                                dataGridViewMatrix_VAN.Rows.Add(parts);
                            }
                        }
                    }

                    MessageBox.Show($"Загружено {lines.Length} записей");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // кнопка добавления записи
        private void buttonAdd_VAN_Click(object sender, EventArgs e)
        {
            // убедимся что колонки созданы
            if (dataGridViewMatrix_VAN.Columns.Count == 0)
            {
                CreateDataGridViewColumns();
            }

            // проверяем что все поля заполнены
            if (textBoxNumberP_VAN.Text == "" ||
                textBoxNumberK_VAN.Text == "" ||
                textBoxCountK_VAN.Text == "" ||
                textBoxFam_VAN.Text == "" ||
                textBoxCountCh_VAN.Text == "" ||
                textBoxCountD_VAN.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            // добавляем новую строку
            dataGridViewMatrix_VAN.Rows.Add(
                textBoxNumberP_VAN.Text,
                textBoxNumberK_VAN.Text,
                textBoxCountK_VAN.Text,
                textBoxFam_VAN.Text,
                textBoxCountCh_VAN.Text,
                textBoxCountD_VAN.Text
            );

            // очищаем поля ввода
            textBoxNumberP_VAN.Text = "";
            textBoxNumberK_VAN.Text = "";
            textBoxCountK_VAN.Text = "";
            textBoxFam_VAN.Text = "";
            textBoxCountCh_VAN.Text = "";
            textBoxCountD_VAN.Text = "";

            MessageBox.Show("Добавлено!");
        }

        // кнопка сортировки
        private void buttonSort_VAN_Click(object sender, EventArgs e)
        {
            try
            {
                // проверяем есть ли колонки
                if (dataGridViewMatrix_VAN.Columns.Count == 0)
                {
                    MessageBox.Show("Сначала создайте колонки таблицы!");
                    return;
                }

                int colNum = int.Parse(textBoxSort_VAN.Text);
                if (colNum >= 0 && colNum < dataGridViewMatrix_VAN.Columns.Count)
                {
                    dataGridViewMatrix_VAN.Sort(dataGridViewMatrix_VAN.Columns[colNum],
                        ListSortDirection.Ascending);
                }
                else
                {
                    MessageBox.Show($"Введите число от 0 до {dataGridViewMatrix_VAN.Columns.Count - 1}");
                }
            }
            catch
            {
                MessageBox.Show($"Введите число от 0 до {dataGridViewMatrix_VAN.Columns.Count - 1}");
            }
        }

        // кнопка сохранения
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //проверяем есть ли данные для сохранения
                if (dataGridViewMatrix_VAN.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для сохранения!");
                    return;
                }

                // сохраняем данные в файл
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < dataGridViewMatrix_VAN.Rows.Count - 1; i++)
                    {
                        string line = "";
                        for (int j = 0; j < dataGridViewMatrix_VAN.Columns.Count; j++)
                        {
                            line += dataGridViewMatrix_VAN.Rows[i].Cells[j].Value;
                            if (j < dataGridViewMatrix_VAN.Columns.Count - 1) line += ";";
                        }
                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show("Данные сохранены в файл!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        // кнопка диаграммы
        private void buttonDiag_VAN_Click(object sender, EventArgs e)
        {
            new FormDiagram().ShowDialog();
        }

        // кнопка статистики
        private void buttonStat_VAN_Click(object sender, EventArgs e)
        {
            new FormStatistics().ShowDialog();
        }

        // кнопка помощи
        private void buttonHelp_VAN_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        // кнопка очистки таблицы
        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix_VAN.Rows.Clear();
            MessageBox.Show("Таблица очищена");
        }
    }
}