namespace LogIn
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Transact = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonWithdraw);
            this.panel2.Controls.Add(this.Deposit);
            this.panel2.Location = new System.Drawing.Point(152, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 462);
            this.panel2.TabIndex = 1;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonWithdraw.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("buttonWithdraw.Image")));
            this.buttonWithdraw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonWithdraw.Location = new System.Drawing.Point(1, 279);
            this.buttonWithdraw.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(117, 35);
            this.buttonWithdraw.TabIndex = 1;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.GhostWhite;
            this.Deposit.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deposit.Image = ((System.Drawing.Image)(resources.GetObject("Deposit.Image")));
            this.Deposit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deposit.Location = new System.Drawing.Point(5, 149);
            this.Deposit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(117, 35);
            this.Deposit.TabIndex = 0;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transact
            // 
            this.Transact.BackColor = System.Drawing.Color.Transparent;
            this.Transact.Location = new System.Drawing.Point(280, 26);
            this.Transact.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Transact.Name = "Transact";
            this.Transact.Size = new System.Drawing.Size(838, 553);
            this.Transact.TabIndex = 2;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.Transact);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Panel Transact;
    }
}