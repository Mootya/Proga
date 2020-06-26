using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Моя_группа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int indeks = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(indeks);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string surname = tbxSurname.Text;
            string num = tbxNum.Text;
            string adres = tbxAdres.Text;
            dataGridView1.Rows.Add(name, surname, num, adres);
        }
    }
}
