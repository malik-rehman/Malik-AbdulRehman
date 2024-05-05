using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gold_s_Gym
{
    public partial class New_Member : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbDataReader? reader;
        DataTable dt;
        public New_Member()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//New_Member.accdb");
            conn.Open();
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM [Gold's Gym]", conn);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        void Getstudent()
        {
            //conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C://Program Files//Default Company Name//Gold's Gym//New_Member.accdb");
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//New_Member.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM New_Member", conn);
            //cmd = new OleDbCommand();
            conn.Open();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            // Initialize the connection
            //conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C://Program Files//Default Company Name//Gold's Gym//New_Member.accdb");
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//New_Member.accdb");

            if (firstnamebox.Text!="" && lastnamebox.Text!="" && dateTimePicker1.Text!="" && mobilebox.Text!="" && emailbox.Text!="" && dateTimePicker2.Text!="" && gymtimebox.Text!="" && addressbox.Text!="" && membershipbox.Text!="" && Fees_Box.Text!="" )
            {
            // Insert data into the database
                string query = "INSERT INTO New_Member (FirstName, LastName, Gender, D_O_B, Mobile, Email, JoinDate, GymTime, Address, MemberShip, GymFees)" +
               "VALUES (@FirstName, @LastName, @Gender, @D_O_B, @Mobile, @Email, @JoinDate, @GymTime, @Address, @MemberShip, @GymFees)";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstnamebox.Text);
                cmd.Parameters.AddWithValue("@LastName", lastnamebox.Text);
                // Assuming radioButton1 is the RadioButton control for gender selection
                cmd.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@D_O_B", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Mobile", mobilebox.Text);
                cmd.Parameters.AddWithValue("@Email", emailbox.Text);
                cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@GymTime", gymtimebox.Text);
                cmd.Parameters.AddWithValue("@Address", addressbox.Text);
                cmd.Parameters.AddWithValue("@MemberShip", membershipbox.Text);
                cmd.Parameters.AddWithValue("@GymFees", Fees_Box.Text);

                // Open the connection
                conn.Open();
                // Execute the query
                cmd.ExecuteNonQuery();
                // Close the connection
                conn.Close();
            MessageBox.Show(" Data Inserted Successfully.", "New Member Details", MessageBoxButtons.OKCancel,MessageBoxIcon.None);

            Getstudent();
            }
            else
            {
                
            MessageBox.Show("Plz Fill all the fields.", "New Member Details", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }

            
        }

        private void New_Member_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//New_Member.accdb");
            //conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C://Program Files//Default Company Name//Gold's Gym//New_Member.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM New_Member", conn);
            cmd = new OleDbCommand();
            conn.Open();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
            Getstudent();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            firstnamebox.Clear();
            lastnamebox.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            mobilebox.Clear();
            emailbox.Clear();

            gymtimebox.ResetText();
            addressbox.Clear();
            membershipbox.ResetText();
            Fees_Box.ResetText();
        }

        private void membershipbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE New_Member " +
                       "SET " +
                       "FirstName = @FirstName, " +
                       "LastName = @LastName, " +
                       "Gender = @Gender, " +
                       "D_O_B = @D_O_B, " +
                       "Mobile = @Mobile, " +
                       "Email= @Email, " +
                       "JoinDate= @JoinDate, " +
                       "GymTime= @GymTime, " +
                       "Address= @Address, " +
                       "MemberShip = @MemberShip, " +
                       "GymFees = @GymFees " +
                       "WHERE " +
                       "ID = @id ";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID_box.Text));
            cmd.Parameters.AddWithValue("@FirstName", firstnamebox.Text);
            cmd.Parameters.AddWithValue("@LastName", lastnamebox.Text);
            // Assuming radioButton1 is the RadioButton control for gender selection
            cmd.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Male" : "Female");
            cmd.Parameters.AddWithValue("@D_O_B", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Mobile", mobilebox.Text);
            cmd.Parameters.AddWithValue("@Email", emailbox.Text);
            cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@GymTime", gymtimebox.Text);
            cmd.Parameters.AddWithValue("@Address", addressbox.Text);
            cmd.Parameters.AddWithValue("@MemberShip", membershipbox.Text);
            cmd.Parameters.AddWithValue("@GymFees", Fees_Box.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated Successfully ");

            Getstudent();
        }

      

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID_box.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            firstnamebox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mobilebox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            emailbox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            gymtimebox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            addressbox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            membershipbox.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            Fees_Box.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }
    }
}
