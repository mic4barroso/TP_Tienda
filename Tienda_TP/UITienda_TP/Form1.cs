using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITienda_TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string password = textBoxPassword.Text;
                string userName = textBoxUserName.Text;

                BLL.Login unLogin = new BLL.Login();
                if (unLogin.IniciarSesion(userName, password))
                {
                    MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
