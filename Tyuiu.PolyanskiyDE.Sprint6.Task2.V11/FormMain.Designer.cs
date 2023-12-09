
namespace Tyuiu.PolyanskiyDE.Sprint6.Task2.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_PDE));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_PDE = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_PDE = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_PDE = new System.Windows.Forms.GroupBox();
            this.textBoxStart_PDE = new System.Windows.Forms.TextBox();
            this.textBoxStop_PDE = new System.Windows.Forms.TextBox();
            this.labelStart_PDE = new System.Windows.Forms.Label();
            this.labelStop_PDE = new System.Windows.Forms.Label();
            this.buttonDone_PDE = new System.Windows.Forms.Button();
            this.buttonHelp_PDE = new System.Windows.Forms.Button();
            this.groupBoxResult_PDE = new System.Windows.Forms.GroupBox();
            this.labelResult_PDE = new System.Windows.Forms.Label();
            this.chartFunction_PDE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_PDE = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_PDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_PDE)).BeginInit();
            this.groupBoxInput_PDE.SuspendLayout();
            this.groupBoxResult_PDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PDE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PDE
            // 
            this.groupBoxTask_PDE.Controls.Add(this.pictureBoxTask_PDE);
            this.groupBoxTask_PDE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_PDE.Name = "groupBoxTask_PDE";
            this.groupBoxTask_PDE.Size = new System.Drawing.Size(643, 357);
            this.groupBoxTask_PDE.TabIndex = 0;
            this.groupBoxTask_PDE.TabStop = false;
            this.groupBoxTask_PDE.Text = "Условие";
            // 
            // pictureBoxTask_PDE
            // 
            this.pictureBoxTask_PDE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_PDE.Image")));
            this.pictureBoxTask_PDE.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxTask_PDE.Name = "pictureBoxTask_PDE";
            this.pictureBoxTask_PDE.Size = new System.Drawing.Size(630, 216);
            this.pictureBoxTask_PDE.TabIndex = 0;
            this.pictureBoxTask_PDE.TabStop = false;
            // 
            // groupBoxInput_PDE
            // 
            this.groupBoxInput_PDE.Controls.Add(this.labelStop_PDE);
            this.groupBoxInput_PDE.Controls.Add(this.labelStart_PDE);
            this.groupBoxInput_PDE.Controls.Add(this.textBoxStop_PDE);
            this.groupBoxInput_PDE.Controls.Add(this.textBoxStart_PDE);
            this.groupBoxInput_PDE.Location = new System.Drawing.Point(12, 375);
            this.groupBoxInput_PDE.Name = "groupBoxInput_PDE";
            this.groupBoxInput_PDE.Size = new System.Drawing.Size(288, 63);
            this.groupBoxInput_PDE.TabIndex = 1;
            this.groupBoxInput_PDE.TabStop = false;
            this.groupBoxInput_PDE.Text = "Ввод данных";
            // 
            // textBoxStart_PDE
            // 
            this.textBoxStart_PDE.Location = new System.Drawing.Point(6, 32);
            this.textBoxStart_PDE.Name = "textBoxStart_PDE";
            this.textBoxStart_PDE.Size = new System.Drawing.Size(134, 20);
            this.textBoxStart_PDE.TabIndex = 0;
            // 
            // textBoxStop_PDE
            // 
            this.textBoxStop_PDE.Location = new System.Drawing.Point(146, 32);
            this.textBoxStop_PDE.Name = "textBoxStop_PDE";
            this.textBoxStop_PDE.Size = new System.Drawing.Size(134, 20);
            this.textBoxStop_PDE.TabIndex = 0;
            // 
            // labelStart_PDE
            // 
            this.labelStart_PDE.AutoSize = true;
            this.labelStart_PDE.Location = new System.Drawing.Point(6, 16);
            this.labelStart_PDE.Name = "labelStart_PDE";
            this.labelStart_PDE.Size = new System.Drawing.Size(67, 13);
            this.labelStart_PDE.TabIndex = 1;
            this.labelStart_PDE.Text = "Старт шага:";
            // 
            // labelStop_PDE
            // 
            this.labelStop_PDE.AutoSize = true;
            this.labelStop_PDE.Location = new System.Drawing.Point(143, 16);
            this.labelStop_PDE.Name = "labelStop_PDE";
            this.labelStop_PDE.Size = new System.Drawing.Size(69, 13);
            this.labelStop_PDE.TabIndex = 1;
            this.labelStop_PDE.Text = "Конец шага:";
            // 
            // buttonDone_PDE
            // 
            this.buttonDone_PDE.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PDE.Location = new System.Drawing.Point(438, 375);
            this.buttonDone_PDE.Name = "buttonDone_PDE";
            this.buttonDone_PDE.Size = new System.Drawing.Size(216, 63);
            this.buttonDone_PDE.TabIndex = 2;
            this.buttonDone_PDE.Text = "Выполнить";
            this.buttonDone_PDE.UseVisualStyleBackColor = false;
            this.buttonDone_PDE.Click += new System.EventHandler(this.buttonDone_PDE_Click);
            this.buttonDone_PDE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PDE_MouseDown);
            this.buttonDone_PDE.MouseEnter += new System.EventHandler(this.buttonDone_PDE_MouseEnter);
            this.buttonDone_PDE.MouseLeave += new System.EventHandler(this.buttonDone_PDE_MouseLeave);
            // 
            // buttonHelp_PDE
            // 
            this.buttonHelp_PDE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_PDE.Location = new System.Drawing.Point(306, 375);
            this.buttonHelp_PDE.Name = "buttonHelp_PDE";
            this.buttonHelp_PDE.Size = new System.Drawing.Size(126, 62);
            this.buttonHelp_PDE.TabIndex = 3;
            this.buttonHelp_PDE.Text = "Справка";
            this.buttonHelp_PDE.UseVisualStyleBackColor = false;
            this.buttonHelp_PDE.Click += new System.EventHandler(this.buttonHelp_PDE_Click);
            // 
            // groupBoxResult_PDE
            // 
            this.groupBoxResult_PDE.Controls.Add(this.dataGridViewFunction_PDE);
            this.groupBoxResult_PDE.Controls.Add(this.chartFunction_PDE);
            this.groupBoxResult_PDE.Controls.Add(this.labelResult_PDE);
            this.groupBoxResult_PDE.Location = new System.Drawing.Point(661, 12);
            this.groupBoxResult_PDE.Name = "groupBoxResult_PDE";
            this.groupBoxResult_PDE.Size = new System.Drawing.Size(545, 424);
            this.groupBoxResult_PDE.TabIndex = 4;
            this.groupBoxResult_PDE.TabStop = false;
            this.groupBoxResult_PDE.Text = "Вывод данных";
            // 
            // labelResult_PDE
            // 
            this.labelResult_PDE.AutoSize = true;
            this.labelResult_PDE.Location = new System.Drawing.Point(6, 16);
            this.labelResult_PDE.Name = "labelResult_PDE";
            this.labelResult_PDE.Size = new System.Drawing.Size(62, 13);
            this.labelResult_PDE.TabIndex = 0;
            this.labelResult_PDE.Text = "Результат:";
            // 
            // chartFunction_PDE
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_PDE.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_PDE.Legends.Add(legend5);
            this.chartFunction_PDE.Location = new System.Drawing.Point(193, 31);
            this.chartFunction_PDE.Name = "chartFunction_PDE";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_PDE.Series.Add(series5);
            this.chartFunction_PDE.Size = new System.Drawing.Size(351, 392);
            this.chartFunction_PDE.TabIndex = 1;
            this.chartFunction_PDE.Text = "chart1";
            // 
            // dataGridViewFunction_PDE
            // 
            this.dataGridViewFunction_PDE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_PDE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_PDE.Location = new System.Drawing.Point(9, 32);
            this.dataGridViewFunction_PDE.Name = "dataGridViewFunction_PDE";
            this.dataGridViewFunction_PDE.RowHeadersVisible = false;
            this.dataGridViewFunction_PDE.Size = new System.Drawing.Size(178, 383);
            this.dataGridViewFunction_PDE.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "f(x)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // FormMain_PDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 450);
            this.Controls.Add(this.groupBoxResult_PDE);
            this.Controls.Add(this.buttonHelp_PDE);
            this.Controls.Add(this.buttonDone_PDE);
            this.Controls.Add(this.groupBoxInput_PDE);
            this.Controls.Add(this.groupBoxTask_PDE);
            this.MaximizeBox = false;
            this.Name = "FormMain_PDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Таск 2 | Вариант 11 | Полянский Д. Э.";
            this.groupBoxTask_PDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_PDE)).EndInit();
            this.groupBoxInput_PDE.ResumeLayout(false);
            this.groupBoxInput_PDE.PerformLayout();
            this.groupBoxResult_PDE.ResumeLayout(false);
            this.groupBoxResult_PDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PDE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PDE;
        private System.Windows.Forms.PictureBox pictureBoxTask_PDE;
        private System.Windows.Forms.GroupBox groupBoxInput_PDE;
        private System.Windows.Forms.Label labelStop_PDE;
        private System.Windows.Forms.Label labelStart_PDE;
        private System.Windows.Forms.TextBox textBoxStop_PDE;
        private System.Windows.Forms.TextBox textBoxStart_PDE;
        private System.Windows.Forms.Button buttonDone_PDE;
        private System.Windows.Forms.Button buttonHelp_PDE;
        private System.Windows.Forms.GroupBox groupBoxResult_PDE;
        private System.Windows.Forms.Label labelResult_PDE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PDE;
        private System.Windows.Forms.DataGridView dataGridViewFunction_PDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

