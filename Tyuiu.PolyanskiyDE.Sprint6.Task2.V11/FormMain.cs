using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PolyanskiyDE.Sprint6.Task2.V11.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint6.Task2.V11
{
    public partial class FormMain_PDE : Form
    {
        public FormMain_PDE()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_PDE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PDE.Text);
                int stopStep = Convert.ToInt32(textBoxStop_PDE.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_PDE.Titles.Add("График функции ((cos(x)) / (x + 1)) - cos(x) * 1.3 + 3 * x");

                this.chartFunction_PDE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PDE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_PDE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_PDE.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-1 Полянский Данил Эдуардович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_PDE_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PDE.BackColor = Color.Red;
        }

        private void buttonDone_PDE_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PDE.BackColor = Color.Green;
        }

        private void buttonDone_PDE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PDE.BackColor = Color.Blue;
        }
    }
}
