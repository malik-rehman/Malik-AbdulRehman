using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gold_s_Gym
{
    public partial class Search_Member : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbDataReader? reader;
        DataTable dt;

        public Search_Member()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//New_Member.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM New_Member", conn);
            cmd = new OleDbCommand();
            conn.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
       
        

           

        private void search_btn_Click(object sender, EventArgs e)
        {
            //conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C://Program Files//Default Company Name//Gold's Gym//New_Member.accdb");
             OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//New_Member.accdb");
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand cmd = new OleDbCommand("select ID, FirstName, LastName, Gender, D_O_B, Mobile, Email, JoinDate, GymTime, Address, MemberShip from New_Member where id like '%" + IDBox.Text + "%'", conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Search_Member_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
