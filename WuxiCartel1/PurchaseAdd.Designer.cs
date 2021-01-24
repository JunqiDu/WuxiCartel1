namespace WuxiCartel1
{
    partial class PurchaseAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseAdd));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBPurchaseID = new System.Windows.Forms.TextBox();
            this.tBPurchaseDate = new System.Windows.Forms.TextBox();
            this.tBSupplierName = new System.Windows.Forms.TextBox();
            this.tBShipDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialID,
            this.materialName,
            this.materialSpecification,
            this.materialUnit,
            this.materialNum,
            this.materialPrice});
            this.dataGridView1.Location = new System.Drawing.Point(52, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 289);
            this.dataGridView1.TabIndex = 36;
            // 
            // materialID
            // 
            this.materialID.HeaderText = "物料号";
            this.materialID.Name = "materialID";
            // 
            // materialName
            // 
            this.materialName.HeaderText = "品名";
            this.materialName.Name = "materialName";
            // 
            // materialSpecification
            // 
            this.materialSpecification.HeaderText = "采购规格";
            this.materialSpecification.Name = "materialSpecification";
            // 
            // materialUnit
            // 
            this.materialUnit.HeaderText = "单位";
            this.materialUnit.Name = "materialUnit";
            // 
            // materialNum
            // 
            this.materialNum.HeaderText = "数量";
            this.materialNum.Name = "materialNum";
            // 
            // materialPrice
            // 
            this.materialPrice.HeaderText = "单价";
            this.materialPrice.Name = "materialPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(181, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 35;
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
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBPurchaseID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBPurchaseDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBSupplierName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBShipDate, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 45);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "单号";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "采购日期";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "供应商";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "交货日期";
            // 
            // tBPurchaseID
            // 
            this.tBPurchaseID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBPurchaseID.Location = new System.Drawing.Point(163, 3);
            this.tBPurchaseID.Name = "tBPurchaseID";
            this.tBPurchaseID.Size = new System.Drawing.Size(100, 21);
            this.tBPurchaseID.TabIndex = 4;
            // 
            // tBPurchaseDate
            // 
            this.tBPurchaseDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBPurchaseDate.Location = new System.Drawing.Point(483, 3);
            this.tBPurchaseDate.Name = "tBPurchaseDate";
            this.tBPurchaseDate.Size = new System.Drawing.Size(100, 21);
            this.tBPurchaseDate.TabIndex = 5;
            // 
            // tBSupplierName
            // 
            this.tBSupplierName.Location = new System.Drawing.Point(163, 25);
            this.tBSupplierName.Name = "tBSupplierName";
            this.tBSupplierName.Size = new System.Drawing.Size(100, 21);
            this.tBSupplierName.TabIndex = 6;
            // 
            // tBShipDate
            // 
            this.tBShipDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBShipDate.Location = new System.Drawing.Point(483, 25);
            this.tBShipDate.Name = "tBShipDate";
            this.tBShipDate.Size = new System.Drawing.Size(100, 21);
            this.tBShipDate.TabIndex = 7;
            // 
            // PurchaseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseAdd";
            this.Text = "无锡卡特尔科技有限公司——销售部";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialSpecification;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBPurchaseID;
        private System.Windows.Forms.TextBox tBPurchaseDate;
        private System.Windows.Forms.TextBox tBSupplierName;
        private System.Windows.Forms.TextBox tBShipDate;
    }
}