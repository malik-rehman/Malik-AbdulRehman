using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold_s_Gym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            if (name_box.Text == "admin" && password_box.Text == "12345")
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong userId or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
