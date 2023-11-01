using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coffe_Management
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=PIOTISK\SQLEXPRESS_19;Initial Catalog=QL_Coffee;Integrated Security=True";
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Data_Form_Sql()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Price, Details, ID_Catalogue FROM Menu";
                SqlDataAdapter dataadapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataadapter.Fill(dataTable);
                connection.Close();
                dataGridView1.DataSource = dataTable;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                cmd = new SqlCommand("INSERT INTO Menu(Name, Details, Price) VALUES('" + tb_Name_input.Text + "','" + tb_Details_input.Text + "','" + Convert.ToInt32(tb_Price_input.Text.ToString()) + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Data has Saved in Database !");
                connection.Close();
            }
            tb_Details_input.Clear();
            tb_Name_input.Clear();
            tb_Price_input.Clear();
        }
        
        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                cmd = new SqlCommand("DELETE FROM Menu WHERE Name = @Name", connection);
                cmd.Parameters.AddWithValue("@Name", tb_Find.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully !");
                connection.Close();
            }
            tb_Find.Clear();
        }

        private void btn_show_menu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectedValue = cb_box_Menu.SelectedItem.ToString();
                int selectedID = Convert.ToInt32(selectedValue);
                string query = "SELECT Name, Price, Details, ID_Catalogue FROM Menu WHERE ID_Catalogue = @selectedID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedID", selectedID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable_menu = new DataTable();
                        adapter.Fill(dataTable_menu);
                        dataGridView1.DataSource = dataTable_menu;
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data_Form_Sql();
        }

        private void FillComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID FROM Category";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cb_box_Menu.Items.Clear();
                        while (reader.Read())
                        {
                            cb_box_Menu.Items.Add(reader["ID"].ToString());
                        }
                    }
                }
            }
        }

        private void cb_box_Menu_Click(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void cb_box_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cb_box_Menu.SelectedItem.ToString();
        }


    }
}
