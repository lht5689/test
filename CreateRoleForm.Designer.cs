namespace GameManagementSystem
{
    partial class CreateRoleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblPno = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.lblRno = new System.Windows.Forms.Label();
            this.lblPrno = new System.Windows.Forms.Label();
            this.lblPrname = new System.Windows.Forms.Label();
            this.lblCdate = new System.Windows.Forms.Label();
            this.txtPno = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtRno = new System.Windows.Forms.TextBox();
            this.txtPrno = new System.Windows.Forms.TextBox();
            this.txtPrname = new System.Windows.Forms.TextBox();
            this.dtpCdate = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPno
            // 
            this.lblPno.AutoSize = true;
            this.lblPno.Location = new System.Drawing.Point(50, 30);
            this.lblPno.Name = "lblPno";
            this.lblPno.Size = new System.Drawing.Size(67, 15);
            this.lblPno.TabIndex = 0;
            this.lblPno.Text = "玩家号：";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Location = new System.Drawing.Point(50, 70);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(67, 15);
            this.lblPname.TabIndex = 1;
            this.lblPname.Text = "玩家名：";
            // 
            // lblRno
            // 
            this.lblRno.AutoSize = true;
            this.lblRno.Location = new System.Drawing.Point(50, 110);
            this.lblRno.Name = "lblRno";
            this.lblRno.Size = new System.Drawing.Size(97, 15);
            this.lblRno.TabIndex = 2;
            this.lblRno.Text = "系统角色号：";
            // 
            // lblPrno
            // 
            this.lblPrno.AutoSize = true;
            this.lblPrno.Location = new System.Drawing.Point(50, 150);
            this.lblPrno.Name = "lblPrno";
            this.lblPrno.Size = new System.Drawing.Size(97, 15);
            this.lblPrno.TabIndex = 3;
            this.lblPrno.Text = "创建角色号：";
            // 
            // lblPrname
            // 
            this.lblPrname.AutoSize = true;
            this.lblPrname.Location = new System.Drawing.Point(50, 190);
            this.lblPrname.Name = "lblPrname";
            this.lblPrname.Size = new System.Drawing.Size(97, 15);
            this.lblPrname.TabIndex = 4;
            this.lblPrname.Text = "创建角色名：";
            // 
            // lblCdate
            // 
            this.lblCdate.AutoSize = true;
            this.lblCdate.Location = new System.Drawing.Point(50, 230);
            this.lblCdate.Name = "lblCdate";
            this.lblCdate.Size = new System.Drawing.Size(82, 15);
            this.lblCdate.TabIndex = 5;
            this.lblCdate.Text = "创建时间：";
            // 
            // txtPno
            // 
            this.txtPno.Location = new System.Drawing.Point(150, 30);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(150, 25);
            this.txtPno.TabIndex = 6;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(150, 70);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(150, 25);
            this.txtPname.TabIndex = 7;
            // 
            // txtRno
            // 
            this.txtRno.Location = new System.Drawing.Point(150, 110);
            this.txtRno.Name = "txtRno";
            this.txtRno.Size = new System.Drawing.Size(150, 25);
            this.txtRno.TabIndex = 8;
            // 
            // txtPrno
            // 
            this.txtPrno.Location = new System.Drawing.Point(150, 150);
            this.txtPrno.Name = "txtPrno";
            this.txtPrno.Size = new System.Drawing.Size(150, 25);
            this.txtPrno.TabIndex = 9;
            // 
            // txtPrname
            // 
            this.txtPrname.Location = new System.Drawing.Point(150, 190);
            this.txtPrname.Name = "txtPrname";
            this.txtPrname.Size = new System.Drawing.Size(150, 25);
            this.txtPrname.TabIndex = 10;
            // 
            // dtpCdate
            // 
            this.dtpCdate.Location = new System.Drawing.Point(150, 230);
            this.dtpCdate.Name = "dtpCdate";
            this.dtpCdate.Size = new System.Drawing.Size(150, 25);
            this.dtpCdate.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(50, 270);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 30);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "创建";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateRoleForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpCdate);
            this.Controls.Add(this.txtPrname);
            this.Controls.Add(this.txtPrno);
            this.Controls.Add(this.txtRno);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtPno);
            this.Controls.Add(this.lblCdate);
            this.Controls.Add(this.lblPrname);
            this.Controls.Add(this.lblPrno);
            this.Controls.Add(this.lblRno);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.lblPno);
            this.Name = "CreateRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "玩家创建角色";
            this.Load += new System.EventHandler(this.CreateRoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPno;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label lblRno;
        private System.Windows.Forms.Label lblPrno;
        private System.Windows.Forms.Label lblPrname;
        private System.Windows.Forms.Label lblCdate;
        private System.Windows.Forms.TextBox txtPno;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtRno;
        private System.Windows.Forms.TextBox txtPrno;
        private System.Windows.Forms.TextBox txtPrname;
        private System.Windows.Forms.DateTimePicker dtpCdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}
