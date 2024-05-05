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
    public partial class Equipment_Details : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbDataReader? reader;
        DataTable dt;
        public Equipment_Details()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//Equipment_Details.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM Equipment_Details", conn);
            cmd = new OleDbCommand();
            conn.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }


        private void Equipment_Details_Load(object sender, EventArgs e)
        {
            //string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# PROGRAMMING\Gold's Gym\Gold's Gym\bin\Debug\Equipment_Details.accdb";
            string query = "SELECT * FROM Equipment_Details"; // Assuming View_Equipments is your view name

            // conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C://Program Files//Default Company Name//Gold's Gym//New_Member.accdb");
            OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//Equipment_Details.accdb");
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
