
namespace Tyuiu.PolyanskiyDE.Sprint6.Task3.V15
{
    partial class FormMain_PDE
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
            this.groupBoxTask_PDE = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_PDE = new System.Windows.Forms.DataGridView();
            this.buttonDone_PDE = new System.Windows.Forms.Button();
            this.buttonHelp_PDE = new System.Windows.Forms.Button();
            this.textBoxData_PDE = new System.Windows.Forms.TextBox();
            this.groupBoxTask_PDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PDE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PDE
            // 
            this.groupBoxTask_PDE.Controls.Add(this.textBoxData_PDE);
            this.groupBoxTask_PDE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PDE.Name = "groupBoxTask_PDE";
            this.groupBoxTask_PDE.Size = new System.Drawing.Size(379, 358);
            this.groupBoxTask_PDE.TabIndex = 0;
            this.groupBoxTask_PDE.TabStop = false;
            this.groupBoxTask_PDE.Text = "Условие";
            // 
            // dataGridViewResult_PDE
            // 
            this.dataGridViewResult_PDE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PDE.ColumnHeadersVisible = false;
            this.dataGridViewResult_PDE.Location = new System.Drawing.Point(397, 12);
            this.dataGridViewResult_PDE.Name = "dataGridViewResult_PDE";
            this.dataGridViewResult_PDE.RowHeadersVisible = false;
            this.dataGridViewResult_PDE.Size = new System.Drawing.Size(413, 324);
            this.dataGridViewResult_PDE.TabIndex = 1;
            // 
            // buttonDone_PDE
            // 
            this.buttonDone_PDE.Location = new System.Drawing.Point(699, 342);
            this.buttonDone_PDE.Name = "buttonDone_PDE";
            this.buttonDone_PDE.Size = new System.Drawing.Size(111, 28);
            this.buttonDone_PDE.TabIndex = 2;
            this.buttonDone_PDE.Text = "Выполнить";
            this.buttonDone_PDE.UseVisualStyleBackColor = true;
            this.buttonDone_PDE.Click += new System.EventHandler(this.buttonDone_PDE_Click);
            // 
            // buttonHelp_PDE
            // 
            this.buttonHelp_PDE.Location = new System.Drawing.Point(665, 342);
            this.buttonHelp_PDE.Name = "buttonHelp_PDE";
            this.buttonHelp_PDE.Size = new System.Drawing.Size(28, 28);
            this.buttonHelp_PDE.TabIndex = 3;
            this.buttonHelp_PDE.Text = "?";
            this.buttonHelp_PDE.UseVisualStyleBackColor = true;
            this.buttonHelp_PDE.Click += new System.EventHandler(this.buttonHelp_PDE_Click);
            // 
            // textBoxData_PDE
            // 
            this.textBoxData_PDE.Location = new System.Drawing.Point(6, 19);
            this.textBoxData_PDE.Multiline = true;
            this.textBoxData_PDE.Name = "textBoxData_PDE";
            this.textBoxData_PDE.ReadOnly = true;
            this.textBoxData_PDE.Size = new System.Drawing.Size(367, 333);
            this.textBoxData_PDE.TabIndex = 0;
            this.textBoxData_PDE.Text = "Дана матрица 5 на 5\r\n33  28  31  19   4\r\n 1  32  -3 -17 -12\r\n24 -19  26  31  -3\r\n" +
    "30 -16  29  28   8\r\n 30   5  11   7  32\r\nВыполнить сортировку по возрастаню в тр" +
    "етьем столбце\r\n\r\n";
            // 
            // FormMain_PDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 382);
            this.Controls.Add(this.buttonHelp_PDE);
            this.Controls.Add(this.buttonDone_PDE);
            this.Controls.Add(this.dataGridViewResult_PDE);
            this.Controls.Add(this.groupBoxTask_PDE);
            this.MaximizeBox = false;
            this.Name = "FormMain_PDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Таск 3 | Вариант 15 | Полянский Д. Э.";
            this.Load += new System.EventHandler(this.FormMain_PDE_Load);
            this.groupBoxTask_PDE.ResumeLayout(false);
            this.groupBoxTask_PDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PDE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PDE;
        private System.Windows.Forms.DataGridView dataGridViewResult_PDE;
        private System.Windows.Forms.Button buttonDone_PDE;
        private System.Windows.Forms.Button buttonHelp_PDE;
        private System.Windows.Forms.TextBox textBoxData_PDE;
    }
}

