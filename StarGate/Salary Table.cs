using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StarGate
{
    public partial class Salesform : Form
    {
        public Salesform()
        {


         
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn11 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            SqlDataAdapter da;
            cn11.Open();
            DataTable dt = new DataTable();

            da = new SqlDataAdapter("SELECT * FROM [dbo].[ticket1]", cn11);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinema1DataSet.ticket1' table. You can move, or remove it, as needed.
            this.ticket1TableAdapter.Fill(this.cinema1DataSet.ticket1);
           
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (textBox2.Text != "")
            {
                SqlConnection cn1 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
                cn1.Open();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM [dbo].[ticket1] WHERE [SEATtype]='" + textBox2.Text + "'", cn1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else if (textBox1.Text != "")
            {
                SqlConnection cn1 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
                cn1.Open();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM [dbo].[ticket1] WHERE [MovieNAME]='" + textBox1.Text + "'", cn1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else if (textBox3.Text != "")
            {
                SqlConnection cn1 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
                cn1.Open();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM [dbo].[ticket1] WHERE [showingtime]='" + textBox3.Text + "'", cn1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
        }
    }
}
