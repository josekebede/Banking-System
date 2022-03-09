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
using System.IO;

namespace LogIn
{
    public partial class CustomerDetials : Form
    {
        public CustomerDetials()
        {
            InitializeComponent();
        }

        public void viewDGV()
        {
            String Constr = "Server=.; Database=MyVsR1; Integrated Security=true";
            SqlConnection con = new SqlConnection(Constr);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NewAccount", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "NewAccount");
            dataGridCustomerDetails.DataSource = ds.Tables["NewAccount"];
            con.Close();
        }

        private void CustomerDetials_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Width = SystemInformation.PrimaryMonitorSize.Width;
            Height = SystemInformation.PrimaryMonitorSize.Height;

            viewDGV();

            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String Query = "select * from NewAccount " + "WHERE AccountNumber=" + textEnterAccountNo.Text;
            String Constr = "Server=.; Database=MyVsR1; Integrated Security=true";
            SqlConnection Con = new SqlConnection(Constr);
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "MyVsR1");
            dataGridCustomerDetails.DataSource = ds.Tables["MyVsR1"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
