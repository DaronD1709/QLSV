namespace ListAndEditForm1.Admin
{
    partial class AccountManage
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Reject = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListofAccountsAwaitingApproval = new System.Windows.Forms.DataGridView();
            this.dataGridViewAccountManagement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListofAccountsAwaitingApproval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Delete.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(1108, 678);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(188, 50);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete Account";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Manage Account ";
            // 
            // btn_Reject
            // 
            this.btn_Reject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Reject.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reject.Location = new System.Drawing.Point(1173, 322);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.Size = new System.Drawing.Size(123, 47);
            this.btn_Reject.TabIndex = 12;
            this.btn_Reject.Text = "Denine";
            this.btn_Reject.UseVisualStyleBackColor = false;
            this.btn_Reject.Click += new System.EventHandler(this.btn_Reject_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Accept.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accept.Location = new System.Drawing.Point(1025, 322);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(123, 47);
            this.btn_Accept.TabIndex = 11;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of accounts awaiting approval";
            // 
            // dataGridViewListofAccountsAwaitingApproval
            // 
            this.dataGridViewListofAccountsAwaitingApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListofAccountsAwaitingApproval.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewListofAccountsAwaitingApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListofAccountsAwaitingApproval.Location = new System.Drawing.Point(66, 55);
            this.dataGridViewListofAccountsAwaitingApproval.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewListofAccountsAwaitingApproval.Name = "dataGridViewListofAccountsAwaitingApproval";
            this.dataGridViewListofAccountsAwaitingApproval.RowHeadersWidth = 51;
            this.dataGridViewListofAccountsAwaitingApproval.Size = new System.Drawing.Size(1230, 249);
            this.dataGridViewListofAccountsAwaitingApproval.TabIndex = 15;
            // 
            // dataGridViewAccountManagement
            // 
            this.dataGridViewAccountManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccountManagement.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewAccountManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccountManagement.Location = new System.Drawing.Point(66, 410);
            this.dataGridViewAccountManagement.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAccountManagement.Name = "dataGridViewAccountManagement";
            this.dataGridViewAccountManagement.RowHeadersWidth = 51;
            this.dataGridViewAccountManagement.Size = new System.Drawing.Size(1230, 245);
            this.dataGridViewAccountManagement.TabIndex = 16;
            // 
            // AccountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 749);
            this.Controls.Add(this.dataGridViewAccountManagement);
            this.Controls.Add(this.dataGridViewListofAccountsAwaitingApproval);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Reject);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.label1);
            this.Name = "AccountManage";
            this.Text = "AccountManage";
            this.Load += new System.EventHandler(this.AccountManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListofAccountsAwaitingApproval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Reject;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListofAccountsAwaitingApproval;
        private System.Windows.Forms.DataGridView dataGridViewAccountManagement;
    }
}