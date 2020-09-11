using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int br, sum1 = 0, sum = 15;
            br = Convert.ToInt32(txtBBrkub1.Text);
            int[] ch = new int[br];
            string s = "";
            Random rnd = new Random();
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = rnd.Next(1, 6);
                sum1 += ch[i];
                s = s + ch[i] + "; ";

            }
            if (sum == sum1) MessageBox.Show(s + "\r За выбранное количество бросков вы набрали 15 очков");
            else MessageBox.Show(s + "\r За выбранное количество бросков вы не набрали 15 очков");

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            Random rnd = new Random(); 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBBrkub1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBBrkub1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) & number != 8) e.Handled = Enabled;
        }
    }
}
