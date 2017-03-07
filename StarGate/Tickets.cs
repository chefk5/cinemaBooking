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
    public partial class Tickets : Form
    {
        SqlConnection cn3 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2; SqlCommand cmd2i;
        SqlCommand cmd3;
        int price;
       
        DataTable st = new DataTable();
       

        public Tickets()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.cinemaDataSet.Movie);
            dateTimePicker1.Value = DateTime.Now; 
            cn3.Open();
            cmd = new SqlCommand("SELECT [MovieName] FROM [dbo].[Movie]", cn3);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {

                comboBox1.Items.Add(dr1["MovieName"]);

            }
            cn3.Close();

           
          
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.movieTableAdapter.Fill(this.cinemaDataSet.Movie);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

         
          
            SqlConnection cn4 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            cn4.Open();
            cmd1 = new SqlCommand("SELECT [ShowingRoom] FROM [dbo].[Movie] WHERE [MovieName]='" + comboBox1.SelectedText+ "'", cn4);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            while (dr2.Read())
            {

                comboBox4.Items.Add(dr2["ShowingRoom"]);

            }
            cn4.Close();
            SqlConnection cn4i = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            cn4i.Open();
            cmd2i = new SqlCommand("SELECT [MovieID] FROM [dbo].[Movie] WHERE [MovieName]='" + comboBox1.SelectedText + "'", cn4i);
            SqlDataReader dr2i = cmd2i.ExecuteReader();
            while (dr2i.Read())
            {

                comboBox5.Items.Add(dr2i["MovieID"]);

            }


            SqlConnection cn5 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            cn5.Open();
            cmd2 = new SqlCommand("SELECT [ShowingTime1],[ShowingTime2] FROM [dbo].[Movie] where [MovieName]='" + comboBox1.SelectedText + "'", cn5);
            SqlDataReader dr3 = cmd2.ExecuteReader();
            comboBox2.Items.Clear();
            while (dr3.Read())
            {

                comboBox2.Items.Add(dr3["ShowingTime1"]);
                comboBox2.Items.Add(dr3["ShowingTime2"]);


            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Class A")
            {
                price = 20;
                textBox1.Text = "20";
            }
            if (comboBox3.SelectedItem == "Class B")
            {
                price = 15;
                textBox1.Text = "15";
            }
            if (comboBox3.SelectedItem == "Class C")
            {
                price = 10;
                textBox1.Text = "10";
            }

        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn6 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=TrueData Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            cn6.Open();
            cmd3 = new SqlCommand("INSERT INTO [dbo].[ticket1] ([SEATtype],[MovieiD] ,[MovieNAME],[price],[showingtime])VALUES('" + comboBox3.Text + "','" + comboBox5.SelectedItem + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "')", cn6);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Ticket!!");
     
        }
    }
}

