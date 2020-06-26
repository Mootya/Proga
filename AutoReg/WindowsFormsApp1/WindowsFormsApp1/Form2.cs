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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
              try
            {
                string password = txtB2.Text;
                if (password.Length >= 6 && password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) >= 0)
                {
                    DialogResult save = MessageBox.Show("Ваш пароль сохранён!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string Dano = txtB1.Text +';'+ txtB2.Text;
                    StreamWriter SW = new StreamWriter("user.txt", true);
                    SW.Write("\r\n"+Dano);
                    SW.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не все условия выполнены", "Информация");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Activate();
            this.Close();
        }
    }
    }

