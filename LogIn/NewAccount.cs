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
using System.Web;
using System.Configuration;


namespace LogIn
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        public void AccId()
        {
            string path = "Server=(local); database=MyVsR1; Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "select max(AccountNumber) from NewAccount ";
            SqlCommand cmd = new SqlCommand(Query, con);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textAccountNo.Text = "10000";
                }
                else
                {
                    int a;

                    a = int.Parse(dr[0].ToString());
                    a = a + 1;
                    textAccountNo.Text = a.ToString();

                }
                con.Close();
            }
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;



            Top = 0;
            Left = 0;
            Width = SystemInformation.PrimaryMonitorSize.Width;
            Height = SystemInformation.PrimaryMonitorSize.Height;

            AccId();

        }





        private void ClearData()
        {
            
            textFirstName.Text = " ";
            textLastName.Text = " ";
            comboGender.Text = "";
            comboMonth.Text = "";
            comboDay.Text = "";
            comboYear.Text = "";
            textAge.Text = "";
            //textAddress.Text = "";
            //textNationality.Text = "";
            textPhoneNo.Text = "";
            textEmail.Text = "";
            comboMartialStatus.Text = "";
            textBalance.Text = "";
            pictureNewAccount.ImageLocation = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int month = 0;
            if (comboMonth.Text == "January")
                month = 1;
            else if (comboMonth.Text == "February")
                month = 2;
            else if (comboMonth.Text == "March")
                month = 3;
            else if (comboMonth.Text == "April")
                month = 4;
            else if (comboMonth.Text == "May")
                month = 5;
            else if (comboMonth.Text == "June")
                month = 6;
            else if (comboMonth.Text == "July")
                month = 7;
            else if (comboMonth.Text == "August")
                month = 8;
            else if (comboMonth.Text == "September")
                month = 9;
            else if (comboMonth.Text == "October")
                month = 10;
            else if (comboMonth.Text == "November")
                month = 11;
            else
                month = 12;
            string date;
            date = string.Format("{0}-{1}-{2}", month.ToString(), comboDay.Text, comboYear.Text);
            
            string path = "Server=(local); database=MyVsR1; Integrated Security=True ";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            MemoryStream ms = new MemoryStream();
            pictureNewAccount.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = ms.ToArray();
            string Querey = "EXEC sp_add_account" +
            " @AccountNumber,@FirstName,@LastName, @Gender,@DOB, @Adress,@Nationality,@PhoneNumber,@Email,@MartialStatus,@Balances,@Pictures";
            SqlCommand scmd = new SqlCommand(Querey, con);
            scmd.Parameters.AddWithValue("@AccountNumber", textAccountNo.Text);
            scmd.Parameters.AddWithValue("@FirstName", textFirstName.Text);
            scmd.Parameters.AddWithValue("@LastName", textLastName.Text);
            scmd.Parameters.AddWithValue("@Gender", comboGender.Text);
            scmd.Parameters.AddWithValue("@DOB", date);
            scmd.Parameters.AddWithValue("@Adress", textAddress.Text);
            scmd.Parameters.AddWithValue("@Nationality", textNationality.Text);
            scmd.Parameters.AddWithValue("@PhoneNumber", textPhoneNo.Text);
            scmd.Parameters.AddWithValue("@Email", textEmail.Text);
            scmd.Parameters.AddWithValue("@MartialStatus", comboMartialStatus.Text);
            scmd.Parameters.AddWithValue("@Balances", textBalance.Text);
            scmd.Parameters.AddWithValue("@Pictures", pic);
            scmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save Successful");
            ClearData();

        }


        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            string str = textFirstName.Text.Substring(0, 1).ToUpper() +
                        textFirstName.Text.Substring(1).ToLower();
            

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {
            string str = textLastName.Text.Substring(0, 1).ToUpper() +
                       textLastName.Text.Substring(1).ToLower();
            

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {
            string str = textAddress.Text.Substring(0, 1).ToUpper() +
                         textAddress.Text.Substring(1).ToLower();
            

        }

        private void textNationality_TextChanged(object sender, EventArgs e)
        {
            string str = textNationality.Text.Substring(0, 1).ToUpper() +
                         textNationality.Text.Substring(1).ToLower();
            

        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "[JPG,PNG]|*.jpg;.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureNewAccount.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void pictureNewAccount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
