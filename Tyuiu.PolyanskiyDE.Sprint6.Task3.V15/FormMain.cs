using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PolyanskiyDE.Sprint6.Task3.V15.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint6.Task3.V15
{
    public partial class FormMain_PDE : Form
    {
        public FormMain_PDE()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mas = new int[5, 5] { { 33, 28, 31, 19, 4 },
                                         { 1, 32, -3, -17, -12 },
                                         { 24, -19, 26, 31, -3 },
                                         { 30, -16, 29, 28, 8 },
                                         { 30, 5, 11, 7, 32 } };

        private void buttonDone_PDE_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(mas);

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            dataGridViewResult_PDE.ColumnCount = columns;
            dataGridViewResult_PDE.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_PDE.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void FormMain_PDE_Load(object sender, EventArgs e)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            dataGridViewResult_PDE.ColumnCount = columns;
            dataGridViewResult_PDE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_PDE.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_PDE.Rows[i].Cells[j].Value = Convert.ToString(mas[i, j]);
                }
            }

        }

        private void buttonHelp_PDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-23-1 Полянский Данил Эдуардович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
