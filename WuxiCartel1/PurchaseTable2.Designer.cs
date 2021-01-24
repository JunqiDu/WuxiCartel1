namespace WuxiCartel1
{
    partial class PurchaseTable2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseTable2));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierSelfPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(196, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "仓库信息";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "供应商信息";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "采购单";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierName,
            this.supplierContact,
            this.supplierPhoneNum,
            this.supplierSelfPhoneNum,
            this.supplierEmail,
            this.supplierAddress,
            this.supplierRemark});
            this.dataGridView1.Location = new System.Drawing.Point(52, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(743, 289);
            this.dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(181, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "无锡卡特尔科技有限公司";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WuxiCartel1.Properties.Resources.卡特尔LOGO_2_0;
            this.pictureBox1.Location = new System.Drawing.Point(57, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // supplierName
            // 
            this.supplierName.HeaderText = "公司";
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            // 
            // supplierContact
            // 
            this.supplierContact.HeaderText = "联系人";
            this.supplierContact.Name = "supplierContact";
            this.supplierContact.ReadOnly = true;
            // 
            // supplierPhoneNum
            // 
            this.supplierPhoneNum.HeaderText = "座机";
            this.supplierPhoneNum.Name = "supplierPhoneNum";
            this.supplierPhoneNum.ReadOnly = true;
            // 
            // supplierSelfPhoneNum
            // 
            this.supplierSelfPhoneNum.HeaderText = "手机";
            this.supplierSelfPhoneNum.Name = "supplierSelfPhoneNum";
            this.supplierSelfPhoneNum.ReadOnly = true;
            // 
            // supplierEmail
            // 
            this.supplierEmail.HeaderText = "邮箱";
            this.supplierEmail.Name = "supplierEmail";
            this.supplierEmail.ReadOnly = true;
            // 
            // supplierAddress
            // 
            this.supplierAddress.HeaderText = "地址";
            this.supplierAddress.Name = "supplierAddress";
            this.supplierAddress.ReadOnly = true;
            // 
            // supplierRemark
            // 
            this.supplierRemark.HeaderText = "备注";
            this.supplierRemark.Name = "supplierRemark";
            this.supplierRemark.ReadOnly = true;
            // 
            // PurchaseTable2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseTable2";
            this.Text = "无锡卡特尔科技有限公司——销售部";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierSelfPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierRemark;
    }
}