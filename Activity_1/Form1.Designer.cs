namespace Activity_1
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
            this.FnameLbl = new System.Windows.Forms.Label();
            this.LnameLbl = new System.Windows.Forms.Label();
            this.DobLbl = new System.Windows.Forms.Label();
            this.FnameTxb = new System.Windows.Forms.TextBox();
            this.LnameTxb = new System.Windows.Forms.TextBox();
            this.DobTxb = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ResultTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FnameLbl
            // 
            this.FnameLbl.AutoSize = true;
            this.FnameLbl.Location = new System.Drawing.Point(71, 52);
            this.FnameLbl.Name = "FnameLbl";
            this.FnameLbl.Size = new System.Drawing.Size(72, 16);
            this.FnameLbl.TabIndex = 0;
            this.FnameLbl.Text = "First Name";
            // 
            // LnameLbl
            // 
            this.LnameLbl.AutoSize = true;
            this.LnameLbl.Location = new System.Drawing.Point(71, 92);
            this.LnameLbl.Name = "LnameLbl";
            this.LnameLbl.Size = new System.Drawing.Size(72, 16);
            this.LnameLbl.TabIndex = 1;
            this.LnameLbl.Text = "Last Name";
            // 
            // DobLbl
            // 
            this.DobLbl.AutoSize = true;
            this.DobLbl.Location = new System.Drawing.Point(71, 133);
            this.DobLbl.Name = "DobLbl";
            this.DobLbl.Size = new System.Drawing.Size(78, 16);
            this.DobLbl.TabIndex = 2;
            this.DobLbl.Text = "Year of birth";
            // 
            // FnameTxb
            // 
            this.FnameTxb.Location = new System.Drawing.Point(183, 46);
            this.FnameTxb.Name = "FnameTxb";
            this.FnameTxb.Size = new System.Drawing.Size(100, 22);
            this.FnameTxb.TabIndex = 3;
            // 
            // LnameTxb
            // 
            this.LnameTxb.Location = new System.Drawing.Point(183, 89);
            this.LnameTxb.Name = "LnameTxb";
            this.LnameTxb.Size = new System.Drawing.Size(100, 22);
            this.LnameTxb.TabIndex = 4;
            // 
            // DobTxb
            // 
            this.DobTxb.Location = new System.Drawing.Point(183, 130);
            this.DobTxb.Name = "DobTxb";
            this.DobTxb.Size = new System.Drawing.Size(100, 22);
            this.DobTxb.TabIndex = 5;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(94, 180);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(155, 34);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate my age";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ResultTxb
            // 
            this.ResultTxb.Location = new System.Drawing.Point(308, 92);
            this.ResultTxb.Name = "ResultTxb";
            this.ResultTxb.ReadOnly = true;
            this.ResultTxb.Size = new System.Drawing.Size(339, 22);
            this.ResultTxb.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 256);
            this.Controls.Add(this.ResultTxb);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.DobTxb);
            this.Controls.Add(this.LnameTxb);
            this.Controls.Add(this.FnameTxb);
            this.Controls.Add(this.DobLbl);
            this.Controls.Add(this.LnameLbl);
            this.Controls.Add(this.FnameLbl);
            this.Name = "Form1";
            this.Text = "Activity 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FnameLbl;
        private System.Windows.Forms.Label LnameLbl;
        private System.Windows.Forms.Label DobLbl;
        private System.Windows.Forms.TextBox FnameTxb;
        private System.Windows.Forms.TextBox LnameTxb;
        private System.Windows.Forms.TextBox DobTxb;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox ResultTxb;
    }
}

