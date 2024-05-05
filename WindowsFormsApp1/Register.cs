using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        int c;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            dateTb.Value = DateTime.Today;
        }

        private void register1_Click(object sender, EventArgs e)
        {
            string gender = ""; int defaultBal = 0; bool gen = false;
            //for gender radiobuttons
            if (MaleRb.Checked == true)
            { gender = "Male"; gen = true; }
            else if (FemaleRb.Checked == true)
            { gender = "Female"; gen = true; }

            //registration
            if (string.IsNullOrEmpty(UserTb.Text) || string.IsNullOrEmpty(rnameTb.Text) || string.IsNullOrEmpty(rPhTb.Text) || string.IsNullOrEmpty(addTb.Text) || gen == false || string.IsNullOrEmpty(mailTb.Text) || string.IsNullOrEmpty(rPassTb.Text) || string.IsNullOrEmpty(rCpassTb.Text))
            { MessageBox.Show("Please enter all fields."); }
            else
            {
                if (rPassTb.Text.Length > 3)
                {
                    if (rPassTb.Text != rCpassTb.Text)
                    {
                        MessageBox.Show("Passwords do not match, please try again.");
                    }
                    else
                    {
                        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Customers.mdf;Integrated Security=True");
                        SqlCommand cb = new SqlCommand("select MAX(id) from details");
                        cb.Connection = cn;
                        cn.Open();
                        object z = cb.ExecuteScalar();
                        if (z.GetType() == typeof(DBNull))
                            c = 1;
                        else
                            c = Int16.Parse(cb.ExecuteScalar().ToString());

                        c++;
                        cn.Close();

                        Random rnd = new Random();
                        int account = rnd.Next();

                        SqlCommand cd = new SqlCommand("insert into details values('" + c + "', '" + UserTb.Text + "', '" + rPassTb.Text + "', '" + account + "', '" + rnameTb.Text + "', '" + defaultBal + "', '" + rPhTb.Text + "', '" + addTb.Text + "', '" + dateTb.Text.ToString() + "', '" + gender + "', '" + mailTb.Text + "')");
                        cd.Connection = cn;
                        try
                        {
                            cn.Open();
                            cd.ExecuteNonQuery();
                            MessageBox.Show("Registration Complete!");
                            Form1 h = new Form1();
                            this.Hide();
                            h.Show();
                            cn.Close();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else
                    MessageBox.Show("Password needs to be more than 3 characters.");
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            UserTb.Text = "";
            rnameTb.Text = "";
            rPhTb.Text = "";
            addTb.Text = "";
            mailTb.Text = "";
            rPassTb.Text = "";
            rCpassTb.Text = "";
            MaleRb.Checked = false;
            FemaleRb.Checked = false;
        }

        private void backBox1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void mailTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void addTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}