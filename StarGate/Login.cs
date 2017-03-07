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
    public partial class Login : Form
    {
        string passwordadmin = "admin";
        string usernameadmin = "admin";
        string passwordemp = "user";
        string usernameemp = "user";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != usernameadmin && textBox2.Text == passwordadmin)||
                ((textBox1.Text != usernameemp && textBox2.Text == passwordemp)))
            {
                MessageBox.Show("Wrong username");
                textBox1.Clear();
            }
            else if ((textBox1.Text == usernameadmin && textBox2.Text != passwordadmin)||
                (textBox1.Text == usernameemp && textBox2.Text != passwordemp))
            {
                MessageBox.Show("Wrong password");
                textBox2.Clear();

            }

            else if (textBox1.Text == usernameadmin && textBox2.Text == passwordadmin)
            {

                Admin A1 = new Admin();
                this.Hide();
                A1.Show();
            }
            else if (textBox1.Text == usernameemp && textBox2.Text == passwordemp)
            {

                Customer C1 = new Customer();
                this.Hide();
                C1.Show();
            }
            else{
                MessageBox.Show("wrong entries");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
