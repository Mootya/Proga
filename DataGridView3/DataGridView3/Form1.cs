using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        Random rand = new Random();

        int min = int.MaxValue;
        int max = int.MinValue;
        private void Build_Click(object sender, EventArgs e)
        {
            while (!int.TryParse(Size.Text, out n) | n < 1)/*проверка данных*/
            {
                MessageBox.Show("Ошибка в данных!");
                Size.Focus();
                return;
            }
            dataGridView1.ColumnCount = dataGridView1.RowCount = n;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dataGridView1[i, j].Value = rand.Next(0, 50);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (Convert.ToInt32(dataGridView1[i, j].Value) > max)
                    {
                        max = Convert.ToInt32(dataGridView1[i, j].Value);
                    }
                    if (Convert.ToInt32(dataGridView1[i, j].Value) < min)
                    {
                        min = Convert.ToInt32(dataGridView1[i, j].Value);
                    }
                }

            int diff = max - min;
            Answer.Text = "Разница между максимальным и минимальным \nэлементом = " + $"{max} - {min} = {diff}";

            min = int.MaxValue;
            max = int.MinValue;
        }
    }
    }

