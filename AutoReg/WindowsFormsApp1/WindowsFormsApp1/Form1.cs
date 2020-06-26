using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    string line = sr.ReadToEnd();
                    string[] array = line.Split("\r\n;".ToCharArray());
                    if ((txtB1.Text == array[0] && txtB2.Text == array[1]) || (txtB1.Text == array[3] && txtB2.Text == array[4]) ||
                    (txtB1.Text == array[6] && txtB2.Text == array[7]))
                    {
                        MessageBox.Show("Вход выполнен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не зарегистрированы в системе!", "Информация");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(this);
        }
    }
    }

