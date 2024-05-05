using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoanCalc : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Customers.mdf;Integrated Security=True");
        int i;
        string a = Form1.user;
        string ano = Home.ano;

        public LoanCalc()
        {
            InitializeComponent();
        }

        private void LoanCalc_Load(object sender, EventArgs e)
        {
            EMI.Text = "";
            TamountPayable.Text = "";
            Interestpaid.Text = "";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            double total; double r = Convert.ToDouble(Interest.Text);
            int p = Int32.Parse(Lamount.Text); int dur = Int32.Parse(Duration.Text);
            r = r / 12 / 100; dur = dur * 12;
            double temp = Math.Pow(1 + r, dur);
            total = (p * r) * ((temp) / (temp - 1));
            double final = total * dur;
            total = Math.Round(total, 0); string t = total.ToString("#,##0");
            final = Math.Round(final, 0); string f = final.ToString("#,##0");
            double difference = final - p; string d = difference.ToString("#,##0");

            EMI.Text = "₹" + t;
            TamountPayable.Text = "₹" + f;
            Interestpaid.Text = "₹" + d;

            chart1.Series[0].Points.AddXY("Principal Loan Ammount", p);
            chart1.Series[0].Points.AddXY("Total Interest", final - p);
            chart1.Series[0].Points[0].Color = Color.Crimson;
            chart1.Series[0].Points[1].Color = Color.Wheat;
            chart1.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Duration.Text = trackBar1.Value.ToString();
        }

        private void Duration_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Duration.Text))
            { }
            else
            {
                if (Int32.Parse(Duration.Text) >= 1)
                {
                    if (Int32.Parse(Duration.Text) <= 30)
                        trackBar1.Value = Int32.Parse(Duration.Text);
                }
            }
        }

        private void Lamount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Lamount.Text))
            { }
            else
            {
                if (Int64.Parse(Lamount.Text) >= 0)
                {
                    if (Int64.Parse(Lamount.Text) <= 2000000)
                        trackBar2.Value = Int32.Parse(Lamount.Text);
                }
            }
        }

        private void Interest_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Interest.Text))
            { }
            else
            {
                if (Int32.Parse(Interest.Text) >= 1)
                {
                    if (Int32.Parse(Interest.Text) <= 25)
                        trackBar3.Value = Int32.Parse(Interest.Text);
                }
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Lamount.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Interest.Text = trackBar3.Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            SqlCommand cd = new SqlCommand("select balance from details where Username=@username and Accountno=@account");
            cd.Parameters.AddWithValue("@username", a);
            cd.Parameters.AddWithValue("@account", ano);
            cd.Connection = cn;

            try
            {
                cn.Open();
                cd.ExecuteNonQuery();
                string b = cd.ExecuteScalar().ToString();
                int oldBal = Int32.Parse(b);
                int deposit = Int32.Parse(Lamount.Text);
                int newBal = oldBal + deposit;
                cn.Close();

                SqlCommand dep = new SqlCommand("update details set balance=@new where Username=@username and Accountno=@account");
                dep.Connection = cn;
                dep.Parameters.AddWithValue("@username", a);
                dep.Parameters.AddWithValue("@account", ano);
                dep.Parameters.AddWithValue("@new", newBal);
                cn.Open();
                dep.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }

            SqlCommand cp = new SqlCommand("select MAX(id) from Transactions");
            cp.Connection = cn;
            cn.Open();
            object z = cp.ExecuteScalar();
            if (z.GetType() == typeof(DBNull))
                i = 1;
            else
                i = Int32.Parse(cp.ExecuteScalar().ToString());
            i++;
            cn.Close();

            SqlCommand cdc = new SqlCommand("insert transactions values('" + i + "', '" + a + "', '" + "Bank" + "', '" + ano + "', '" + Lamount.Text + "', '" + DateTime.Today.ToString("dd/MM/yyyy") + "', '" + "Principal amount for loan" + "')");
            cdc.Connection = cn;
            try
            {
                cn.Open();
                cdc.ExecuteNonQuery();
                MessageBox.Show("Loan Approved!");
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }
        }
    }
}
