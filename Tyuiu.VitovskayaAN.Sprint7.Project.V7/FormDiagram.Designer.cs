namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7
{
    partial class FormDiagram
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelLeft_VAN = new Panel();
            dataGridViewMatrix_VAN = new DataGridView();
            panelRight_VAN = new Panel();
            chartDiag_VAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxDiag_VAN = new GroupBox();
            labelCountD_VAN = new Label();
            labelCountCh_VAN = new Label();
            labelCountK_VAN = new Label();
            buttonCountD_VAN = new Button();
            buttonCountCh_VAN = new Button();
            buttonCountK_VAN = new Button();
            toolTip_VAN = new ToolTip(components);
            panelLeft_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VAN).BeginInit();
            panelRight_VAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_VAN).BeginInit();
            groupBoxDiag_VAN.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft_VAN
            // 
            panelLeft_VAN.Controls.Add(dataGridViewMatrix_VAN);
            panelLeft_VAN.Dock = DockStyle.Fill;
            panelLeft_VAN.Location = new Point(0, 0);
            panelLeft_VAN.Name = "panelLeft_VAN";
            panelLeft_VAN.Size = new Size(1866, 919);
            panelLeft_VAN.TabIndex = 0;
            // 
            // dataGridViewMatrix_VAN
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMatrix_VAN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMatrix_VAN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMatrix_VAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix_VAN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMatrix_VAN.BackgroundColor = Color.Linen;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewMatrix_VAN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMatrix_VAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMatrix_VAN.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMatrix_VAN.Location = new Point(0, 0);
            dataGridViewMatrix_VAN.Name = "dataGridViewMatrix_VAN";
            dataGridViewMatrix_VAN.RowHeadersVisible = false;
            dataGridViewMatrix_VAN.RowHeadersWidth = 82;
            dataGridViewMatrix_VAN.ScrollBars = ScrollBars.Vertical;
            dataGridViewMatrix_VAN.Size = new Size(1866, 919);
            dataGridViewMatrix_VAN.TabIndex = 0;
            // 
            // panelRight_VAN
            // 
            panelRight_VAN.Controls.Add(chartDiag_VAN);
            panelRight_VAN.Controls.Add(groupBoxDiag_VAN);
            panelRight_VAN.Dock = DockStyle.Right;
            panelRight_VAN.Location = new Point(664, 0);
            panelRight_VAN.Name = "panelRight_VAN";
            panelRight_VAN.Size = new Size(1202, 919);
            panelRight_VAN.TabIndex = 1;
            // 
            // chartDiag_VAN
            // 
            chartDiag_VAN.BackColor = Color.PeachPuff;
            chartDiag_VAN.BorderlineColor = Color.PeachPuff;
            chartArea1.Name = "ChartArea_VAN";
            chartDiag_VAN.ChartAreas.Add(chartArea1);
            chartDiag_VAN.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag_VAN.Legends.Add(legend1);
            chartDiag_VAN.Location = new Point(0, 0);
            chartDiag_VAN.Name = "chartDiag_VAN";
            chartDiag_VAN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea_VAN";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_VAN.Series.Add(series1);
            chartDiag_VAN.Size = new Size(1202, 603);
            chartDiag_VAN.TabIndex = 1;
            // 
            // groupBoxDiag_VAN
            // 
            groupBoxDiag_VAN.BackColor = Color.PeachPuff;
            groupBoxDiag_VAN.Controls.Add(labelCountD_VAN);
            groupBoxDiag_VAN.Controls.Add(labelCountCh_VAN);
            groupBoxDiag_VAN.Controls.Add(labelCountK_VAN);
            groupBoxDiag_VAN.Controls.Add(buttonCountD_VAN);
            groupBoxDiag_VAN.Controls.Add(buttonCountCh_VAN);
            groupBoxDiag_VAN.Controls.Add(buttonCountK_VAN);
            groupBoxDiag_VAN.Dock = DockStyle.Bottom;
            groupBoxDiag_VAN.Location = new Point(0, 603);
            groupBoxDiag_VAN.Name = "groupBoxDiag_VAN";
            groupBoxDiag_VAN.Size = new Size(1202, 316);
            groupBoxDiag_VAN.TabIndex = 0;
            groupBoxDiag_VAN.TabStop = false;
            groupBoxDiag_VAN.Text = "Выбор диаграммы:";
            // 
            // labelCountD_VAN
            // 
            labelCountD_VAN.AutoSize = true;
            labelCountD_VAN.Location = new Point(18, 250);
            labelCountD_VAN.Name = "labelCountD_VAN";
            labelCountD_VAN.Size = new Size(341, 32);
            labelCountD_VAN.TabIndex = 5;
            labelCountD_VAN.Text = "По количеству детей в семье";
            // 
            // labelCountCh_VAN
            // 
            labelCountCh_VAN.AutoSize = true;
            labelCountCh_VAN.Location = new Point(18, 174);
            labelCountCh_VAN.Name = "labelCountCh_VAN";
            labelCountCh_VAN.Size = new Size(340, 32);
            labelCountCh_VAN.TabIndex = 4;
            labelCountCh_VAN.Text = "По количеству членов семьи";
            // 
            // labelCountK_VAN
            // 
            labelCountK_VAN.AutoSize = true;
            labelCountK_VAN.Location = new Point(18, 97);
            labelCountK_VAN.Name = "labelCountK_VAN";
            labelCountK_VAN.Size = new Size(393, 32);
            labelCountK_VAN.TabIndex = 3;
            labelCountK_VAN.Text = "По количеству комнат в квартире";
            // 
            // buttonCountD_VAN
            // 
            buttonCountD_VAN.BackColor = Color.Linen;
            buttonCountD_VAN.Location = new Point(534, 227);
            buttonCountD_VAN.Name = "buttonCountD_VAN";
            buttonCountD_VAN.Size = new Size(196, 55);
            buttonCountD_VAN.TabIndex = 2;
            buttonCountD_VAN.Text = "Показать";
            toolTip_VAN.SetToolTip(buttonCountD_VAN, "Показать диаграмму по количеству детей в семье");
            buttonCountD_VAN.UseVisualStyleBackColor = false;
            buttonCountD_VAN.Click += buttonCountD_VAN_Click;
            // 
            // buttonCountCh_VAN
            // 
            buttonCountCh_VAN.BackColor = Color.Linen;
            buttonCountCh_VAN.Location = new Point(534, 151);
            buttonCountCh_VAN.Name = "buttonCountCh_VAN";
            buttonCountCh_VAN.Size = new Size(196, 55);
            buttonCountCh_VAN.TabIndex = 1;
            buttonCountCh_VAN.Text = "Показать";
            toolTip_VAN.SetToolTip(buttonCountCh_VAN, "Показать диаграмму по количеству членов семьи");
            buttonCountCh_VAN.UseVisualStyleBackColor = false;
            buttonCountCh_VAN.Click += buttonCountCh_VAN_Click;
            // 
            // buttonCountK_VAN
            // 
            buttonCountK_VAN.BackColor = Color.Linen;
            buttonCountK_VAN.Location = new Point(534, 74);
            buttonCountK_VAN.Name = "buttonCountK_VAN";
            buttonCountK_VAN.Size = new Size(196, 55);
            buttonCountK_VAN.TabIndex = 0;
            buttonCountK_VAN.Text = "Показать";
            toolTip_VAN.SetToolTip(buttonCountK_VAN, "Показать диаграмму по количеству комнат в квартире");
            buttonCountK_VAN.UseVisualStyleBackColor = false;
            buttonCountK_VAN.Click += buttonCountK_VAN_Click;
            // 
            // FormDiagram
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1866, 919);
            Controls.Add(panelRight_VAN);
            Controls.Add(panelLeft_VAN);
            Name = "FormDiagram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Диаграммы";
            panelLeft_VAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_VAN).EndInit();
            panelRight_VAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_VAN).EndInit();
            groupBoxDiag_VAN.ResumeLayout(false);
            groupBoxDiag_VAN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft_VAN;
        private Panel panelRight_VAN;
        private DataGridView dataGridViewMatrix_VAN;
        private GroupBox groupBoxDiag_VAN;
        private Label labelCountD_VAN;
        private Label labelCountCh_VAN;
        private Label labelCountK_VAN;
        private Button buttonCountD_VAN;
        private Button buttonCountCh_VAN;
        private Button buttonCountK_VAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_VAN;
        private ToolTip toolTip_VAN;
    }
}