namespace ListAndEditForm1.Result
{
    partial class StaticResult
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
            this.dataGridViewStaticByCourse = new System.Windows.Forms.DataGridView();
            this.labelFail = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaticByCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStaticByCourse
            // 
            this.dataGridViewStaticByCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStaticByCourse.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewStaticByCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaticByCourse.Location = new System.Drawing.Point(137, 135);
            this.dataGridViewStaticByCourse.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStaticByCourse.Name = "dataGridViewStaticByCourse";
            this.dataGridViewStaticByCourse.RowHeadersWidth = 51;
            this.dataGridViewStaticByCourse.Size = new System.Drawing.Size(371, 378);
            this.dataGridViewStaticByCourse.TabIndex = 9;
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFail.Location = new System.Drawing.Point(613, 202);
            this.labelFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(49, 35);
            this.labelFail.TabIndex = 8;
            this.labelFail.Text = "Fail:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(613, 152);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(65, 35);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Pass:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Static By Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Static By Course";
            // 
            // StaticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 617);
            this.Controls.Add(this.dataGridViewStaticByCourse);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaticResult";
            this.Text = "StaticResult";
            this.Load += new System.EventHandler(this.StaticResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaticByCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStaticByCourse;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}