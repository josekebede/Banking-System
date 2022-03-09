using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LogIn
{
    public partial class Deposit : Form
    {
     
        public Deposit()
        {
            InitializeComponent();
        }

        public void viewDGV()
        {
            String Constr = "Server=(Local); Database=MyVsR1; Integrated Security=true";
            SqlConnection con = new SqlConnection(Constr);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select AccountNumber, FirstName, LastName , PhoneNumber, Balances from NewAccount", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "NewAccount");
            dataGridDeposit.DataSource = ds.Tables["NewAccount"];
            con.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textAccountNo.Text = dataGridDeposit.CurrentRow.Cells[0].Value.ToString();
           

        }


        private void DisplayData()
        {

            String Spath = "server=(local); database = MyVsR1; integrated security = true";
            SqlConnection con = new SqlConnection(Spath);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AccountNumber, FirstName, LastName , PhoneNumber, Balances from NewAccount", con);
            da.Fill(dt);
            dataGridDeposit.DataSource = dt;
            con.Close();
        }


        private void ClearData()
        {
            textAccountNo.Text = "";
            textDepositAmount.Text = "";
            

        }




        private void buttonDeposit_Click(object sender, EventArgs e)
        {           

            string path = "Server=(local); database=MyVsR1; Integrated Security=True ";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Querey = "EXEC sp_deposit " + 
            "@AccountNo, @DepositAmount";
            SqlCommand scmd = new SqlCommand(Querey, con);
            
            scmd.Parameters.AddWithValue("@AccountNo", textAccountNo.Text);
            scmd.Parameters.AddWithValue("@DepositAmount", textDepositAmount.Text);
            scmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            ClearData();

            MessageBox.Show("Deposited Successful");


        }
    }
}
