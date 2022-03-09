using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
           NewAccount Form1 = new NewAccount();
            Form1.MdiParent = this;
            Form1.Show();

        }

        private void buttonUpdateDelete_Click(object sender, EventArgs e)
        {


            this.IsMdiContainer = true;
            UpdateAndDelete Form2 = new UpdateAndDelete();
            Form2.MdiParent = this;
            Form2.Show();
            


        }

        private void buttonCustomerDetails_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            CustomerDetials Form3 = new CustomerDetials();
            Form3.MdiParent = this;
            Form3.Show();

        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Transaction Form4 = new Transaction();
            Form4.MdiParent = this;
            Form4.Show();


            Top = 0;
            Left = 0;
            Width = SystemInformation.PrimaryMonitorSize.Width;
            Height = SystemInformation.PrimaryMonitorSize.Height;
        }

       

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Width = SystemInformation.PrimaryMonitorSize.Width;
            Height = SystemInformation.PrimaryMonitorSize.Height;

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();                    
            n.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
