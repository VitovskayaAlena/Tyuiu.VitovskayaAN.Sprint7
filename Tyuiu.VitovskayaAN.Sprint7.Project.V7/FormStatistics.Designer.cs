namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7
{
    partial class FormStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop_VAN = new Panel();
            groupBox_Sort_VAN = new GroupBox();
            textBoxSort_VAN = new TextBox();
            labelSort_VAN = new Label();
            buttonSort_VAN = new Button();
            groupBoxFiltr_VAN = new GroupBox();
            textBoxFiltr_VAN = new TextBox();
            buttonSbros_VAN = new Button();
            buttonFiltr_VAN = new Button();
            groupBoxPoisk_VAN = new GroupBox();
            textBoxPoisk_VAN = new TextBox();
            buttonPoisk_VAN = new Button();
            panelLeft_VAN = new Panel();
            groupBoxSort_VAN = new GroupBox();
            textBoxMin_VAN = new TextBox();
            textBoxMax_VAN = new TextBox();
            textBoxCountD_VAN = new TextBox();
            textBoxCountCh_VAN = new TextBox();
            textBoxCountK_VAN = new TextBox();
            labelMin_VAN = new Label();
            labelMax_VAN = new Label();
            labelCountD_VAN = new Label();
            labelCountCh_VAN = new Label();
            labelCountK_VAN = new Label();
            panelRight_VAN = new Panel();
            dataGridViewMatrix_VAN = new DataGridView();
            toolTip_VAN = new ToolTip(components);
            panelTop_VAN.SuspendLayout();
            groupBox_Sort_VAN.SuspendLayout();
            groupBoxFiltr_VAN.SuspendLayout();
            groupBoxPoisk_VAN.SuspendLayout();
            panelLeft_VAN.SuspendLayout();
            groupBoxSort_VAN.SuspendLayout();
            panelRight_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VAN).BeginInit();
            SuspendLayout();
            // 
            // panelTop_VAN
            // 
            panelTop_VAN.BackColor = Color.PeachPuff;
            panelTop_VAN.Controls.Add(groupBox_Sort_VAN);
            panelTop_VAN.Controls.Add(groupBoxFiltr_VAN);
            panelTop_VAN.Controls.Add(groupBoxPoisk_VAN);
            panelTop_VAN.Dock = DockStyle.Top;
            panelTop_VAN.Location = new Point(0, 0);
            panelTop_VAN.Name = "panelTop_VAN";
            panelTop_VAN.Size = new Size(1778, 230);
            panelTop_VAN.TabIndex = 0;
            // 
            // groupBox_Sort_VAN
            // 
            groupBox_Sort_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox_Sort_VAN.Controls.Add(textBoxSort_VAN);
            groupBox_Sort_VAN.Controls.Add(labelSort_VAN);
            groupBox_Sort_VAN.Controls.Add(buttonSort_VAN);
            groupBox_Sort_VAN.Location = new Point(1178, 12);
            groupBox_Sort_VAN.Name = "groupBox_Sort_VAN";
            groupBox_Sort_VAN.Size = new Size(588, 215);
            groupBox_Sort_VAN.TabIndex = 2;
            groupBox_Sort_VAN.TabStop = false;
            groupBox_Sort_VAN.Text = "Сортировка:";
            // 
            // textBoxSort_VAN
            // 
            textBoxSort_VAN.Location = new Point(469, 75);
            textBoxSort_VAN.Multiline = true;
            textBoxSort_VAN.Name = "textBoxSort_VAN";
            textBoxSort_VAN.Size = new Size(61, 50);
            textBoxSort_VAN.TabIndex = 2;
            // 
            // labelSort_VAN
            // 
            labelSort_VAN.AutoSize = true;
            labelSort_VAN.Location = new Point(6, 91);
            labelSort_VAN.Name = "labelSort_VAN";
            labelSort_VAN.Size = new Size(420, 32);
            labelSort_VAN.TabIndex = 1;
            labelSort_VAN.Text = "Сортировать по номеру столбца с 0:";
            // 
            // buttonSort_VAN
            // 
            buttonSort_VAN.BackColor = Color.Linen;
            buttonSort_VAN.Location = new Point(369, 151);
            buttonSort_VAN.Name = "buttonSort_VAN";
            buttonSort_VAN.Size = new Size(179, 46);
            buttonSort_VAN.TabIndex = 0;
            buttonSort_VAN.Text = "Сортировать";
            toolTip_VAN.SetToolTip(buttonSort_VAN, "Сортировка по выбранному столбцу");
            buttonSort_VAN.UseVisualStyleBackColor = false;
            buttonSort_VAN.Click += buttonSort_VAN_Click;
            // 
            // groupBoxFiltr_VAN
            // 
            groupBoxFiltr_VAN.Controls.Add(textBoxFiltr_VAN);
            groupBoxFiltr_VAN.Controls.Add(buttonSbros_VAN);
            groupBoxFiltr_VAN.Controls.Add(buttonFiltr_VAN);
            groupBoxFiltr_VAN.Location = new Point(594, 12);
            groupBoxFiltr_VAN.Name = "groupBoxFiltr_VAN";
            groupBoxFiltr_VAN.Size = new Size(578, 215);
            groupBoxFiltr_VAN.TabIndex = 1;
            groupBoxFiltr_VAN.TabStop = false;
            groupBoxFiltr_VAN.Text = "Фильтрация:";
            // 
            // textBoxFiltr_VAN
            // 
            textBoxFiltr_VAN.Location = new Point(28, 73);
            textBoxFiltr_VAN.Multiline = true;
            textBoxFiltr_VAN.Name = "textBoxFiltr_VAN";
            textBoxFiltr_VAN.Size = new Size(508, 52);
            textBoxFiltr_VAN.TabIndex = 2;
            // 
            // buttonSbros_VAN
            // 
            buttonSbros_VAN.BackColor = Color.Linen;
            buttonSbros_VAN.Location = new Point(6, 151);
            buttonSbros_VAN.Name = "buttonSbros_VAN";
            buttonSbros_VAN.Size = new Size(150, 46);
            buttonSbros_VAN.TabIndex = 1;
            buttonSbros_VAN.Text = "Сброс";
            toolTip_VAN.SetToolTip(buttonSbros_VAN, "Сброс фильтров");
            buttonSbros_VAN.UseVisualStyleBackColor = false;
            buttonSbros_VAN.Click += buttonSbros_VAN_Click;
            // 
            // buttonFiltr_VAN
            // 
            buttonFiltr_VAN.BackColor = Color.Linen;
            buttonFiltr_VAN.Location = new Point(406, 151);
            buttonFiltr_VAN.Name = "buttonFiltr_VAN";
            buttonFiltr_VAN.Size = new Size(150, 46);
            buttonFiltr_VAN.TabIndex = 0;
            buttonFiltr_VAN.Text = "Фильтр";
            toolTip_VAN.SetToolTip(buttonFiltr_VAN, "Поиск по таблице с фильтром");
            buttonFiltr_VAN.UseVisualStyleBackColor = false;
            buttonFiltr_VAN.Click += buttonFiltr_VAN_Click;
            // 
            // groupBoxPoisk_VAN
            // 
            groupBoxPoisk_VAN.Controls.Add(textBoxPoisk_VAN);
            groupBoxPoisk_VAN.Controls.Add(buttonPoisk_VAN);
            groupBoxPoisk_VAN.Location = new Point(12, 12);
            groupBoxPoisk_VAN.Name = "groupBoxPoisk_VAN";
            groupBoxPoisk_VAN.Size = new Size(576, 215);
            groupBoxPoisk_VAN.TabIndex = 0;
            groupBoxPoisk_VAN.TabStop = false;
            groupBoxPoisk_VAN.Text = "Поиск:";
            // 
            // textBoxPoisk_VAN
            // 
            textBoxPoisk_VAN.Location = new Point(20, 73);
            textBoxPoisk_VAN.Multiline = true;
            textBoxPoisk_VAN.Name = "textBoxPoisk_VAN";
            textBoxPoisk_VAN.Size = new Size(528, 52);
            textBoxPoisk_VAN.TabIndex = 1;
            // 
            // buttonPoisk_VAN
            // 
            buttonPoisk_VAN.BackColor = Color.Linen;
            buttonPoisk_VAN.Location = new Point(398, 151);
            buttonPoisk_VAN.Name = "buttonPoisk_VAN";
            buttonPoisk_VAN.Size = new Size(150, 46);
            buttonPoisk_VAN.TabIndex = 0;
            buttonPoisk_VAN.Text = "Найти";
            toolTip_VAN.SetToolTip(buttonPoisk_VAN, "Поиск по таблице ");
            buttonPoisk_VAN.UseVisualStyleBackColor = false;
            buttonPoisk_VAN.Click += buttonPoisk_VAN_Click;
            // 
            // panelLeft_VAN
            // 
            panelLeft_VAN.Controls.Add(groupBoxSort_VAN);
            panelLeft_VAN.Dock = DockStyle.Left;
            panelLeft_VAN.Location = new Point(0, 230);
            panelLeft_VAN.Name = "panelLeft_VAN";
            panelLeft_VAN.Size = new Size(759, 651);
            panelLeft_VAN.TabIndex = 1;
            // 
            // groupBoxSort_VAN
            // 
            groupBoxSort_VAN.BackColor = Color.Linen;
            groupBoxSort_VAN.Controls.Add(textBoxMin_VAN);
            groupBoxSort_VAN.Controls.Add(textBoxMax_VAN);
            groupBoxSort_VAN.Controls.Add(textBoxCountD_VAN);
            groupBoxSort_VAN.Controls.Add(textBoxCountCh_VAN);
            groupBoxSort_VAN.Controls.Add(textBoxCountK_VAN);
            groupBoxSort_VAN.Controls.Add(labelMin_VAN);
            groupBoxSort_VAN.Controls.Add(labelMax_VAN);
            groupBoxSort_VAN.Controls.Add(labelCountD_VAN);
            groupBoxSort_VAN.Controls.Add(labelCountCh_VAN);
            groupBoxSort_VAN.Controls.Add(labelCountK_VAN);
            groupBoxSort_VAN.Dock = DockStyle.Fill;
            groupBoxSort_VAN.Location = new Point(0, 0);
            groupBoxSort_VAN.Name = "groupBoxSort_VAN";
            groupBoxSort_VAN.Size = new Size(759, 651);
            groupBoxSort_VAN.TabIndex = 0;
            groupBoxSort_VAN.TabStop = false;
            groupBoxSort_VAN.Text = "Сортировка:";
            // 
            // textBoxMin_VAN
            // 
            textBoxMin_VAN.BackColor = SystemColors.Window;
            textBoxMin_VAN.Location = new Point(566, 562);
            textBoxMin_VAN.Name = "textBoxMin_VAN";
            textBoxMin_VAN.ReadOnly = true;
            textBoxMin_VAN.Size = new Size(85, 39);
            textBoxMin_VAN.TabIndex = 10;
            // 
            // textBoxMax_VAN
            // 
            textBoxMax_VAN.BackColor = SystemColors.Window;
            textBoxMax_VAN.Location = new Point(566, 462);
            textBoxMax_VAN.Name = "textBoxMax_VAN";
            textBoxMax_VAN.ReadOnly = true;
            textBoxMax_VAN.Size = new Size(85, 39);
            textBoxMax_VAN.TabIndex = 9;
            // 
            // textBoxCountD_VAN
            // 
            textBoxCountD_VAN.BackColor = SystemColors.Window;
            textBoxCountD_VAN.Location = new Point(566, 258);
            textBoxCountD_VAN.Name = "textBoxCountD_VAN";
            textBoxCountD_VAN.ReadOnly = true;
            textBoxCountD_VAN.Size = new Size(85, 39);
            textBoxCountD_VAN.TabIndex = 8;
            // 
            // textBoxCountCh_VAN
            // 
            textBoxCountCh_VAN.BackColor = SystemColors.Window;
            textBoxCountCh_VAN.Location = new Point(566, 157);
            textBoxCountCh_VAN.Name = "textBoxCountCh_VAN";
            textBoxCountCh_VAN.ReadOnly = true;
            textBoxCountCh_VAN.Size = new Size(85, 39);
            textBoxCountCh_VAN.TabIndex = 7;
            // 
            // textBoxCountK_VAN
            // 
            textBoxCountK_VAN.BackColor = SystemColors.Window;
            textBoxCountK_VAN.Location = new Point(566, 59);
            textBoxCountK_VAN.Name = "textBoxCountK_VAN";
            textBoxCountK_VAN.ReadOnly = true;
            textBoxCountK_VAN.Size = new Size(85, 39);
            textBoxCountK_VAN.TabIndex = 6;
            // 
            // labelMin_VAN
            // 
            labelMin_VAN.AutoSize = true;
            labelMin_VAN.Location = new Point(12, 569);
            labelMin_VAN.Name = "labelMin_VAN";
            labelMin_VAN.Size = new Size(460, 32);
            labelMin_VAN.TabIndex = 4;
            labelMin_VAN.Text = "Наименьшее количество членов семьи:";
            // 
            // labelMax_VAN
            // 
            labelMax_VAN.AutoSize = true;
            labelMax_VAN.Location = new Point(12, 469);
            labelMax_VAN.Name = "labelMax_VAN";
            labelMax_VAN.Size = new Size(457, 32);
            labelMax_VAN.TabIndex = 3;
            labelMax_VAN.Text = "Наибольшее количество членов семьи:";
            // 
            // labelCountD_VAN
            // 
            labelCountD_VAN.AutoSize = true;
            labelCountD_VAN.Location = new Point(6, 265);
            labelCountD_VAN.Name = "labelCountD_VAN";
            labelCountD_VAN.Size = new Size(219, 32);
            labelCountD_VAN.TabIndex = 2;
            labelCountD_VAN.Text = "Количество детей:";
            // 
            // labelCountCh_VAN
            // 
            labelCountCh_VAN.AutoSize = true;
            labelCountCh_VAN.Location = new Point(12, 164);
            labelCountCh_VAN.Name = "labelCountCh_VAN";
            labelCountCh_VAN.Size = new Size(311, 32);
            labelCountCh_VAN.TabIndex = 1;
            labelCountCh_VAN.Text = "Количество членов семьи:";
            // 
            // labelCountK_VAN
            // 
            labelCountK_VAN.AutoSize = true;
            labelCountK_VAN.Location = new Point(12, 66);
            labelCountK_VAN.Name = "labelCountK_VAN";
            labelCountK_VAN.Size = new Size(245, 32);
            labelCountK_VAN.TabIndex = 0;
            labelCountK_VAN.Text = "Количество квартир:";
            // 
            // panelRight_VAN
            // 
            panelRight_VAN.Controls.Add(dataGridViewMatrix_VAN);
            panelRight_VAN.Dock = DockStyle.Fill;
            panelRight_VAN.Location = new Point(759, 230);
            panelRight_VAN.Name = "panelRight_VAN";
            panelRight_VAN.Size = new Size(1019, 651);
            panelRight_VAN.TabIndex = 2;
            // 
            // dataGridViewMatrix_VAN
            // 
            dataGridViewMatrix_VAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix_VAN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMatrix_VAN.BackgroundColor = Color.Linen;
            dataGridViewMatrix_VAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_VAN.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMatrix_VAN.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMatrix_VAN.Dock = DockStyle.Fill;
            dataGridViewMatrix_VAN.Location = new Point(0, 0);
            dataGridViewMatrix_VAN.Name = "dataGridViewMatrix_VAN";
            dataGridViewMatrix_VAN.RowHeadersVisible = false;
            dataGridViewMatrix_VAN.RowHeadersWidth = 82;
            dataGridViewMatrix_VAN.Size = new Size(1019, 651);
            dataGridViewMatrix_VAN.TabIndex = 0;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 881);
            Controls.Add(panelRight_VAN);
            Controls.Add(panelLeft_VAN);
            Controls.Add(panelTop_VAN);
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += FormStatistics_Load;
            panelTop_VAN.ResumeLayout(false);
            groupBox_Sort_VAN.ResumeLayout(false);
            groupBox_Sort_VAN.PerformLayout();
            groupBoxFiltr_VAN.ResumeLayout(false);
            groupBoxFiltr_VAN.PerformLayout();
            groupBoxPoisk_VAN.ResumeLayout(false);
            groupBoxPoisk_VAN.PerformLayout();
            panelLeft_VAN.ResumeLayout(false);
            groupBoxSort_VAN.ResumeLayout(false);
            groupBoxSort_VAN.PerformLayout();
            panelRight_VAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_VAN;
        private Panel panelLeft_VAN;
        private Panel panelRight_VAN;
        private GroupBox groupBox_Sort_VAN;
        private Button buttonSort_VAN;
        private GroupBox groupBoxFiltr_VAN;
        private Button buttonFiltr_VAN;
        private GroupBox groupBoxPoisk_VAN;
        private Button buttonPoisk_VAN;
        private Label labelSort_VAN;
        private Button buttonSbros_VAN;
        private TextBox textBoxSort_VAN;
        private TextBox textBoxFiltr_VAN;
        private TextBox textBoxPoisk_VAN;
        private GroupBox groupBoxSort_VAN;
        private DataGridView dataGridViewMatrix_VAN;
        private Label labelCountK_VAN;
        private Label labelMin_VAN;
        private Label labelMax_VAN;
        private Label labelCountD_VAN;
        private Label labelCountCh_VAN;
        private TextBox textBoxCountK_VAN;
        private TextBox textBoxMin_VAN;
        private TextBox textBoxMax_VAN;
        private TextBox textBoxCountD_VAN;
        private TextBox textBoxCountCh_VAN;
        private ToolTip toolTip_VAN;
    }
}