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
    public partial class updatedelete : Form
    {
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataTable table;
        public updatedelete()
        {
            InitializeComponent();
            GetData("SELECT * FROM [Cinema1].[dbo].[Movie]");
        }
        void GetData(string selectCommand)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");

            dataAdapter = new SqlDataAdapter(selectCommand, conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);

            table = new DataTable();
            dataAdapter.Fill(table);

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }

        private void updatedelete_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bindingSource1.EndEdit();
            DataTable dt = (DataTable)bindingSource1.DataSource;

            // Just for test.... Try this with or without the EndEdit....
            DataTable changedTable = table.GetChanges();
            Console.WriteLine(changedTable.Rows.Count);

            int rowsUpdated = dataAdapter.Update(table);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=KHALED-PC\SQLEXPRESS;Initial Catalog=Cinema1;Integrated Security=True");
            con2.Open();
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                MessageBox.Show("" + dataGridView1.Rows[selectedIndex].Cells[0].Value);
                string lid = (dataGridView1.Rows[selectedIndex].Cells[0].Value).ToString();
                dataGridView1.Rows.RemoveAt(selectedIndex);
                dataGridView1.Refresh();

                string query2 = "DELETE FROM [Cinema1].[dbo].[Movie] WHERE MovieID='" + lid + "'";

                SqlCommand cmd2 = new SqlCommand(query2, con2);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("information deleted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information updated");
        }
    }
}
