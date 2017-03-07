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
    public partial class Showing_Movies : Form
    {
        
        

        public Showing_Movies()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Showing_Movies_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string genre1 = textBox2.Text;
            string date = textBox3.Text;
            

            if (textBox1.Text!="" )
            {
                SqlConnection cn1 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
                cn1.Open();
                SqlDataAdapter da1= new SqlDataAdapter("SELECT * FROM [dbo].[Movie] WHERE MovieDuration>"+Convert.ToInt16(textBox1.Text)+"", cn1);
                DataTable dt1=new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            if (genre1!="")
            {
                SqlConnection cn1a = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
                cn1a.Open();
                SqlDataAdapter da1a = new SqlDataAdapter("SELECT * FROM [dbo].[Movie] WHERE MovieGenre='" + genre1 + "'", cn1a);
                DataTable dt1a = new DataTable();
                da1a.Fill(dt1a);
                dataGridView1.DataSource = dt1a;
            }
            if (date!="")
            {
                SqlConnection cn1i = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
                cn1i.Open();
                SqlDataAdapter da1i = new SqlDataAdapter("SELECT * FROM [dbo].[Movie] WHERE MovieRealeseDate='" + date + "'", cn1i);
                DataTable dt1i = new DataTable();
                da1i.Fill(dt1i);
                dataGridView1.DataSource = dt1i;
            }
           


           
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            SqlDataAdapter da;
            DataTable dt = new DataTable();
           
            da = new SqlDataAdapter("SELECT * FROM [dbo].[Movie]", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}