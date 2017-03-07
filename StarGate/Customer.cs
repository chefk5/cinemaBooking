using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StarGate
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showing_Movies sm1 = new Showing_Movies();
            sm1.MdiParent = this;
            sm1.Show();
            

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets ti1 = new Tickets();
            ti1.MdiParent = this;
            ti1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
           
        }
    }
}
