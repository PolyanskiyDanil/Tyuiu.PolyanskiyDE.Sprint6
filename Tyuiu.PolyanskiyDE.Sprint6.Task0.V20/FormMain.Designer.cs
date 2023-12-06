
namespace Tyuiu.PolyanskiyDE.Sprint6.Task0.V20
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
            this.groupBoxMain_PDE = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_PDE = new System.Windows.Forms.PictureBox();
            this.labelMain_PDE = new System.Windows.Forms.Label();
            this.groupBoxResult_PDE = new System.Windows.Forms.GroupBox();
            this.labelResult_PDE = new System.Windows.Forms.Label();
            this.textBoxResult_PDE = new System.Windows.Forms.TextBox();
            this.buttonDone_PDE = new System.Windows.Forms.Button();
            this.buttonHelp_PDE = new System.Windows.Forms.Button();
            this.groupBoxInput_PDE = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_PDE = new System.Windows.Forms.TextBox();
            this.labelVarX_PDE = new System.Windows.Forms.Label();
            this.groupBoxMain_PDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PDE)).BeginInit();
            this.groupBoxResult_PDE.SuspendLayout();
            this.groupBoxInput_PDE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain_PDE
            // 
            this.groupBoxMain_PDE.Controls.Add(this.pictureBoxFormula_PDE);
            this.groupBoxMain_PDE.Controls.Add(this.labelMain_PDE);
            this.groupBoxMain_PDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxMain_PDE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain_PDE.Name = "groupBoxMain_PDE";
            this.groupBoxMain_PDE.Size = new System.Drawing.Size(776, 269);
            this.groupBoxMain_PDE.TabIndex = 0;
            this.groupBoxMain_PDE.TabStop = false;
            this.groupBoxMain_PDE.Text = "Условие";
            // 
            // pictureBoxFormula_PDE
            // 
            this.pictureBoxFormula_PDE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PDE.Image")));
            this.pictureBoxFormula_PDE.Location = new System.Drawing.Point(634, 28);
            this.pictureBoxFormula_PDE.Name = "pictureBoxFormula_PDE";
            this.pictureBoxFormula_PDE.Size = new System.Drawing.Size(136, 64);
            this.pictureBoxFormula_PDE.TabIndex = 1;
            this.pictureBoxFormula_PDE.TabStop = false;
            // 
            // labelMain_PDE
            // 
            this.labelMain_PDE.AutoSize = true;
            this.labelMain_PDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMain_PDE.Location = new System.Drawing.Point(6, 25);
            this.labelMain_PDE.Name = "labelMain_PDE";
            this.labelMain_PDE.Size = new System.Drawing.Size(241, 17);
            this.labelMain_PDE.TabIndex = 0;
            this.labelMain_PDE.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxResult_PDE
            // 
            this.groupBoxResult_PDE.Controls.Add(this.labelResult_PDE);
            this.groupBoxResult_PDE.Controls.Add(this.textBoxResult_PDE);
            this.groupBoxResult_PDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxResult_PDE.Location = new System.Drawing.Point(391, 288);
            this.groupBoxResult_PDE.Name = "groupBoxResult_PDE";
            this.groupBoxResult_PDE.Size = new System.Drawing.Size(391, 95);
            this.groupBoxResult_PDE.TabIndex = 1;
            this.groupBoxResult_PDE.TabStop = false;
            this.groupBoxResult_PDE.Text = "Вывод данных";
            // 
            // labelResult_PDE
            // 
            this.labelResult_PDE.AutoSize = true;
            this.labelResult_PDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult_PDE.Location = new System.Drawing.Point(6, 29);
            this.labelResult_PDE.Name = "labelResult_PDE";
            this.labelResult_PDE.Size = new System.Drawing.Size(76, 17);
            this.labelResult_PDE.TabIndex = 1;
            this.labelResult_PDE.Text = "Результат";
            // 
            // textBoxResult_PDE
            // 
            this.textBoxResult_PDE.Location = new System.Drawing.Point(8, 49);
            this.textBoxResult_PDE.Name = "textBoxResult_PDE";
            this.textBoxResult_PDE.ReadOnly = true;
            this.textBoxResult_PDE.Size = new System.Drawing.Size(159, 29);
            this.textBoxResult_PDE.TabIndex = 0;
            // 
            // buttonDone_PDE
            // 
            this.buttonDone_PDE.Location = new System.Drawing.Point(646, 390);
            this.buttonDone_PDE.Name = "buttonDone_PDE";
            this.buttonDone_PDE.Size = new System.Drawing.Size(135, 48);
            this.buttonDone_PDE.TabIndex = 2;
            this.buttonDone_PDE.Text = "Выполнить";
            this.buttonDone_PDE.UseVisualStyleBackColor = true;
            this.buttonDone_PDE.Click += new System.EventHandler(this.buttonDone_PDE_Click);
            // 
            // buttonHelp_PDE
            // 
            this.buttonHelp_PDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PDE.Location = new System.Drawing.Point(592, 390);
            this.buttonHelp_PDE.Name = "buttonHelp_PDE";
            this.buttonHelp_PDE.Size = new System.Drawing.Size(48, 48);
            this.buttonHelp_PDE.TabIndex = 3;
            this.buttonHelp_PDE.Text = "?";
            this.buttonHelp_PDE.UseVisualStyleBackColor = true;
            this.buttonHelp_PDE.Click += new System.EventHandler(this.buttonHelp_PDE_Click);
            // 
            // groupBoxInput_PDE
            // 
            this.groupBoxInput_PDE.Controls.Add(this.labelVarX_PDE);
            this.groupBoxInput_PDE.Controls.Add(this.textBoxVarX_PDE);
            this.groupBoxInput_PDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxInput_PDE.Location = new System.Drawing.Point(12, 288);
            this.groupBoxInput_PDE.Name = "groupBoxInput_PDE";
            this.groupBoxInput_PDE.Size = new System.Drawing.Size(353, 94);
            this.groupBoxInput_PDE.TabIndex = 4;
            this.groupBoxInput_PDE.TabStop = false;
            this.groupBoxInput_PDE.Text = "Ввод данных";
            // 
            // textBoxVarX_PDE
            // 
            this.textBoxVarX_PDE.Location = new System.Drawing.Point(8, 49);
            this.textBoxVarX_PDE.Name = "textBoxVarX_PDE";
            this.textBoxVarX_PDE.Size = new System.Drawing.Size(143, 29);
            this.textBoxVarX_PDE.TabIndex = 0;
            this.textBoxVarX_PDE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_PDE_KeyPress);
            // 
            // labelVarX_PDE
            // 
            this.labelVarX_PDE.AutoSize = true;
            this.labelVarX_PDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelVarX_PDE.Location = new System.Drawing.Point(6, 29);
            this.labelVarX_PDE.Name = "labelVarX_PDE";
            this.labelVarX_PDE.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_PDE.TabIndex = 1;
            this.labelVarX_PDE.Text = "Переменная Х:";
            // 
            // FormMain_PDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxInput_PDE);
            this.Controls.Add(this.buttonHelp_PDE);
            this.Controls.Add(this.buttonDone_PDE);
            this.Controls.Add(this.groupBoxResult_PDE);
            this.Controls.Add(this.groupBoxMain_PDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_PDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Таск 0 | Вариант 20 | Полянский Д. Э.";
            this.groupBoxMain_PDE.ResumeLayout(false);
            this.groupBoxMain_PDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PDE)).EndInit();
            this.groupBoxResult_PDE.ResumeLayout(false);
            this.groupBoxResult_PDE.PerformLayout();
            this.groupBoxInput_PDE.ResumeLayout(false);
            this.groupBoxInput_PDE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain_PDE;
        private System.Windows.Forms.Label labelMain_PDE;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PDE;
        private System.Windows.Forms.GroupBox groupBoxResult_PDE;
        private System.Windows.Forms.Label labelResult_PDE;
        private System.Windows.Forms.TextBox textBoxResult_PDE;
        private System.Windows.Forms.Button buttonDone_PDE;
        private System.Windows.Forms.Button buttonHelp_PDE;
        private System.Windows.Forms.GroupBox groupBoxInput_PDE;
        private System.Windows.Forms.Label labelVarX_PDE;
        private System.Windows.Forms.TextBox textBoxVarX_PDE;
    }
}

