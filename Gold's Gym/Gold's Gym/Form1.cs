using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;

namespace Gold_s_Gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close your application. Confirm?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back to your Application....", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true) // applying condition if-else
            {
                menuStrip1.Dock = DockStyle.Left; // menuStrip1.Dock is a menu bar that shows the list of opions
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\ICONS\right-arrow.png");// give the file path from local disk drive d 
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top; // it tell us about the menuStrip1 to the top
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\ICONS\arrow-down.png");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"D:\ICONS\right-arrow.png");
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Member nm = new New_Member();
            nm.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Member sm = new Search_Member();
            sm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Member dm = new Delete_Member();
            dm.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipments equipments = new Equipments();
            equipments.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log Out ! Confirm?","Log Out",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
        }
    }
}
