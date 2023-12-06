using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PolyanskiyDE.Sprint6.Task0.V20.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint6.Task0.V20
{
    public partial class FormMain_PDE : Form
    {
        public FormMain_PDE()
        {
            InitializeComponent();
        }

        private void buttonDone_PDE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_PDE.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_PDE.Text)));
            }
            catch
            {
                MessageBox.Show("Введене неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_PDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_PDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУБ-23-1 Полянский Данил Эдуардович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
