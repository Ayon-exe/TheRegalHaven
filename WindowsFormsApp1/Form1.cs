using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string user = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            user = userTb.Text;

            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Customers.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cd = new SqlCommand("select * from details where Username='" + userTb.Text + "' and Cpass='" + Password.Text + "'", cn);
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                this.Hide();
                Home h = new Home();
                h.Show();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Incorrect Username or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Register_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void nameTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
