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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            String query = "select * from Log_In"; 
            String Spath = "server=(local); database = MyVsR1; integrated security = true";
            SqlConnection con = new SqlConnection(Spath);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Log_In");
            DataTable dt = ds.Tables["Log_In"];
            foreach (DataRow dr in dt.Rows)
            {
                if (textUserName.Text.CompareTo(dr["UserName"]) == 0 && (textPassword.Text.CompareTo(dr["Passwords"]) == 0 && (comboPosition.Text.CompareTo(dr["Position"]) == 0)))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                MessageBox.Show("Login sucessful"); 
                new Menu().Show();
            }
            else
                MessageBox.Show("Invalid user");
            con.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void comboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Width = SystemInformation.PrimaryMonitorSize.Width;
            Height = SystemInformation.PrimaryMonitorSize.Height;

        }

        private void txtUserName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

