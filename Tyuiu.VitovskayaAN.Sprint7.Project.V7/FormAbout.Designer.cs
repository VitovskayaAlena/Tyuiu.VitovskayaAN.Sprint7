namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAbout_VAN = new TextBox();
            buttonOK_VAN = new Button();
            SuspendLayout();
            // 
            // textBoxAbout_VAN
            // 
            textBoxAbout_VAN.Location = new Point(80, 32);
            textBoxAbout_VAN.Multiline = true;
            textBoxAbout_VAN.Name = "textBoxAbout_VAN";
            textBoxAbout_VAN.ReadOnly = true;
            textBoxAbout_VAN.Size = new Size(637, 331);
            textBoxAbout_VAN.TabIndex = 0;
            textBoxAbout_VAN.Text = resources.GetString("textBoxAbout_VAN.Text");
            textBoxAbout_VAN.TextChanged += this.textBoxAbout_VAN_TextChanged;
            // 
            // buttonOK_VAN
            // 
            buttonOK_VAN.Location = new Point(612, 392);
            buttonOK_VAN.Name = "buttonOK_VAN";
            buttonOK_VAN.Size = new Size(150, 46);
            buttonOK_VAN.TabIndex = 1;
            buttonOK_VAN.Text = "ОК";
            buttonOK_VAN.UseVisualStyleBackColor = true;
            buttonOK_VAN.Click += buttonOK_VAN_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOK_VAN);
            Controls.Add(textBoxAbout_VAN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_VAN;
        private Button buttonOK_VAN;
    }
}