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
    public partial class Delete_Member : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbDataReader? reader;
        DataTable dt;
        public Delete_Member()
        {
            InitializeComponent();
            //conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C://Program Files//Default Company Name//Gold's Gym//New_Member.accdb");
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//New_Member.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM New_Member", conn);
            cmd = new OleDbCommand();
            conn.Open();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {


            string query = "DELETE FROM New_Member WHERE ID = @ID";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(IDBox.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Delete Successfully....");

            //conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C://Program Files//Default Company Name//Gold's Gym//New_Member.accdb");
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//New_Member.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM New_Member", conn);
            cmd = new OleDbCommand();
            conn.Open();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Member_Load(object sender, EventArgs e)
        {

        }
    }
}
