using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        Random rand = new Random();
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
                    dataGridView1[i, j].Value = rand.Next(0, 9);

        }
    }
}
