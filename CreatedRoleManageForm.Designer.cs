namespace GameManagementSystem
{
    partial class CreatedRoleManageForm
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
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.lblPno = new System.Windows.Forms.Label();
            this.txtPno = new System.Windows.Forms.TextBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.lblRno = new System.Windows.Forms.Label();
            this.txtRno = new System.Windows.Forms.TextBox();
            this.lblPrno = new System.Windows.Forms.Label();
            this.txtPrno = new System.Windows.Forms.TextBox();
            this.lblPrname = new System.Windows.Forms.Label();
            this.txtPrname = new System.Windows.Forms.TextBox();
            this.lblCdate = new System.Windows.Forms.Label();
            this.dtpCdate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(12, 12);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 27;
            this.dgvRoles.Size = new System.Drawing.Size(760, 250);
            this.dgvRoles.TabIndex = 0;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            // 
            // lblPno
            // 
            this.lblPno.AutoSize = true;
            this.lblPno.Location = new System.Drawing.Point(12, 280);
            this.lblPno.Name = "lblPno";
            this.lblPno.Size = new System.Drawing.Size(67, 15);
            this.lblPno.TabIndex = 1;
            this.lblPno.Text = "玩家号：";
            // 
            // txtPno
            // 
            this.txtPno.Location = new System.Drawing.Point(85, 277);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(100, 25);
            this.txtPno.TabIndex = 2;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Location = new System.Drawing.Point(200, 280);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(67, 15);
            this.lblPname.TabIndex = 3;
            this.lblPname.Text = "玩家名：";
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(273, 277);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(100, 25);
            this.txtPname.TabIndex = 4;
            // 
            // lblRno
            // 
            this.lblRno.AutoSize = true;
            this.lblRno.Location = new System.Drawing.Point(390, 280);
            this.lblRno.Name = "lblRno";
            this.lblRno.Size = new System.Drawing.Size(82, 15);
            this.lblRno.TabIndex = 5;
            this.lblRno.Text = "系统角色：";
            // 
            // txtRno
            // 
            this.txtRno.Location = new System.Drawing.Point(478, 277);
            this.txtRno.Name = "txtRno";
            this.txtRno.Size = new System.Drawing.Size(100, 25);
            this.txtRno.TabIndex = 6;
            // 
            // lblPrno
            // 
            this.lblPrno.AutoSize = true;
            this.lblPrno.Location = new System.Drawing.Point(12, 320);
            this.lblPrno.Name = "lblPrno";
            this.lblPrno.Size = new System.Drawing.Size(97, 15);
            this.lblPrno.TabIndex = 7;
            this.lblPrno.Text = "创建角色号：";
            // 
            // txtPrno
            // 
            this.txtPrno.Location = new System.Drawing.Point(115, 317);
            this.txtPrno.Name = "txtPrno";
            this.txtPrno.Size = new System.Drawing.Size(100, 25);
            this.txtPrno.TabIndex = 8;
            // 
            // lblPrname
            // 
            this.lblPrname.AutoSize = true;
            this.lblPrname.Location = new System.Drawing.Point(230, 320);
            this.lblPrname.Name = "lblPrname";
            this.lblPrname.Size = new System.Drawing.Size(97, 15);
            this.lblPrname.TabIndex = 9;
            this.lblPrname.Text = "创建角色名：";
            // 
            // txtPrname
            // 
            this.txtPrname.Location = new System.Drawing.Point(333, 317);
            this.txtPrname.Name = "txtPrname";
            this.txtPrname.Size = new System.Drawing.Size(100, 25);
            this.txtPrname.TabIndex = 10;
            // 
            // lblCdate
            // 
            this.lblCdate.AutoSize = true;
            this.lblCdate.Location = new System.Drawing.Point(450, 320);
            this.lblCdate.Name = "lblCdate";
            this.lblCdate.Size = new System.Drawing.Size(82, 15);
            this.lblCdate.TabIndex = 11;
            this.lblCdate.Text = "创建时间：";
            // 
            // dtpCdate
            // 
            this.dtpCdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCdate.Location = new System.Drawing.Point(523, 317);
            this.dtpCdate.Name = "dtpCdate";
            this.dtpCdate.Size = new System.Drawing.Size(100, 25);
            this.dtpCdate.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(366, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(484, 370);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CreatedRoleManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpCdate);
            this.Controls.Add(this.lblCdate);
            this.Controls.Add(this.txtPrname);
            this.Controls.Add(this.lblPrname);
            this.Controls.Add(this.txtPrno);
            this.Controls.Add(this.lblPrno);
            this.Controls.Add(this.txtRno);
            this.Controls.Add(this.lblRno);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.txtPno);
            this.Controls.Add(this.lblPno);
            this.Controls.Add(this.dgvRoles);
            this.Name = "CreatedRoleManageForm";
            this.Text = "玩家创建角色管理";
            this.Load += new System.EventHandler(this.CreatedRoleManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label lblPno;
        private System.Windows.Forms.TextBox txtPno;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label lblRno;
        private System.Windows.Forms.TextBox txtRno;
        private System.Windows.Forms.Label lblPrno;
        private System.Windows.Forms.TextBox txtPrno;
        private System.Windows.Forms.Label lblPrname;
        private System.Windows.Forms.TextBox txtPrname;
        private System.Windows.Forms.Label lblCdate;
        private System.Windows.Forms.DateTimePicker dtpCdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}
