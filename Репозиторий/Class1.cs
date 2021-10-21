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
    class Class1
    {
        public static void Zapolnit(DataGridView dataGridView1, DataGridView dataGridView2)
        {
            Random rand = new Random();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Value = rand.Next(-10,10);
                }
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {
                    dataGridView2[i, j].Value = rand.Next(-10, 10);
                }
        }

        public static void clear (DataGridView dataGridView1, DataGridView dataGridView2)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 1;
            dataGridView2.ColumnCount = 1;
            dataGridView2.RowCount = 1;

        }

        public static void zadanie(DataGridView dataGridView1, DataGridView dataGridView2, TextBox textBox1, TextBox textBox2)
        {
            int znach1 = 1;
            for (int j = 0; j <dataGridView1.RowCount; j ++)
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (Convert.ToInt32(dataGridView1[0, i].Value) < 0) znach1 *= Convert.ToInt32(dataGridView1[0, i].Value);
                }
                textBox1.Text = Convert.ToString(znach1);

            int znach2 = 1;
            for (int j = 0; j < dataGridView2.RowCount; j++)
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    if (Convert.ToInt32(dataGridView2[0, i].Value) < 0) znach2 *= Convert.ToInt32(dataGridView2[0, i].Value);
                }
            textBox2.Text = Convert.ToString(znach2);

        }
    }
}
