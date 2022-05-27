using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _066_ExeDataGridandNavBinding
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InputUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputPW_TextChanged(object sender, EventArgs e)
        {
            if (InputPW.PasswordChar == '\0')
            {
                InputPW.PasswordChar = '*';
            }
        }

        private void TnC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (InputUser.Text == "Ican" && InputPW.Text == "Ican123")
            {
                new HomePage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User ID atau Password salah !!!");
            }
        }
    }
}
