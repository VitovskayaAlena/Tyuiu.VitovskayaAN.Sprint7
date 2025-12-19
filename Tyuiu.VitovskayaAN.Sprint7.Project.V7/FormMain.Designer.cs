namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop_VAN = new Panel();
            groupBoxSort_VAN = new GroupBox();
            buttonSort_VAN = new Button();
            textBoxSort_VAN = new TextBox();
            labelSort_VAN = new Label();
            buttonStatistics_VAN = new Button();
            buttonDiagram_VAN = new Button();
            buttonHelp_VAN = new Button();
            panelFill_VAN = new Panel();
            dataGridViewMatrix_VAN = new DataGridView();
            panelRight_VAN = new Panel();
            groupBoxAdd_VAN = new GroupBox();
            buttonClear_VAN = new Button();
            buttonSave_VAN = new Button();
            buttonLoad_VAN = new Button();
            textBoxFam_VAN = new TextBox();
            labelFam_VAN = new Label();
            textBoxCountD_VAN = new TextBox();
            textBoxCountCh_VAN = new TextBox();
            textBoxCountK_VAN = new TextBox();
            textBoxNumberK_VAN = new TextBox();
            textBoxNumberP_VAN = new TextBox();
            buttonAdd_VAN = new Button();
            labelCountD_VAN = new Label();
            labelCountCh_VAN = new Label();
            labelCountK_VAN = new Label();
            labelNumberK_VAN = new Label();
            labelNumberP_VAN = new Label();
            openFileDialog_VAN = new OpenFileDialog();
            saveFileDialog_VAN = new SaveFileDialog();
            toolTip_VAN = new ToolTip(components);
            panelTop_VAN.SuspendLayout();
            groupBoxSort_VAN.SuspendLayout();
            panelFill_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VAN).BeginInit();
            panelRight_VAN.SuspendLayout();
            groupBoxAdd_VAN.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_VAN
            // 
            panelTop_VAN.Controls.Add(groupBoxSort_VAN);
            panelTop_VAN.Controls.Add(buttonStatistics_VAN);
            panelTop_VAN.Controls.Add(buttonDiagram_VAN);
            panelTop_VAN.Controls.Add(buttonHelp_VAN);
            panelTop_VAN.Dock = DockStyle.Top;
            panelTop_VAN.Location = new Point(0, 0);
            panelTop_VAN.Name = "panelTop_VAN";
            panelTop_VAN.Size = new Size(1864, 200);
            panelTop_VAN.TabIndex = 0;
            // 
            // groupBoxSort_VAN
            // 
            groupBoxSort_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSort_VAN.BackColor = Color.Linen;
            groupBoxSort_VAN.Controls.Add(buttonSort_VAN);
            groupBoxSort_VAN.Controls.Add(textBoxSort_VAN);
            groupBoxSort_VAN.Controls.Add(labelSort_VAN);
            groupBoxSort_VAN.Location = new Point(727, 0);
            groupBoxSort_VAN.Name = "groupBoxSort_VAN";
            groupBoxSort_VAN.Size = new Size(1137, 200);
            groupBoxSort_VAN.TabIndex = 3;
            groupBoxSort_VAN.TabStop = false;
            groupBoxSort_VAN.Text = "Сортировка:";
            // 
            // buttonSort_VAN
            // 
            buttonSort_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSort_VAN.BackColor = Color.PeachPuff;
            buttonSort_VAN.Location = new Point(848, 108);
            buttonSort_VAN.Name = "buttonSort_VAN";
            buttonSort_VAN.Size = new Size(238, 57);
            buttonSort_VAN.TabIndex = 2;
            buttonSort_VAN.Text = "Сортировать";
            toolTip_VAN.SetToolTip(buttonSort_VAN, "Сортировка по найденному столбцу");
            buttonSort_VAN.UseVisualStyleBackColor = false;
            buttonSort_VAN.Click += buttonSort_VAN_Click;
            // 
            // textBoxSort_VAN
            // 
            textBoxSort_VAN.Location = new Point(463, 66);
            textBoxSort_VAN.Multiline = true;
            textBoxSort_VAN.Name = "textBoxSort_VAN";
            textBoxSort_VAN.Size = new Size(75, 44);
            textBoxSort_VAN.TabIndex = 1;
            // 
            // labelSort_VAN
            // 
            labelSort_VAN.AutoSize = true;
            labelSort_VAN.Location = new Point(24, 78);
            labelSort_VAN.Name = "labelSort_VAN";
            labelSort_VAN.Size = new Size(410, 32);
            labelSort_VAN.TabIndex = 0;
            labelSort_VAN.Text = "Сортировка по номеру столбца с 0:";
            // 
            // buttonStatistics_VAN
            // 
            buttonStatistics_VAN.BackColor = Color.Linen;
            buttonStatistics_VAN.Location = new Point(35, 51);
            buttonStatistics_VAN.Name = "buttonStatistics_VAN";
            buttonStatistics_VAN.Size = new Size(183, 99);
            buttonStatistics_VAN.TabIndex = 2;
            buttonStatistics_VAN.Text = "Статистика";
            toolTip_VAN.SetToolTip(buttonStatistics_VAN, "Просмотр статистики, поиск, фильтрация и сортировка");
            buttonStatistics_VAN.UseVisualStyleBackColor = false;
            buttonStatistics_VAN.Click += buttonStat_VAN_Click;
            // 
            // buttonDiagram_VAN
            // 
            buttonDiagram_VAN.BackColor = Color.Linen;
            buttonDiagram_VAN.Location = new Point(258, 51);
            buttonDiagram_VAN.Name = "buttonDiagram_VAN";
            buttonDiagram_VAN.Size = new Size(183, 99);
            buttonDiagram_VAN.TabIndex = 1;
            buttonDiagram_VAN.Text = "Диаграмма";
            toolTip_VAN.SetToolTip(buttonDiagram_VAN, "Просмотр диаграммы по таблице");
            buttonDiagram_VAN.UseVisualStyleBackColor = false;
            buttonDiagram_VAN.Click += buttonDiag_VAN_Click;
            // 
            // buttonHelp_VAN
            // 
            buttonHelp_VAN.BackColor = Color.Linen;
            buttonHelp_VAN.Cursor = Cursors.Hand;
            buttonHelp_VAN.ForeColor = Color.Silver;
            buttonHelp_VAN.Image = (Image)resources.GetObject("buttonHelp_VAN.Image");
            buttonHelp_VAN.Location = new Point(574, 36);
            buttonHelp_VAN.Name = "buttonHelp_VAN";
            buttonHelp_VAN.Size = new Size(129, 129);
            buttonHelp_VAN.TabIndex = 0;
            toolTip_VAN.SetToolTip(buttonHelp_VAN, "Сведения о программе");
            buttonHelp_VAN.UseVisualStyleBackColor = false;
            buttonHelp_VAN.Click += buttonHelp_VAN_Click;
            // 
            // panelFill_VAN
            // 
            panelFill_VAN.Controls.Add(dataGridViewMatrix_VAN);
            panelFill_VAN.Controls.Add(panelRight_VAN);
            panelFill_VAN.Dock = DockStyle.Fill;
            panelFill_VAN.Location = new Point(0, 200);
            panelFill_VAN.Name = "panelFill_VAN";
            panelFill_VAN.Size = new Size(1864, 684);
            panelFill_VAN.TabIndex = 1;
            // 
            // dataGridViewMatrix_VAN
            // 
            dataGridViewMatrix_VAN.AllowUserToOrderColumns = true;
            dataGridViewMatrix_VAN.AllowUserToResizeColumns = false;
            dataGridViewMatrix_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMatrix_VAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix_VAN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMatrix_VAN.BackgroundColor = Color.PeachPuff;
            dataGridViewMatrix_VAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMatrix_VAN.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMatrix_VAN.Location = new Point(727, 0);
            dataGridViewMatrix_VAN.Name = "dataGridViewMatrix_VAN";
            dataGridViewMatrix_VAN.RowHeadersVisible = false;
            dataGridViewMatrix_VAN.RowHeadersWidth = 82;
            dataGridViewMatrix_VAN.ScrollBars = ScrollBars.Vertical;
            dataGridViewMatrix_VAN.Size = new Size(1137, 684);
            dataGridViewMatrix_VAN.TabIndex = 0;
            // 
            // panelRight_VAN
            // 
            panelRight_VAN.Controls.Add(groupBoxAdd_VAN);
            panelRight_VAN.Dock = DockStyle.Left;
            panelRight_VAN.Location = new Point(0, 0);
            panelRight_VAN.Name = "panelRight_VAN";
            panelRight_VAN.Size = new Size(727, 684);
            panelRight_VAN.TabIndex = 0;
            // 
            // groupBoxAdd_VAN
            // 
            groupBoxAdd_VAN.BackColor = Color.Linen;
            groupBoxAdd_VAN.Controls.Add(buttonClear_VAN);
            groupBoxAdd_VAN.Controls.Add(buttonSave_VAN);
            groupBoxAdd_VAN.Controls.Add(buttonLoad_VAN);
            groupBoxAdd_VAN.Controls.Add(textBoxFam_VAN);
            groupBoxAdd_VAN.Controls.Add(labelFam_VAN);
            groupBoxAdd_VAN.Controls.Add(textBoxCountD_VAN);
            groupBoxAdd_VAN.Controls.Add(textBoxCountCh_VAN);
            groupBoxAdd_VAN.Controls.Add(textBoxCountK_VAN);
            groupBoxAdd_VAN.Controls.Add(textBoxNumberK_VAN);
            groupBoxAdd_VAN.Controls.Add(textBoxNumberP_VAN);
            groupBoxAdd_VAN.Controls.Add(buttonAdd_VAN);
            groupBoxAdd_VAN.Controls.Add(labelCountD_VAN);
            groupBoxAdd_VAN.Controls.Add(labelCountCh_VAN);
            groupBoxAdd_VAN.Controls.Add(labelCountK_VAN);
            groupBoxAdd_VAN.Controls.Add(labelNumberK_VAN);
            groupBoxAdd_VAN.Controls.Add(labelNumberP_VAN);
            groupBoxAdd_VAN.Dock = DockStyle.Fill;
            groupBoxAdd_VAN.Location = new Point(0, 0);
            groupBoxAdd_VAN.Name = "groupBoxAdd_VAN";
            groupBoxAdd_VAN.Size = new Size(727, 684);
            groupBoxAdd_VAN.TabIndex = 0;
            groupBoxAdd_VAN.TabStop = false;
            groupBoxAdd_VAN.Text = "Добавить нового пользователя:";
            // 
            // buttonClear_VAN
            // 
            buttonClear_VAN.BackColor = Color.PeachPuff;
            buttonClear_VAN.Location = new Point(269, 542);
            buttonClear_VAN.Name = "buttonClear_VAN";
            buttonClear_VAN.Size = new Size(204, 105);
            buttonClear_VAN.TabIndex = 19;
            buttonClear_VAN.Text = "Очистить таблицу";
            toolTip_VAN.SetToolTip(buttonClear_VAN, "Очищает данные в таблице");
            buttonClear_VAN.UseVisualStyleBackColor = false;
            buttonClear_VAN.Click += buttonClear_Click;
            // 
            // buttonSave_VAN
            // 
            buttonSave_VAN.Anchor = AnchorStyles.Bottom;
            buttonSave_VAN.BackColor = Color.PeachPuff;
            buttonSave_VAN.Location = new Point(499, 542);
            buttonSave_VAN.Name = "buttonSave_VAN";
            buttonSave_VAN.Size = new Size(204, 105);
            buttonSave_VAN.TabIndex = 18;
            buttonSave_VAN.Text = "Сохранить";
            toolTip_VAN.SetToolTip(buttonSave_VAN, "Сохранить данные из таблицы в файл");
            buttonSave_VAN.UseVisualStyleBackColor = false;
            buttonSave_VAN.Click += buttonSave_Click;
            // 
            // buttonLoad_VAN
            // 
            buttonLoad_VAN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLoad_VAN.BackColor = Color.PeachPuff;
            buttonLoad_VAN.Location = new Point(36, 542);
            buttonLoad_VAN.Name = "buttonLoad_VAN";
            buttonLoad_VAN.Size = new Size(204, 105);
            buttonLoad_VAN.TabIndex = 15;
            buttonLoad_VAN.Text = "Загрузить файл";
            toolTip_VAN.SetToolTip(buttonLoad_VAN, "Выбрать и загрузить файл");
            buttonLoad_VAN.UseVisualStyleBackColor = false;
            buttonLoad_VAN.Click += buttonLoad_Click;
            // 
            // textBoxFam_VAN
            // 
            textBoxFam_VAN.Location = new Point(468, 218);
            textBoxFam_VAN.Name = "textBoxFam_VAN";
            textBoxFam_VAN.Size = new Size(203, 39);
            textBoxFam_VAN.TabIndex = 17;
            // 
            // labelFam_VAN
            // 
            labelFam_VAN.AutoSize = true;
            labelFam_VAN.Location = new Point(36, 225);
            labelFam_VAN.Name = "labelFam_VAN";
            labelFam_VAN.Size = new Size(341, 32);
            labelFam_VAN.TabIndex = 16;
            labelFam_VAN.Text = "Фамилия квартиросъёмщика:";
            // 
            // textBoxCountD_VAN
            // 
            textBoxCountD_VAN.Location = new Point(468, 337);
            textBoxCountD_VAN.Name = "textBoxCountD_VAN";
            textBoxCountD_VAN.Size = new Size(142, 39);
            textBoxCountD_VAN.TabIndex = 13;
            // 
            // textBoxCountCh_VAN
            // 
            textBoxCountCh_VAN.Location = new Point(468, 279);
            textBoxCountCh_VAN.Name = "textBoxCountCh_VAN";
            textBoxCountCh_VAN.Size = new Size(142, 39);
            textBoxCountCh_VAN.TabIndex = 12;
            // 
            // textBoxCountK_VAN
            // 
            textBoxCountK_VAN.Location = new Point(468, 160);
            textBoxCountK_VAN.Name = "textBoxCountK_VAN";
            textBoxCountK_VAN.Size = new Size(142, 39);
            textBoxCountK_VAN.TabIndex = 10;
            // 
            // textBoxNumberK_VAN
            // 
            textBoxNumberK_VAN.Location = new Point(468, 100);
            textBoxNumberK_VAN.Name = "textBoxNumberK_VAN";
            textBoxNumberK_VAN.Size = new Size(142, 39);
            textBoxNumberK_VAN.TabIndex = 9;
            // 
            // textBoxNumberP_VAN
            // 
            textBoxNumberP_VAN.Location = new Point(468, 45);
            textBoxNumberP_VAN.Name = "textBoxNumberP_VAN";
            textBoxNumberP_VAN.Size = new Size(142, 39);
            textBoxNumberP_VAN.TabIndex = 8;
            // 
            // buttonAdd_VAN
            // 
            buttonAdd_VAN.BackColor = Color.PeachPuff;
            buttonAdd_VAN.Location = new Point(458, 416);
            buttonAdd_VAN.Name = "buttonAdd_VAN";
            buttonAdd_VAN.Size = new Size(245, 75);
            buttonAdd_VAN.TabIndex = 7;
            buttonAdd_VAN.Text = "Добавить пользователя";
            toolTip_VAN.SetToolTip(buttonAdd_VAN, "Добавляет в таблицу данные жильца");
            buttonAdd_VAN.UseVisualStyleBackColor = false;
            buttonAdd_VAN.Click += buttonAdd_VAN_Click;
            // 
            // labelCountD_VAN
            // 
            labelCountD_VAN.AutoSize = true;
            labelCountD_VAN.Location = new Point(35, 344);
            labelCountD_VAN.Name = "labelCountD_VAN";
            labelCountD_VAN.Size = new Size(312, 32);
            labelCountD_VAN.TabIndex = 5;
            labelCountD_VAN.Text = "Количество детей в семье:";
            // 
            // labelCountCh_VAN
            // 
            labelCountCh_VAN.AutoSize = true;
            labelCountCh_VAN.Location = new Point(36, 286);
            labelCountCh_VAN.Name = "labelCountCh_VAN";
            labelCountCh_VAN.Size = new Size(311, 32);
            labelCountCh_VAN.TabIndex = 4;
            labelCountCh_VAN.Text = "Количество членов семьи:";
            // 
            // labelCountK_VAN
            // 
            labelCountK_VAN.AutoSize = true;
            labelCountK_VAN.Location = new Point(36, 167);
            labelCountK_VAN.Name = "labelCountK_VAN";
            labelCountK_VAN.Size = new Size(235, 32);
            labelCountK_VAN.TabIndex = 2;
            labelCountK_VAN.Text = "Количество комнат:";
            // 
            // labelNumberK_VAN
            // 
            labelNumberK_VAN.AutoSize = true;
            labelNumberK_VAN.Location = new Point(36, 107);
            labelNumberK_VAN.Name = "labelNumberK_VAN";
            labelNumberK_VAN.Size = new Size(207, 32);
            labelNumberK_VAN.TabIndex = 1;
            labelNumberK_VAN.Text = "Номер квартиры:";
            // 
            // labelNumberP_VAN
            // 
            labelNumberP_VAN.AutoSize = true;
            labelNumberP_VAN.Location = new Point(36, 52);
            labelNumberP_VAN.Name = "labelNumberP_VAN";
            labelNumberP_VAN.Size = new Size(205, 32);
            labelNumberP_VAN.TabIndex = 0;
            labelNumberP_VAN.Text = "Номер подъезда:";
            // 
            // openFileDialog_VAN
            // 
            openFileDialog_VAN.FileName = "openFileDialog_VAN";
            // 
            // toolTip_VAN
            // 
            toolTip_VAN.ToolTipIcon = ToolTipIcon.Info;
            toolTip_VAN.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1864, 884);
            Controls.Add(panelFill_VAN);
            Controls.Add(panelTop_VAN);
            MinimumSize = new Size(1890, 955);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Project | Вариант 7 | Витовская А.Н.";
            panelTop_VAN.ResumeLayout(false);
            groupBoxSort_VAN.ResumeLayout(false);
            groupBoxSort_VAN.PerformLayout();
            panelFill_VAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VAN).EndInit();
            panelRight_VAN.ResumeLayout(false);
            groupBoxAdd_VAN.ResumeLayout(false);
            groupBoxAdd_VAN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_VAN;
        private Panel panelFill_VAN;
        private Panel panelRight_VAN;
        private Button buttonHelp_VAN;
        private Button buttonStatistics_VAN;
        private Button buttonDiagram_VAN;
        private GroupBox groupBoxAdd_VAN;
        private GroupBox groupBoxSort_VAN;
        private Button buttonSort_VAN;
        private TextBox textBoxSort_VAN;
        private Label labelSort_VAN;
        private Label labelNumberP_VAN;
        private Label labelCountD_VAN;
        private Label labelCountCh_VAN;
        private Label labelCountK_VAN;
        private Label labelNumberK_VAN;
        private TextBox textBoxCountD_VAN;
        private TextBox textBoxCountCh_VAN;
        private TextBox textBoxCountK_VAN;
        private TextBox textBoxNumberK_VAN;
        private TextBox textBoxNumberP_VAN;
        private Button buttonAdd_VAN;
        private DataGridView dataGridViewMatrix_VAN;
        private OpenFileDialog openFileDialog_VAN;
        private SaveFileDialog saveFileDialog_VAN;
        private ToolTip toolTip_VAN;
        private Button buttonLoad_VAN;
        private TextBox textBoxFam_VAN;
        private Label labelFam_VAN;
        private Button buttonSave_VAN;
        private Button buttonClear_VAN;
    }
}
