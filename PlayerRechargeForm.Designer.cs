namespace GameManagementSystem
{
    partial class PlayerRechargeForm
    {
        private System.ComponentModel.IContainer components = null;

        // 释放资源
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPno = new System.Windows.Forms.Label();
            this.txtPno = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPno
            // 
            this.lblPno.AutoSize = true;
            this.lblPno.Location = new System.Drawing.Point(30, 30);
            this.lblPno.Name = "lblPno";
            this.lblPno.Size = new System.Drawing.Size(67, 15);
            this.lblPno.TabIndex = 0;
            this.lblPno.Text = "玩家号：";
            // 
            // txtPno
            // 
            this.txtPno.Location = new System.Drawing.Point(120, 25);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(150, 25);
            this.txtPno.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 70);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(82, 15);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "充值金额：";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(120, 65);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 25);
            this.txtAmount.TabIndex = 3;
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(50, 120);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(80, 30);
            this.btnRecharge.TabIndex = 4;
            this.btnRecharge.Text = "充值";
            this.btnRecharge.UseVisualStyleBackColor = true;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PlayerRechargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtPno);
            this.Controls.Add(this.lblPno);
            this.Name = "PlayerRechargeForm";
            this.Text = "玩家充值";
            this.Load += new System.EventHandler(this.PlayerRechargeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblPno;
        private System.Windows.Forms.TextBox txtPno;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.Button btnCancel;
    }
}
