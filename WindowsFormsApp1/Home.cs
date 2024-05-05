using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {

        string a = Form1.user; string x;
        public static string ano = "";
        int newBal, i; string ac;
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Customers.mdf;Integrated Security=True");


        public Home()
        {
            InitializeComponent();
        }

        //on page load
        private void Home_Load(object sender, EventArgs e)
        {

            //chart1.Series[1].Points.AddXY(0,30);
            //to greet with name
            SqlCommand ca = new SqlCommand("select Cname from details where Username=@username");
            ca.Parameters.AddWithValue("@username", a);
            ca.Connection = cn;
            cn.Open();
            ca.ExecuteNonQuery();
            string c = ca.ExecuteScalar().ToString();
            cn.Close();

            int hr = DateTime.Now.Hour;
            if (hr >= 0 && hr < 12)
            { x = "Good Morning "; }
            else if (hr >= 12 && hr < 17)
            { x = "Good Afternoon "; }
            else
            { x = "Good Evening "; }
            label3.Text = x + c;

            //to select the account number of the user
            SqlCommand ce = new SqlCommand("select MIN(Accountno) from details where Username=@user");
            ce.Parameters.AddWithValue("@user", a);
            ce.Connection = cn;
            cn.Open();
            ac = ce.ExecuteScalar().ToString();
            cn.Close();
            updatebal();
            label8.Text = "XX";

            //to show profile picture
            SqlCommand cb = new SqlCommand("select Cgender from details where Username=@username");
            cb.Parameters.AddWithValue("@username", a);
            cb.Connection = cn;
            cn.Open();
            ca.ExecuteNonQuery();
            string g = cb.ExecuteScalar().ToString();
            cn.Close();

            Bitmap image;
            if (g.Trim() == "Male")
            {
                image = new Bitmap("C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Images\\bank profiles (1).png");
            }
            else
            {
                image = new Bitmap("C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Images\\bank profiles (2).png");
            }
            pictureBox1.Image = (Image)image;
            Controls.Add(pictureBox1);

            //to show all bank accounts of user in combobox
            SqlCommand dd = new SqlCommand("SELECT Id,Accountno FROM details where Username=@a", cn);
            dd.Parameters.AddWithValue("@a", a);
            SqlDataAdapter sda = new SqlDataAdapter(dd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Accountno";
        }

        //to deposit funds
        private void deposit_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("select balance from details where Username=@username and Accountno=@account");
            cd.Parameters.AddWithValue("@username", a);
            cd.Parameters.AddWithValue("@account", comboBox1.Text);
            cd.Connection = cn;

            try
            {
                cn.Open();
                cd.ExecuteNonQuery();
                string b = cd.ExecuteScalar().ToString();
                int oldBal = Int16.Parse(b);
                int deposit = Int16.Parse(depositTb.Text);
                int newBal = oldBal + deposit;
                cn.Close();

                SqlCommand dep = new SqlCommand("update details set balance=@new where Username=@username and Accountno=@account");
                dep.Connection = cn;
                dep.Parameters.AddWithValue("@username", a);
                dep.Parameters.AddWithValue("@account", comboBox1.Text);
                dep.Parameters.AddWithValue("@new", newBal);
                cn.Open();
                dep.ExecuteNonQuery();
                cn.Close();
                depositTb.Text = "";
                ac = comboBox1.Text;
                updatebal();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }
        }


        //to withdraw funds
        private void withdraw_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("select balance from details where Username=@username and Accountno=@account");
            cd.Parameters.AddWithValue("@username", a);
            cd.Parameters.AddWithValue("@account", comboBox1.Text);
            cd.Connection = cn;

            try
            {
                cn.Open();
                cd.ExecuteNonQuery();
                string b = cd.ExecuteScalar().ToString();
                cn.Close();
                int oldBal = Int16.Parse(b);
                int withdraw = Int16.Parse(withdrawTb.Text);
                newBal = oldBal - withdraw;
                if (newBal >= 200)
                {
                    SqlCommand cdd = new SqlCommand("update details set balance=@new where Username=@username and Accountno=@account");
                    cdd.Connection = cn;
                    cdd.Parameters.AddWithValue("@username", a);
                    cdd.Parameters.AddWithValue("@account", comboBox1.Text);
                    cdd.Parameters.AddWithValue("@new", newBal);
                    cn.Open();
                    cdd.ExecuteNonQuery();
                    cn.Close();
                    updatebal();
                    withdrawTb.Text = "";
                }
                else
                { MessageBox.Show("Cannot go below the minimum balance of 200","Insufficient Balance."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }
        }

        //to update on demand
        private void update_Click(object sender, EventArgs e)
        {
            ac = comboBox1.Text;
            updatebal();
        }

        //to transfer funds
        private void Transfer_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("select balance from details where Username=@username and Accountno=@account");
            cd.Parameters.AddWithValue("@username", a);
            cd.Parameters.AddWithValue("@account", comboBox1.Text);
            cd.Connection = cn;
            cn.Open();
            cd.ExecuteNonQuery();
            string c = cd.ExecuteScalar().ToString();
            cn.Close();
            int currentBal = Int16.Parse(c);
            if (currentBal >= 200)
            {
                SqlCommand cde = new SqlCommand("select balance from details where Username=@username and Accountno=@account");
                cde.Parameters.AddWithValue("@username", a);
                cde.Parameters.AddWithValue("@account", comboBox1.Text);
                cde.Connection = cn;

                try
                {
                    cn.Open();
                    cd.ExecuteNonQuery();
                    string d = cd.ExecuteScalar().ToString();
                    cn.Close();
                    int oldBall = Int16.Parse(d);
                    int amount = Int16.Parse(amountTb.Text);
                    newBal = oldBall - amount;

                    SqlCommand cdd = new SqlCommand("update details set balance=@new where Username=@username and Accountno=@account");
                    cdd.Connection = cn;
                    cdd.Parameters.AddWithValue("@username", a);
                    cdd.Parameters.AddWithValue("@account", comboBox1.Text);
                    cdd.Parameters.AddWithValue("@new", newBal);
                    cn.Open();
                    cdd.ExecuteNonQuery();
                    cn.Close();
                    updatebal();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }

                SqlCommand cp = new SqlCommand("select MAX(id) from Transactions");
                cp.Connection = cn;
                cn.Open();
                object z = cp.ExecuteScalar();
                if (z.GetType() == typeof(DBNull))
                    i = 1;
                else
                    i = Int16.Parse(cp.ExecuteScalar().ToString());
                i++;
                cn.Close();

                SqlCommand cdc = new SqlCommand("insert transactions values('" + i + "', '" + a + "', '" + comboBox1.Text + "', '" + toTb.Text + "', '" + amountTb.Text + "', '" + DateTime.Today.ToString("dd/MM/yyyy") + "', '" + commentTb.Text + "')");
                cdc.Connection = cn;
                try
                {
                    cn.Open();
                    cdc.ExecuteNonQuery();
                    MessageBox.Show("Fund Transfer Complete!");
                    cn.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }

                SqlCommand cdf = new SqlCommand("select balance from details where Accountno=@account");
                cdf.Parameters.AddWithValue("@account", toTb.Text);
                cdf.Connection = cn;

                try
                {
                    cn.Open();
                    cdf.ExecuteNonQuery();
                    string f = cdf.ExecuteScalar().ToString();
                    int oldBal = Int16.Parse(f);
                    int deposit = Int16.Parse(amountTb.Text);
                    int newBal = oldBal + deposit;
                    cn.Close();

                    SqlCommand dep = new SqlCommand("update details set balance=@new where Accountno=@account");
                    dep.Connection = cn;
                    dep.Parameters.AddWithValue("@account", toTb.Text);
                    dep.Parameters.AddWithValue("@new", newBal);
                    cn.Open();
                    dep.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }
            }
            else
            { MessageBox.Show("Cannot go below the minimum balance of 200"); cn.Close(); }
        }

        //to update the balance
        public void updatebal()
        {
            SqlCommand cd = new SqlCommand("select balance from details where Username=@username and Accountno=@account");
            cd.Parameters.AddWithValue("@username", a);
            cd.Parameters.AddWithValue("@account", ac);
            cd.Connection = cn;

            try
            {
                cn.Open();
                cd.ExecuteNonQuery();
                label8.Text = cd.ExecuteScalar().ToString();
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }
        }

        //to go to transactions screen
        private void transactions_Click(object sender, EventArgs e)
        {
            ano = comboBox1.Text;
            Transactions t = new Transactions();
            this.Hide();
            t.Show();
        }

        private void mydetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            mydetails m = new mydetails();
            m.Show();
        }

        private void Loan_Click(object sender, EventArgs e)
        {
            ano = comboBox1.Text;
            this.Hide();
            LoanCalc l = new LoanCalc();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ano = comboBox1.Text;
            this.Hide();
            fdcalc f = new fdcalc();
            f.Show();
        }

        private void rd_Click(object sender, EventArgs e)
        {
            ano = comboBox1.Text;
            this.Hide();
            rdcalc r = new rdcalc();
            r.Show();
        }

        private void sip_Click(object sender, EventArgs e)
        {
            ano = comboBox1.Text;
            this.Hide();
            sipcalc s = new sipcalc();
            s.Show();
        }

        private void ppf_Click(object sender, EventArgs e)
        {
            ano = comboBox1.Text;
            this.Hide();
            ppfcalc p = new ppfcalc();
            p.Show();
        }

        //to go back to Login screen
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
