using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Репозиторий
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.RowCount = Convert.ToInt32(numericUpDown4.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown3.Value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Class1.Zapolnit(dataGridView1, dataGridView2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.clear(dataGridView1, dataGridView2);
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Даны два двумерных массива вещественных элементов. Размер исходных массивов не превосходит" +
                "10х10 элементов.Для каждого из массивов указать номера столбцов, произведение отрицательных" +
                "элементов которых является положительным числом.Если таких столбцов нет ни для одного из" +
                "массивов, то вывести соответствующее сообщение.Проверку столбца на выполнение условия и расчет" +
                "оформить в виде процедуры с передачей в нее всех элементов текущего столбца.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Извиняюсь тысячикратно");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Прощаю");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.zadanie(dataGridView1, dataGridView2, textBox1, textBox2);
        }
    }
}
