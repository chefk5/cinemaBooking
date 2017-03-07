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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void updateMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        } 

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salesform sale1 = new Salesform();
            
            sale1.Show();
        }

        private void profitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profits p1 = new Profits();
            p1.MdiParent = this;
            p1.Show();
        }

        private void aaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedelete up1 = new updatedelete();
            up1.MdiParent = this;
            up1.Show();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatedelete up1 = new updatedelete();
            up1.MdiParent = this;
            up1.Show();
        }
        
    }

}
