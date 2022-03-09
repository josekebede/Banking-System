namespace LogIn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelWelcomeToBankOfMyVsR = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboPosition = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.panelWelcomeToBankOfMyVsR.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcomeToBankOfMyVsR
            // 
            this.panelWelcomeToBankOfMyVsR.BackColor = System.Drawing.Color.White;
            this.panelWelcomeToBankOfMyVsR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelWelcomeToBankOfMyVsR.BackgroundImage")));
            this.panelWelcomeToBankOfMyVsR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWelcomeToBankOfMyVsR.Controls.Add(this.flowLayoutPanel1);
            this.panelWelcomeToBankOfMyVsR.Controls.Add(this.comboPosition);
            this.panelWelcomeToBankOfMyVsR.Controls.Add(this.txtPosition);
            this.panelWelcomeToBankOfMyVsR.Controls.Add(this.textPassword);
            this.panelWelcomeToBankOfMyVsR.Controls.Add(this.textUserName);
            this.panelWelcomeToBankOfMyVsR.Controls.Add(this.txtPassword);
            this.panelWelcomeToBankOfMyVsR.Controls.Add(this.txtUserName);
            this.panelWelcomeToBankOfMyVsR.Controls.Add(this.buttonLogIn);
            this.panelWelcomeToBankOfMyVsR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWelcomeToBankOfMyVsR.Location = new System.Drawing.Point(0, 0);
            this.panelWelcomeToBankOfMyVsR.Margin = new System.Windows.Forms.Padding(1);
            this.panelWelcomeToBankOfMyVsR.Name = "panelWelcomeToBankOfMyVsR";
            this.panelWelcomeToBankOfMyVsR.Size = new System.Drawing.Size(1355, 970);
            this.panelWelcomeToBankOfMyVsR.TabIndex = 0;
            this.panelWelcomeToBankOfMyVsR.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1355, 28);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1322, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboPosition
            // 
            this.comboPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboPosition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboPosition.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPosition.FormattingEnabled = true;
            this.comboPosition.Items.AddRange(new object[] {
            "Administrator",
            "Cashier",
            "Receptionist"});
            this.comboPosition.Location = new System.Drawing.Point(471, 441);
            this.comboPosition.Margin = new System.Windows.Forms.Padding(1);
            this.comboPosition.Name = "comboPosition";
            this.comboPosition.Size = new System.Drawing.Size(325, 56);
            this.comboPosition.TabIndex = 8;
            this.comboPosition.SelectedIndexChanged += new System.EventHandler(this.comboPosition_SelectedIndexChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPosition.AutoSize = true;
            this.txtPosition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPosition.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPosition.Image = ((System.Drawing.Image)(resources.GetObject("txtPosition.Image")));
            this.txtPosition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtPosition.Location = new System.Drawing.Point(133, 447);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(191, 52);
            this.txtPosition.TabIndex = 7;
            this.txtPosition.Text = "Position";
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textPassword.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(471, 345);
            this.textPassword.Margin = new System.Windows.Forms.Padding(1);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(325, 56);
            this.textPassword.TabIndex = 5;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // textUserName
            // 
            this.textUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUserName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textUserName.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(471, 240);
            this.textUserName.Margin = new System.Windows.Forms.Padding(1);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(325, 56);
            this.textUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.AutoSize = true;
            this.txtPassword.BackColor = System.Drawing.Color.DimGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPassword.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Image = ((System.Drawing.Image)(resources.GetObject("txtPassword.Image")));
            this.txtPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtPassword.Location = new System.Drawing.Point(97, 348);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 54);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.AutoSize = true;
            this.txtUserName.BackColor = System.Drawing.Color.DimGray;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtUserName.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Image = ((System.Drawing.Image)(resources.GetObject("txtUserName.Image")));
            this.txtUserName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtUserName.Location = new System.Drawing.Point(75, 244);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 54);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "User Name";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogIn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLogIn.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogIn.Image")));
            this.buttonLogIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogIn.Location = new System.Drawing.Point(295, 586);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(309, 74);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 970);
            this.Controls.Add(this.panelWelcomeToBankOfMyVsR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWelcomeToBankOfMyVsR.ResumeLayout(false);
            this.panelWelcomeToBankOfMyVsR.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcomeToBankOfMyVsR;
        private System.Windows.Forms.ComboBox comboPosition;
        private System.Windows.Forms.Label txtPosition;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

