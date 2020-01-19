namespace store
{
    partial class adminDeshboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDItem = new System.Windows.Forms.Button();
            this.btnDUser = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtDItem = new System.Windows.Forms.TextBox();
            this.txtDUser = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtItemRs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Items";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDItem
            // 
            this.btnDItem.Location = new System.Drawing.Point(36, 313);
            this.btnDItem.Name = "btnDItem";
            this.btnDItem.Size = new System.Drawing.Size(75, 23);
            this.btnDItem.TabIndex = 2;
            this.btnDItem.Text = "Delete Item";
            this.btnDItem.UseVisualStyleBackColor = true;
            this.btnDItem.Click += new System.EventHandler(this.btnDItem_Click);
            // 
            // btnDUser
            // 
            this.btnDUser.Location = new System.Drawing.Point(36, 408);
            this.btnDUser.Name = "btnDUser";
            this.btnDUser.Size = new System.Drawing.Size(75, 23);
            this.btnDUser.TabIndex = 3;
            this.btnDUser.Text = "Delete User";
            this.btnDUser.UseVisualStyleBackColor = true;
            this.btnDUser.Click += new System.EventHandler(this.btnDUser_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(36, 92);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(157, 20);
            this.txtItemName.TabIndex = 4;
            // 
            // txtDItem
            // 
            this.txtDItem.Location = new System.Drawing.Point(36, 287);
            this.txtDItem.Name = "txtDItem";
            this.txtDItem.Size = new System.Drawing.Size(157, 20);
            this.txtDItem.TabIndex = 5;
            // 
            // txtDUser
            // 
            this.txtDUser.Location = new System.Drawing.Point(36, 382);
            this.txtDUser.Name = "txtDUser";
            this.txtDUser.Size = new System.Drawing.Size(157, 20);
            this.txtDUser.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(350, 231);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(438, 181);
            this.dataGridView2.TabIndex = 7;
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(36, 142);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(157, 20);
            this.txtItemType.TabIndex = 8;
            this.txtItemType.TextChanged += new System.EventHandler(this.txtItemType_TextChanged);
            // 
            // txtItemRs
            // 
            this.txtItemRs.Location = new System.Drawing.Point(36, 181);
            this.txtItemRs.Name = "txtItemRs";
            this.txtItemRs.Size = new System.Drawing.Size(157, 20);
            this.txtItemRs.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rs.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Item Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "User Name";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(713, 418);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 15;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(36, 43);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(157, 20);
            this.txtItemCode.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Item Code";
            // 
            // adminDeshboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemRs);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtDUser);
            this.Controls.Add(this.txtDItem);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnDUser);
            this.Controls.Add(this.btnDItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "adminDeshboard";
            this.Text = "adminDeshboard";
            this.Load += new System.EventHandler(this.adminDeshboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDItem;
        private System.Windows.Forms.Button btnDUser;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtDItem;
        private System.Windows.Forms.TextBox txtDUser;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtItemRs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label6;
    }
}