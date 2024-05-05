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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Gold_s_Gym
{
    public partial class Equipments : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        OleDbDataReader? reader;
        DataTable dt;
        public Equipments()
        {
            InitializeComponent();
            // Initialize the connection
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//Equipments.accdb");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void view_btn_Click_1(object sender, EventArgs e)
        {
            Equipment_Details eq = new Equipment_Details();
            eq.Show();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // Initialize the connection
            conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D://C# PROGRAMMING//Gold's Gym//Gold's Gym//bin//Debug//Equipments.accdb");

            if (customer_box.Text != "" && equipment_box.Text != "" && richTextBox1.Text != "" && customer_mobile_box.Text != "")
            {
                string query = "INSERT INTO Equipments (CustomerName, EquipName, Address, CustomerMobile)" +
                          "VALUES (@CustomerName, @EquipName, @Address, @CustomerMobile)";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", customer_box.Text);
                cmd.Parameters.AddWithValue("@EquipName", equipment_box.Text);

                cmd.Parameters.AddWithValue("@Address", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@CustomerMobile", customer_mobile_box.Text);


                // Open the connection
                conn.Open();
                // Execute the query
                cmd.ExecuteNonQuery();
                // Close the connection
                conn.Close();
                MessageBox.Show("Your Order has been placed  successfully.","Data Save",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill Data Fields plz.","Data Save",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }



            // Insert data into the database
           
           

            
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            customer_box.Clear();
            equipment_box.Clear();
            richTextBox1.Clear();
            customer_mobile_box.Clear();

        }

        private void order_view_Click(object sender, EventArgs e)

        {
            if (customer_box.Text=="" && equipment_box.Text=="" && richTextBox1.Text=="" && customer_mobile_box.Text=="")
            {
                MessageBox.Show("Plz fill all the Fields.", "Order_Detail", MessageBoxButtons.OKCancel);
            }
            else
            {

                MessageBox.Show("Your Order has been placed.", "Order", MessageBoxButtons.OKCancel);

            }

        }

        private void Equipments_Load(object sender, EventArgs e)
        {

        }
    }
}
