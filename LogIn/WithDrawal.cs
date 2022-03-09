using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogIn
{              
    public partial class WithDrawal : Form
    {
        public WithDrawal()
        {
            InitializeComponent();
        }

        public void viewDGV()
        {
            String Constr = "Server=(Local); Database=MyVsR1; Integrated Security=true";
            SqlConnection con = new SqlConnection(Constr);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select AccountNumber, FirstName, LastName, PhoneNumber, Balances From NewAccount", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "NewAccount");
            dataGridWithdraw.DataSource = ds.Tables["NewAccount"];
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void WithDrawal_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            Top = 0;
            Left = 0;
            Width = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width;
            Height = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height;

            viewDGV();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {

            String Spath = "server=(local); database = MyVsR1; integrated security = true";
            SqlConnection con = new SqlConnection(Spath);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AccountNumber, FirstName, LastName , PhoneNumber, Balances from NewAccount", con);
            da.Fill(dt);
            dataGridWithdraw.DataSource = dt;
            con.Close();
        }


        private void ClearData()
        {
            textAccountNo.Text = "";
            textWithdrawAmount.Text = "";


        }


        private void buttonWithdraw_Click_1(object sender, EventArgs e)
        {
            string path = "Server=(local); database=MyVsR1; Integrated Security=True ";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Querey = "EXEC sp_withdraw " +
            "@AccountNo, @WithdrawAmount";
            SqlCommand scmd = new SqlCommand(Querey, con);

            scmd.Parameters.AddWithValue("@AccountNo", textAccountNo.Text);         
            scmd.Parameters.AddWithValue("@withdrawAmount", textWithdrawAmount.Text);
            scmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            ClearData();

            MessageBox.Show("Withdraw Successful");
        }

        private void dataGridWithdraw_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textAccountNo.Text = dataGridWithdraw.CurrentRow.Cells[0].Value.ToString();
            
        }
    }
}
