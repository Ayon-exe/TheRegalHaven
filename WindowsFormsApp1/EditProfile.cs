using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditProfile : Form
    {
        string a = Form1.user;
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Customers.mdf;Integrated Security=True");

        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            SqlCommand namecd = new SqlCommand("select Cname from details where Username=@username");
            SqlCommand emailcd = new SqlCommand("select Cemail from details where Username=@username");
            SqlCommand phonecd = new SqlCommand("select Cphone from details where Username=@username");
            SqlCommand addcd = new SqlCommand("select Cadd from details where Username=@username");
            SqlCommand dobcd = new SqlCommand("select Cdob from details where Username=@username");
            SqlCommand gencd = new SqlCommand("select Cgender from details where Username=@username");
            emailcd.Parameters.AddWithValue("@username", a);
            namecd.Parameters.AddWithValue("@username", a);
            phonecd.Parameters.AddWithValue("@username", a);
            addcd.Parameters.AddWithValue("@username", a);
            dobcd.Parameters.AddWithValue("@username", a);
            gencd.Parameters.AddWithValue("@username", a);
            emailcd.Connection = cn;
            namecd.Connection = cn;
            phonecd.Connection = cn;
            addcd.Connection = cn;
            dobcd.Connection = cn;
            gencd.Connection = cn;
            cn.Open();
            emailcd.ExecuteNonQuery();
            namecd.ExecuteNonQuery();
            phonecd.ExecuteNonQuery();
            addcd.ExecuteNonQuery();
            dobcd.ExecuteNonQuery();
            gencd.ExecuteNonQuery();

            usernametb.Text = a;
            nametb.Text = namecd.ExecuteScalar().ToString().Trim();
            emailtb.Text = emailcd.ExecuteScalar().ToString().Trim();
            addtb.Text = addcd.ExecuteScalar().ToString().Trim();
            phonetb.Text = phonecd.ExecuteScalar().ToString().Trim();
            dobtb.Text = dobcd.ExecuteScalar().ToString().Trim();
            cn.Close();
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            string gend = "";
            //for gender radiobuttons
            if (malerb.Checked == true)
            { gend = "Male"; }
            else if (femalerb.Checked == true)
            { gend = "Female"; }
            SqlCommand cd = new SqlCommand("update details set Cname=@name , Cemail=@email , Cadd=@add , Cphone=@phone Cgender=@gender where Username=@username");
            cd.Parameters.AddWithValue("@username", a);
            cd.Parameters.AddWithValue("@name", nametb.Text);
            cd.Parameters.AddWithValue("@email", emailtb.Text);
            cd.Parameters.AddWithValue("@add", addtb.Text);
            cd.Parameters.AddWithValue("@phone", phonetb.Text);
            cd.Parameters.AddWithValue("@gender", gend);
            cd.Connection = cn;
            try
            {
                cn.Open();
                cd.ExecuteNonQuery();
                MessageBox.Show("Your Profile has been Updated!");
                mydetails h = new mydetails();
                this.Hide();
                h.Show();
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mydetails h = new mydetails();
            this.Hide();
            h.Show();
        }
    }
}
