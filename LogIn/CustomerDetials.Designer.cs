namespace LogIn
{
    partial class CustomerDetials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetials));
            this.dataGridCustomerDetails = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textEnterAccountNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCustomerDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCustomerDetails
            // 
            this.dataGridCustomerDetails.AllowUserToAddRows = false;
            this.dataGridCustomerDetails.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridCustomerDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomerDetails.Location = new System.Drawing.Point(136, 217);
            this.dataGridCustomerDetails.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridCustomerDetails.Name = "dataGridCustomerDetails";
            this.dataGridCustomerDetails.RowTemplate.Height = 46;
            this.dataGridCustomerDetails.Size = new System.Drawing.Size(1039, 364);
            this.dataGridCustomerDetails.TabIndex = 1;
            this.dataGridCustomerDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomerDetails_CellContentClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearch.Location = new System.Drawing.Point(826, 160);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(103, 33);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(353, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Account No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textEnterAccountNo
            // 
            this.textEnterAccountNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textEnterAccountNo.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEnterAccountNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEnterAccountNo.Location = new System.Drawing.Point(661, 158);
            this.textEnterAccountNo.Margin = new System.Windows.Forms.Padding(1);
            this.textEnterAccountNo.Name = "textEnterAccountNo";
            this.textEnterAccountNo.Size = new System.Drawing.Size(143, 35);
            this.textEnterAccountNo.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelCustomerDetails);
            this.panel1.Location = new System.Drawing.Point(104, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 137);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelCustomerDetails
            // 
            this.labelCustomerDetails.AutoSize = true;
            this.labelCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerDetails.Font = new System.Drawing.Font("Algerian", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelCustomerDetails.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCustomerDetails.Location = new System.Drawing.Point(299, 56);
            this.labelCustomerDetails.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCustomerDetails.Name = "labelCustomerDetails";
            this.labelCustomerDetails.Size = new System.Drawing.Size(556, 63);
            this.labelCustomerDetails.TabIndex = 0;
            this.labelCustomerDetails.Text = "Customer Details";
            // 
            // CustomerDetials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textEnterAccountNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridCustomerDetails);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CustomerDetials";
            this.Text = "CustomerDetials";
            this.Load += new System.EventHandler(this.CustomerDetials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridCustomerDetails;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEnterAccountNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCustomerDetails;
    }
}