using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7
{
    public partial class FormDiagram : Form
    {
        public FormDiagram()
        {
            InitializeComponent();
            LoadData(); // загружаем данные сразу
        }

        // загрузка данных из файла
        private void LoadData()
        {
            string filePath = @"C:\DataSprint7\InPutFileProjectV7.csv";

            // читаем все строки
            string[] lines = File.ReadAllLines(filePath);

            // очищаем таблицу
            dataGridViewMatrix_VAN.Columns.Clear();
            dataGridViewMatrix_VAN.Rows.Clear();

            // создаем 6 колонок (как в файле)
            dataGridViewMatrix_VAN.ColumnCount = 6;
            dataGridViewMatrix_VAN.Columns[0].HeaderText = "Подъезд";
            dataGridViewMatrix_VAN.Columns[1].HeaderText = "Квартира";
            dataGridViewMatrix_VAN.Columns[2].HeaderText = "Комнаты";
            dataGridViewMatrix_VAN.Columns[3].HeaderText = "Фамилия";
            dataGridViewMatrix_VAN.Columns[4].HeaderText = "Члены семьи";
            dataGridViewMatrix_VAN.Columns[5].HeaderText = "Дети";

            // заполняем таблицу
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                dataGridViewMatrix_VAN.Rows.Add(parts);
            }

            dataGridViewMatrix_VAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            int totalWidth = dataGridViewMatrix_VAN.ClientSize.Width;

            // процентное соотношение
            dataGridViewMatrix_VAN.Columns[0].Width = (int)(totalWidth * 0.15); // 15%
            dataGridViewMatrix_VAN.Columns[1].Width = (int)(totalWidth * 0.15); // 15%
            dataGridViewMatrix_VAN.Columns[2].Width = (int)(totalWidth * 0.15); // 15%
            dataGridViewMatrix_VAN.Columns[3].Width = (int)(totalWidth * 0.25); // 25%
            dataGridViewMatrix_VAN.Columns[4].Width = (int)(totalWidth * 0.15); // 15%
            dataGridViewMatrix_VAN.Columns[5].Width = (int)(totalWidth * 0.15); // 15%


        }

        // диаграмма "Комнаты"
        private void buttonCountK_VAN_Click(object sender, EventArgs e)
        {
            BuildDiagram(2, "Комнаты");
        }

        // диаграмма "Члены семьи"
        private void buttonCountCh_VAN_Click(object sender, EventArgs e)
        {
            BuildDiagram(4, "Члены семьи");
        }

        // диаграмма "Дети"
        private void buttonCountD_VAN_Click(object sender, EventArgs e)
        {
            BuildDiagram(5, "Дети");
        }

        // строим диаграмму
        private void BuildDiagram(int columnIndex, string title)
        {
            chartDiag_VAN.Series.Clear();

            Series series = chartDiag_VAN.Series.Add("Данные");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;

            // Заголовок диаграммы
            this.Text = title;

            // создаем словарь для подсчета: значение, сколько раз встречается
            var counts = new Dictionary<int, int>();

            for (int i = 0; i < dataGridViewMatrix_VAN.Rows.Count - 1; i++)
            {
                // берем значение из нужной колонки текущей строки
                // ? если Value = null, вернет null
                // ?? если слева null, вернет "0"
                string valueStr = dataGridViewMatrix_VAN.Rows[i].Cells[columnIndex].Value?.ToString() ?? "0";

                // пробуем преобразовать строку в число
                if (int.TryParse(valueStr, out int value))
                {
                    // если такое значение уже есть в словаре увеличиваем счетчик
                    if (counts.ContainsKey(value))
                        counts[value]++; // уже было такое значение +1
                    else
                        counts[value] = 1; // новое значение начинаем с 1
                }
            }

            foreach (var item in counts)
            {
                // (значение, сколько раз встречается)
                series.Points.AddXY(item.Key.ToString(), item.Value);
            }
        }
    }
}