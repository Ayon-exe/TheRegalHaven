using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mydetails : Form
    {
        string a = Form1.user;int c;
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Customers.mdf;Integrated Security=True");

        public mydetails()
        {
            InitializeComponent();
        }

        private void mydetails_Load(object sender, EventArgs e)
        {
            SqlCommand usercd = new SqlCommand("select Username from details where Username=@username");
            SqlCommand namecd = new SqlCommand("select Cname from details where Username=@username");
            SqlCommand emailcd = new SqlCommand("select Cemail from details where Username=@username");
            SqlCommand phonecd = new SqlCommand("select Cphone from details where Username=@username");
            SqlCommand addcd = new SqlCommand("select Cadd from details where Username=@username");
            SqlCommand dobcd = new SqlCommand("select Cdob from details where Username=@username");
            SqlCommand gencd = new SqlCommand("select Cgender from details where Username=@username");
            usercd.Parameters.AddWithValue("@username", a);
            emailcd.Parameters.AddWithValue("@username", a);
            namecd.Parameters.AddWithValue("@username", a);
            phonecd.Parameters.AddWithValue("@username", a);
            addcd.Parameters.AddWithValue("@username", a);
            dobcd.Parameters.AddWithValue("@username", a);
            gencd.Parameters.AddWithValue("@username", a);
            usercd.Connection = cn;
            emailcd.Connection = cn;
            namecd.Connection = cn;
            phonecd.Connection = cn;
            addcd.Connection = cn;
            dobcd.Connection = cn;
            gencd.Connection = cn;
            cn.Open();
            usercd.ExecuteNonQuery();
            emailcd.ExecuteNonQuery();
            namecd.ExecuteNonQuery();
            phonecd.ExecuteNonQuery();
            addcd.ExecuteNonQuery();
            dobcd.ExecuteNonQuery();
            gencd.ExecuteNonQuery();

            name.Text = "Name: " + namecd.ExecuteScalar().ToString();
            username.Text = "Username: " + usercd.ExecuteScalar().ToString();
            email.Text = "Email: " + emailcd.ExecuteScalar().ToString();
            address.Text = "Address: " + addcd.ExecuteScalar().ToString();
            phone.Text = "Phone Number: " + phonecd.ExecuteScalar().ToString();
            dob.Text = "Date Of Birth: " + dobcd.ExecuteScalar().ToString().Trim();
            gender.Text = "Gender: " + gencd.ExecuteScalar().ToString();

            cn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile d = new EditProfile();
            d.Show();
        }

        private void newaccount_Click(object sender, EventArgs e)
        {
            SqlCommand namecd = new SqlCommand("select Cname from details where Username=@username");
            SqlCommand emailcd = new SqlCommand("select Cemail from details where Username=@username");
            SqlCommand phonecd = new SqlCommand("select Cphone from details where Username=@username");
            SqlCommand addcd = new SqlCommand("select Cadd from details where Username=@username");
            SqlCommand dobcd = new SqlCommand("select Cdob from details where Username=@username");
            SqlCommand gencd = new SqlCommand("select Cgender from details where Username=@username");
            SqlCommand pass = new SqlCommand("select Cpass from details where Username=@username");
            
            emailcd.Parameters.AddWithValue("@username", a);
            namecd.Parameters.AddWithValue("@username", a);
            phonecd.Parameters.AddWithValue("@username", a);
            addcd.Parameters.AddWithValue("@username", a);
            dobcd.Parameters.AddWithValue("@username", a);
            gencd.Parameters.AddWithValue("@username", a);
            pass.Parameters.AddWithValue("@username", a);       

            emailcd.Connection = cn;
            namecd.Connection = cn;
            phonecd.Connection = cn;
            addcd.Connection = cn;
            dobcd.Connection = cn;
            gencd.Connection = cn;
            pass.Connection = cn;

            cn.Open();
            emailcd.ExecuteNonQuery();
            namecd.ExecuteNonQuery();
            phonecd.ExecuteNonQuery();
            addcd.ExecuteNonQuery();
            dobcd.ExecuteNonQuery();
            gencd.ExecuteNonQuery();
            pass.ExecuteNonQuery();

            string name =namecd.ExecuteScalar().ToString();
            string email=emailcd.ExecuteScalar().ToString();
            string address=addcd.ExecuteScalar().ToString();
            string phone=phonecd.ExecuteScalar().ToString();
            string dob=dobcd.ExecuteScalar().ToString();
            string gender=gencd.ExecuteScalar().ToString();
            string password=pass.ExecuteScalar().ToString();

            SqlCommand cb = new SqlCommand("select MAX(id) from details");
            cb.Connection = cn;
            object z = cb.ExecuteScalar();
            if (z.GetType() == typeof(DBNull))
                c = 1;
            else
                c = Int16.Parse(cb.ExecuteScalar().ToString());
            c++;
            Random rnd = new Random();
            int account = rnd.Next();
            SqlCommand insert = new SqlCommand("insert into details values('" + c + "', '" + a + "', '" + password + "', '" + account + "', '" + name + "', '" + "0" + "', '" + phone + "', '" + address + "', '" + dob + "', '" + gender + "', '" + email+ "')");
            insert.Connection = cn;
            insert.ExecuteNonQuery();
            cn.Close();
        }
    }
}
