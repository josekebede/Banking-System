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
using System.Text.RegularExpressions;
namespace LogIn
{
    public partial class UpdateAndDelete : Form
    {             
        public UpdateAndDelete()
        {
            InitializeComponent();
                  
        }
        public void viewDGV()
        {
            SqlConnection con = new SqlConnection("Server=(Local); Database=MyVsR1; Integrated Security=true");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NewAccount", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "NewAccount");
            dataGridUpdateDelete.DataSource = ds.Tables["NewAccount"];          
            con.Close();
        }
        private void DisplayData()
        {

            String Spath = "server=(local); database = MyVsR1; integrated security = true";
            SqlConnection con = new SqlConnection(Spath);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from NewAccount", con);
            da.Fill(dt);
            dataGridUpdateDelete.DataSource = dt;
            con.Close();
        }


        private void ClearData()
        {
            textAccountNo.Text = "";
            textFirstName.Text = " ";
            textLastName.Text = " ";
            comboGender.Text = "";
            comboMonth.Text = "";
            comboDay.Text = "";
            comboYear.Text = "";
            textAge.Text = "";
            textAddress.Text = "";
            textNationality.Text = "";
            textPhoneNo.Text = "";
            textEmail.Text = "";
            comboMartialStatus.Text = "";
            textBalance.Text = "";
            pictureUpdateDelete.ImageLocation = "";


        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
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
            pictureUpdateDelete.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = ms.ToArray();
            string Querey = "EXEC sp_update_account" +
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
            MessageBox.Show("Update Successful");
            DisplayData();
            ClearData();           

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "[JPG,PNG]|*.jpg;.png";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
                pictureUpdateDelete.Image = Image.FromFile(openFileDialog2.FileName);
        }

        private void UpdateAndDelete_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            Top = 0;
            Left = 0;
            Width = SystemInformation.PrimaryMonitorSize.Width;
            Height = SystemInformation.PrimaryMonitorSize.Height;

            viewDGV();
            
        }
        private void dataGridUpdateDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string date = dataGridUpdateDelete.CurrentRow.Cells[4].Value.ToString();
            date = date.Substring(0, 10);
            MatchCollection matches = Regex.Matches(date, @"(\d+)");
            string month = matches[0].Value;
            string day = matches[1].Value;
            string year = matches[2].Value;

            textAccountNo.Text = dataGridUpdateDelete.CurrentRow.Cells[0].Value.ToString();
            textFirstName.Text = dataGridUpdateDelete.CurrentRow.Cells[1].Value.ToString();
            textLastName.Text = dataGridUpdateDelete.CurrentRow.Cells[2].Value.ToString();
            comboGender.Text = dataGridUpdateDelete.CurrentRow.Cells[3].Value.ToString();
            comboMonth.Text = month;
            comboDay.Text = day;
            comboYear.Text = year;
            textAge.Text = dataGridUpdateDelete.CurrentRow.Cells[5].Value.ToString();
            textAddress.Text = dataGridUpdateDelete.CurrentRow.Cells[6].Value.ToString();
            textNationality.Text = dataGridUpdateDelete.CurrentRow.Cells[7].Value.ToString();
            textPhoneNo.Text = dataGridUpdateDelete.CurrentRow.Cells[8].Value.ToString();
            textEmail.Text = dataGridUpdateDelete.CurrentRow.Cells[9].Value.ToString();
            comboMartialStatus.Text = dataGridUpdateDelete.CurrentRow.Cells[10].Value.ToString();
            textBalance.Text = dataGridUpdateDelete.CurrentRow.Cells[11].Value.ToString();
            var pic = (Byte[])(dataGridUpdateDelete.CurrentRow.Cells[12].Value);
            var stream = new MemoryStream(pic);
            pictureUpdateDelete.Image = Image.FromStream(stream);
        }
    
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            String Spath = "server=(local); database = MyVsR1; integrated security = true";
            SqlConnection con = new SqlConnection(Spath);
            con.Open();
            String Querey = "Delete NewAccount where Accountnumber=@AccountNumber";
            SqlCommand scmd = new SqlCommand(Querey, con);
            scmd.Parameters.AddWithValue("@AccountNumber", textAccountNo.Text);
            scmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Success!");
            DisplayData();
            ClearData();
        }
     
    private void dataGridUpdateDelete_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string date = dataGridUpdateDelete.CurrentRow.Cells[4].Value.ToString();
            date = date.Substring(0, 10);
            MatchCollection matches = Regex.Matches(date, @"(\d+)");

            string month = matches[0].Value;
            string day = matches[1].Value;
            string year = matches[2].Value;



            textAccountNo.Text = dataGridUpdateDelete.CurrentRow.Cells[0].Value.ToString();
            textFirstName.Text = dataGridUpdateDelete.CurrentRow.Cells[1].Value.ToString();
            textLastName.Text = dataGridUpdateDelete.CurrentRow.Cells[2].Value.ToString();
            comboGender.Text = dataGridUpdateDelete.CurrentRow.Cells[3].Value.ToString();
            comboMonth.Text = month;
            comboDay.Text = day;
            comboYear.Text = year;
            textAge.Text = dataGridUpdateDelete.CurrentRow.Cells[5].Value.ToString();
            textAddress.Text = dataGridUpdateDelete.CurrentRow.Cells[6].Value.ToString();
            textNationality.Text = dataGridUpdateDelete.CurrentRow.Cells[7].Value.ToString();
            textPhoneNo.Text = dataGridUpdateDelete.CurrentRow.Cells[8].Value.ToString();
            textEmail.Text = dataGridUpdateDelete.CurrentRow.Cells[9].Value.ToString();
            comboMartialStatus.Text = dataGridUpdateDelete.CurrentRow.Cells[10].Value.ToString();
            textBalance.Text = dataGridUpdateDelete.CurrentRow.Cells[11].Value.ToString();
            byte[] pic = Encoding.ASCII.GetBytes(dataGridUpdateDelete.CurrentRow.Cells[12].Value.ToString());
            MemoryStream ms = new MemoryStream(pic);
            pictureUpdateDelete.Image = Image.FromStream(ms);

        }

        private void pictureUpdateDelete_Click(object sender, EventArgs e)
        {

        }
    }
    }
