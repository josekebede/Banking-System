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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transact.Controls.Clear();
            Deposit d = new Deposit();
            d.FormBorderStyle = FormBorderStyle.None;
            d.TopLevel = false;
            d.AutoScroll = true;
            Transact.Controls.Add(d);
            d.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transact.Controls.Clear();
            WithDrawal w = new WithDrawal();
            w.FormBorderStyle = FormBorderStyle.None;
            w.TopLevel = false;
            w.AutoScroll = true;
            Transact.Controls.Add(w);
            w.Show();


        }
    }
}
