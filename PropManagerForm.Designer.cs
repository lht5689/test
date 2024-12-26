namespace GameManagementSystem
{
    partial class PropForm
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

        private void InitializeComponent()
        {
            this.dgvProps = new System.Windows.Forms.DataGridView();
            this.txtDno = new System.Windows.Forms.TextBox();
            this.txtDname = new System.Windows.Forms.TextBox();
            this.txtDgrade = new System.Windows.Forms.TextBox();
            this.chkDlimit = new System.Windows.Forms.CheckBox();
            this.txtDhave = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblDno = new System.Windows.Forms.Label();
            this.lblDname = new System.Windows.Forms.Label();
            this.lblDgrade = new System.Windows.Forms.Label();
            this.lblDlimit = new System.Windows.Forms.Label();
            this.lblDhave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProps)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProps
            // 
            this.dgvProps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProps.Location = new System.Drawing.Point(14, 12);
            this.dgvProps.Name = "dgvProps";
            this.dgvProps.RowHeadersWidth = 51;
            this.dgvProps.RowTemplate.Height = 25;
            this.dgvProps.Size = new System.Drawing.Size(629, 250);
            this.dgvProps.TabIndex = 0;
            // 
            // txtDno
            // 
            this.txtDno.Location = new System.Drawing.Point(109, 280);
            this.txtDno.Name = "txtDno";
            this.txtDno.Size = new System.Drawing.Size(114, 25);
            this.txtDno.TabIndex = 1;
            // 
            // txtDname
            // 
            this.txtDname.Location = new System.Drawing.Point(109, 320);
            this.txtDname.Name = "txtDname";
            this.txtDname.Size = new System.Drawing.Size(114, 25);
            this.txtDname.TabIndex = 2;
            // 
            // txtDgrade
            // 
            this.txtDgrade.Location = new System.Drawing.Point(109, 360);
            this.txtDgrade.Name = "txtDgrade";
            this.txtDgrade.Size = new System.Drawing.Size(114, 25);
            this.txtDgrade.TabIndex = 3;
            // 
            // chkDlimit
            // 
            this.chkDlimit.AutoSize = true;
            this.chkDlimit.Location = new System.Drawing.Point(109, 400);
            this.chkDlimit.Name = "chkDlimit";
            this.chkDlimit.Size = new System.Drawing.Size(59, 19);
            this.chkDlimit.TabIndex = 4;
            this.chkDlimit.Text = "限定";
            this.chkDlimit.UseVisualStyleBackColor = true;
            // 
            // txtDhave
            // 
            this.txtDhave.Location = new System.Drawing.Point(109, 440);
            this.txtDhave.Name = "txtDhave";
            this.txtDhave.Size = new System.Drawing.Size(114, 25);
            this.txtDhave.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(457, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 338);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(457, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(457, 427);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 38);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblDno
            // 
            this.lblDno.AutoSize = true;
            this.lblDno.Location = new System.Drawing.Point(14, 283);
            this.lblDno.Name = "lblDno";
            this.lblDno.Size = new System.Drawing.Size(67, 15);
            this.lblDno.TabIndex = 10;
            this.lblDno.Text = "道具号：";
            // 
            // lblDname
            // 
            this.lblDname.AutoSize = true;
            this.lblDname.Location = new System.Drawing.Point(14, 323);
            this.lblDname.Name = "lblDname";
            this.lblDname.Size = new System.Drawing.Size(67, 15);
            this.lblDname.TabIndex = 11;
            this.lblDname.Text = "道具名：";
            // 
            // lblDgrade
            // 
            this.lblDgrade.AutoSize = true;
            this.lblDgrade.Location = new System.Drawing.Point(14, 363);
            this.lblDgrade.Name = "lblDgrade";
            this.lblDgrade.Size = new System.Drawing.Size(52, 15);
            this.lblDgrade.TabIndex = 12;
            this.lblDgrade.Text = "品级：";
            // 
            // lblDlimit
            // 
            this.lblDlimit.AutoSize = true;
            this.lblDlimit.Location = new System.Drawing.Point(14, 400);
            this.lblDlimit.Name = "lblDlimit";
            this.lblDlimit.Size = new System.Drawing.Size(82, 15);
            this.lblDlimit.TabIndex = 13;
            this.lblDlimit.Text = "是否限定：";
            // 
            // lblDhave
            // 
            this.lblDhave.AutoSize = true;
            this.lblDhave.Location = new System.Drawing.Point(14, 443);
            this.lblDhave.Name = "lblDhave";
            this.lblDhave.Size = new System.Drawing.Size(82, 15);
            this.lblDhave.TabIndex = 14;
            this.lblDhave.Text = "获取途径：";
            // 
            // PropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 481);
            this.Controls.Add(this.lblDhave);
            this.Controls.Add(this.lblDlimit);
            this.Controls.Add(this.lblDgrade);
            this.Controls.Add(this.lblDname);
            this.Controls.Add(this.lblDno);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDhave);
            this.Controls.Add(this.chkDlimit);
            this.Controls.Add(this.txtDgrade);
            this.Controls.Add(this.txtDname);
            this.Controls.Add(this.txtDno);
            this.Controls.Add(this.dgvProps);
            this.Name = "PropForm";
            this.Text = "道具管理";
            this.Load += new System.EventHandler(this.PropForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvProps;
        private System.Windows.Forms.TextBox txtDno;
        private System.Windows.Forms.TextBox txtDname;
        private System.Windows.Forms.TextBox txtDgrade;
        private System.Windows.Forms.CheckBox chkDlimit;
        private System.Windows.Forms.TextBox txtDhave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblDno;
        private System.Windows.Forms.Label lblDname;
        private System.Windows.Forms.Label lblDgrade;
        private System.Windows.Forms.Label lblDlimit;
        private System.Windows.Forms.Label lblDhave;
    }
}
