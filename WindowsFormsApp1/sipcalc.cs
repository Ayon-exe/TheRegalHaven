using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sipcalc : Form
    {
        int i;
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\anushreemondal.94\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Customers.mdf;Integrated Security=True");
        string a = Form1.user;
        string ano = Home.ano;
        public sipcalc()
        {
            InitializeComponent();
        }

        private void sipcalc_Load(object sender, EventArgs e)
        {
            investedamount.Text = "";
            Tamount.Text = "";
            estreturns.Text = "";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            double total; double r = Convert.ToDouble(Interest.Text);
            int p = Int32.Parse(Lamount.Text); int dur = Int32.Parse(Duration.Text);
            dur = dur * 12; r = r / 100 / 12;

            double temp = Math.Pow(1 + r, dur);

            total = p * ((temp) - 1) * ((1 + r) / r);
            double final = p * dur;

            total = Math.Round(total, 0); string t = total.ToString("#,##0");
            final = Math.Round(final, 0); string f = final.ToString("#,##0");

            double difference = total - final; string d = difference.ToString("#,##0");

            investedamount.Text = "₹" + f;
            Tamount.Text = "₹" + t;
            estreturns.Text = "₹" + d;

            chart1.Series[0].Points.AddXY("Invested Amount", final);
            chart1.Series[0].Points.AddXY("Est. Returns", difference);
            chart1.Series[0].Points[0].Color = Color.Crimson;
            chart1.Series[0].Points[1].Color = Color.Wheat;
            chart1.Show();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Lamount.Text = trackBar2.Value.ToString();
        }

        private void Lamount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Lamount.Text))
            { }
            else
            {
                if (Int64.Parse(Lamount.Text) >= 500)
                {
                    if (Int64.Parse(Lamount.Text) <= 100000)
                        trackBar2.Value = Int32.Parse(Lamount.Text);
                }
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Interest.Text = trackBar3.Value.ToString();
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
                    if (Int32.Parse(Duration.Text) <= 40)
                        trackBar1.Value = Int32.Parse(Duration.Text);
                }
            }
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
                cn.Close();
                int oldBal = Int32.Parse(b);
                int withdraw = Int32.Parse(Lamount.Text);
                int newBal = oldBal - withdraw;
                if (newBal >= 200)
                {
                    SqlCommand cdd = new SqlCommand("update details set balance=@new where Username=@username and Accountno=@account");
                    cdd.Connection = cn;
                    cdd.Parameters.AddWithValue("@username", a);
                    cdd.Parameters.AddWithValue("@account", ano);
                    cdd.Parameters.AddWithValue("@new", newBal);
                    cn.Open();
                    cdd.ExecuteNonQuery();
                    cn.Close();

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

                    SqlCommand cdc = new SqlCommand("insert transactions values('" + i + "', '" + a + "', '" + ano + "', '" + "Bank" + "', '" + Lamount.Text + "', '" + DateTime.Today.ToString("dd/MM/yyyy") + "', '" + "Sip Amount" + "')");
                    cdc.Connection = cn;
                    try
                    {
                        cn.Open();
                        cdc.ExecuteNonQuery();
                        MessageBox.Show("Sip Successful!");
                        cn.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }
                }
                else
                { MessageBox.Show("Cannot go below the minimum balance of 200", "Insufficient Balance."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); cn.Close(); }
        }
    }
}
