using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Transactions : Form
    {
        string t = Home.ano;
        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet1.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.customersDataSet1.Transactions);
            // TODO: This line of code loads data into the 'customersDataSet1.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.customersDataSet1.Transactions);
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Customers.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Transactions where sender=@transac", cn);
            cmd.Parameters.AddWithValue("@transac", t);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            transactionsDataGridView.DataSource = dt;
            cn.Close();

            this.transactionsTableAdapter.Fill(this.customersDataSet1.Transactions);
            cn.Open();
            SqlCommand cd = new SqlCommand("select * from Transactions where reciever=@transac", cn);
            cd.Parameters.AddWithValue("@transac", t);
            SqlDataAdapter sd = new SqlDataAdapter(cd);
            DataTable d = new DataTable();
            sd.Fill(d);
            transactionsDataGridView1.DataSource = d;
            cn.Close();

            // transactionsDataGridView1.CellFormatting +=
            //new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.transactionsDataGridView_CellFormatting);
            // this.Controls.Add(transactionsDataGridView1);
        }
        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        private void transactionsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {/*
            int count = 0;

            foreach (DataGridViewRow row in transactionsDataGridView.Rows)
            { MessageBox.Show(row.Cells[1].Value.ToString());
                int qtyEntered = Convert.ToInt16(row.Cells[1].Value);
                if (qtyEntered > 0)
                {
                    transactionsDataGridView[0, count].Style.BackColor = Color.Red;//to color the row
                    transactionsDataGridView[1, count].Style.BackColor = Color.Red;
                }
                count++;
            }

            /*
            foreach (DataGridViewRow r in transactionsDataGridView.Rows)
            {
                MessageBox.Show(Convert.ToString(r.Cells[2].Value));
                MessageBox.Show(r.Cells[2].Value.ToString());
                string test1 = r.Cells[1].Value.ToString();
                if (test1 == t)
                { r.DefaultCellStyle.BackColor = Color.Red; }
                if (test1 == t)
                { r.DefaultCellStyle.BackColor = Color.Green; }
            }
            // Set the background to red for negative values in the Balance column.
            if (transactionsDataGridView.Columns[e.ColumnIndex].Name.Equals("sender"))
            {
                Int32 intValue;
                if (Int32.TryParse((String)e.Value, out intValue))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;
                }
            }*/
        }

        private void transactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet1);

        }
    }
}
