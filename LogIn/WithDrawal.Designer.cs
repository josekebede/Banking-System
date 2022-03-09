namespace LogIn
{
    partial class WithDrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithDrawal));
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textAccountNo = new System.Windows.Forms.TextBox();
            this.textWithdrawAmount = new System.Windows.Forms.TextBox();
            this.dataGridWithdraw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWithdraw)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.Color.Black;
            this.buttonWithdraw.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("buttonWithdraw.Image")));
            this.buttonWithdraw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonWithdraw.Location = new System.Drawing.Point(375, 200);
            this.buttonWithdraw.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(142, 35);
            this.buttonWithdraw.TabIndex = 2;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(250, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Account No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(250, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Withdraw Amount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textAccountNo
            // 
            this.textAccountNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textAccountNo.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAccountNo.Location = new System.Drawing.Point(472, 64);
            this.textAccountNo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textAccountNo.Name = "textAccountNo";
            this.textAccountNo.Size = new System.Drawing.Size(180, 32);
            this.textAccountNo.TabIndex = 10;
            // 
            // textWithdrawAmount
            // 
            this.textWithdrawAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textWithdrawAmount.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWithdrawAmount.Location = new System.Drawing.Point(472, 128);
            this.textWithdrawAmount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textWithdrawAmount.Name = "textWithdrawAmount";
            this.textWithdrawAmount.Size = new System.Drawing.Size(180, 32);
            this.textWithdrawAmount.TabIndex = 13;
            // 
            // dataGridWithdraw
            // 
            this.dataGridWithdraw.AllowUserToAddRows = false;
            this.dataGridWithdraw.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridWithdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWithdraw.Location = new System.Drawing.Point(117, 286);
            this.dataGridWithdraw.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridWithdraw.Name = "dataGridWithdraw";
            this.dataGridWithdraw.RowTemplate.Height = 46;
            this.dataGridWithdraw.Size = new System.Drawing.Size(643, 241);
            this.dataGridWithdraw.TabIndex = 16;
            this.dataGridWithdraw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWithdraw_CellContentClick_1);
            // 
            // WithDrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 517);
            this.Controls.Add(this.dataGridWithdraw);
            this.Controls.Add(this.textWithdrawAmount);
            this.Controls.Add(this.textAccountNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "WithDrawal";
            this.Text = "WithDrawal";
            this.Load += new System.EventHandler(this.WithDrawal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWithdraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAccountNo;
        private System.Windows.Forms.TextBox textWithdrawAmount;
        private System.Windows.Forms.DataGridView dataGridWithdraw;
    }
}