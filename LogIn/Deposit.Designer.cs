namespace LogIn
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.dataGridDeposit = new System.Windows.Forms.DataGridView();
            this.textDepositAmount = new System.Windows.Forms.TextBox();
            this.textAccountNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDeposit
            // 
            this.dataGridDeposit.AllowUserToAddRows = false;
            this.dataGridDeposit.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeposit.Location = new System.Drawing.Point(81, 215);
            this.dataGridDeposit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridDeposit.Name = "dataGridDeposit";
            this.dataGridDeposit.RowTemplate.Height = 46;
            this.dataGridDeposit.Size = new System.Drawing.Size(702, 306);
            this.dataGridDeposit.TabIndex = 46;
            this.dataGridDeposit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textDepositAmount
            // 
            this.textDepositAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textDepositAmount.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepositAmount.Location = new System.Drawing.Point(434, 102);
            this.textDepositAmount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textDepositAmount.Name = "textDepositAmount";
            this.textDepositAmount.Size = new System.Drawing.Size(167, 32);
            this.textDepositAmount.TabIndex = 43;
            // 
            // textAccountNo
            // 
            this.textAccountNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textAccountNo.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAccountNo.Location = new System.Drawing.Point(432, 57);
            this.textAccountNo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textAccountNo.Name = "textAccountNo";
            this.textAccountNo.Size = new System.Drawing.Size(169, 32);
            this.textAccountNo.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(200, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 27);
            this.label6.TabIndex = 39;
            this.label6.Text = "Deposited Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(205, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "Enter Account No.";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.Black;
            this.buttonDeposit.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonDeposit.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeposit.Image")));
            this.buttonDeposit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDeposit.Location = new System.Drawing.Point(370, 151);
            this.buttonDeposit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(142, 35);
            this.buttonDeposit.TabIndex = 33;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 607);
            this.Controls.Add(this.dataGridDeposit);
            this.Controls.Add(this.textDepositAmount);
            this.Controls.Add(this.textAccountNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeposit);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridDeposit;
        private System.Windows.Forms.TextBox textDepositAmount;
        private System.Windows.Forms.TextBox textAccountNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeposit;
    }
}