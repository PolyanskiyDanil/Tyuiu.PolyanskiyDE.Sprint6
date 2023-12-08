using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PolyanskiyDE.Sprint6.Task1.V20.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint6.Task1.V20
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_PDE.Text = "";
                textBoxResult_PDE.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_PDE.AppendText("|     X      |    f(x)    |" + Environment.NewLine);
                textBoxResult_PDE.AppendText("+------------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}      |  {1, 6:f2}    |", startStep, valueArray[i]);
                    textBoxResult_PDE.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_PDE.AppendText("+------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_PDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-23-1 Полянский Данил Эдуардович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
