namespace LogIn
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonCustomerDetails = new System.Windows.Forms.Button();
            this.buttonUpdateDelete = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelBankOfMyVsR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.buttonLogOut);
            this.panel3.Controls.Add(this.buttonTransaction);
            this.panel3.Controls.Add(this.buttonCustomerDetails);
            this.panel3.Controls.Add(this.buttonUpdateDelete);
            this.panel3.Controls.Add(this.buttonCreateAccount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 784);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.BackgroundImage")));
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogOut.Font = new System.Drawing.Font("Perpetua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 741);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(179, 43);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.BackColor = System.Drawing.Color.Transparent;
            this.buttonTransaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTransaction.BackgroundImage")));
            this.buttonTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTransaction.FlatAppearance.BorderSize = 0;
            this.buttonTransaction.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransaction.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransaction.ForeColor = System.Drawing.Color.White;
            this.buttonTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTransaction.Location = new System.Drawing.Point(1, 503);
            this.buttonTransaction.Margin = new System.Windows.Forms.Padding(1);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(165, 65);
            this.buttonTransaction.TabIndex = 3;
            this.buttonTransaction.Text = "Transaction";
            this.buttonTransaction.UseVisualStyleBackColor = false;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonCustomerDetails
            // 
            this.buttonCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCustomerDetails.BackgroundImage")));
            this.buttonCustomerDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCustomerDetails.FlatAppearance.BorderSize = 0;
            this.buttonCustomerDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerDetails.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.buttonCustomerDetails.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCustomerDetails.Location = new System.Drawing.Point(13, 359);
            this.buttonCustomerDetails.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCustomerDetails.Name = "buttonCustomerDetails";
            this.buttonCustomerDetails.Size = new System.Drawing.Size(136, 65);
            this.buttonCustomerDetails.TabIndex = 2;
            this.buttonCustomerDetails.Text = "Customer Details";
            this.buttonCustomerDetails.UseVisualStyleBackColor = false;
            this.buttonCustomerDetails.Click += new System.EventHandler(this.buttonCustomerDetails_Click);
            // 
            // buttonUpdateDelete
            // 
            this.buttonUpdateDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdateDelete.BackgroundImage")));
            this.buttonUpdateDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUpdateDelete.FlatAppearance.BorderSize = 0;
            this.buttonUpdateDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateDelete.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateDelete.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUpdateDelete.Location = new System.Drawing.Point(13, 214);
            this.buttonUpdateDelete.Margin = new System.Windows.Forms.Padding(1);
            this.buttonUpdateDelete.Name = "buttonUpdateDelete";
            this.buttonUpdateDelete.Size = new System.Drawing.Size(137, 65);
            this.buttonUpdateDelete.TabIndex = 1;
            this.buttonUpdateDelete.Text = "Update  / Delete";
            this.buttonUpdateDelete.UseVisualStyleBackColor = false;
            this.buttonUpdateDelete.Click += new System.EventHandler(this.buttonUpdateDelete_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCreateAccount.BackgroundImage")));
            this.buttonCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCreateAccount.FlatAppearance.BorderSize = 0;
            this.buttonCreateAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCreateAccount.Location = new System.Drawing.Point(13, 79);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(145, 69);
            this.buttonCreateAccount.TabIndex = 0;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // labelBankOfMyVsR
            // 
            this.labelBankOfMyVsR.AutoSize = true;
            this.labelBankOfMyVsR.BackColor = System.Drawing.Color.Transparent;
            this.labelBankOfMyVsR.Font = new System.Drawing.Font("Perpetua", 56F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBankOfMyVsR.ForeColor = System.Drawing.Color.White;
            this.labelBankOfMyVsR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBankOfMyVsR.Location = new System.Drawing.Point(567, 18);
            this.labelBankOfMyVsR.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBankOfMyVsR.Name = "labelBankOfMyVsR";
            this.labelBankOfMyVsR.Size = new System.Drawing.Size(628, 108);
            this.labelBankOfMyVsR.TabIndex = 2;
            this.labelBankOfMyVsR.Text = "Bank Of MyVsR";
            this.labelBankOfMyVsR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.labelBankOfMyVsR);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1819, 138);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 482);
            this.panel2.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1819, 922);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Button buttonCustomerDetails;
        private System.Windows.Forms.Button buttonUpdateDelete;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelBankOfMyVsR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}