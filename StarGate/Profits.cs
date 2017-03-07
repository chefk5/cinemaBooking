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
    public partial class Profits : Form
    {
        public Profits()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            cn1.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select sum([price]) from[dbo].[ticket1] where[MovieNAME]='" + textBox1.Text + "'", cn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            cn1.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT [MovieNAME],SUM([price]) FROM [dbo].[ticket1] group by [MovieNAME] order by SUM([price]) desc;", cn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            cn1.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT [MovieNAME],SUM([price]) FROM [dbo].[ticket1] group by [MovieNAME] order by SUM([price]) asc;", cn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
    }
}
