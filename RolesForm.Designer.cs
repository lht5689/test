namespace GameManagementSystem
{
    partial class RolesForm
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
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.txtRno = new System.Windows.Forms.TextBox();
            this.txtRname = new System.Windows.Forms.TextBox();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.txtRjob = new System.Windows.Forms.TextBox();
            this.txtRjoin = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblRno = new System.Windows.Forms.Label();
            this.lblRname = new System.Windows.Forms.Label();
            this.lblRsex = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblRjob = new System.Windows.Forms.Label();
            this.lblRjoin = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(14, 12);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 25;
            this.dgvRoles.Size = new System.Drawing.Size(743, 250);
            this.dgvRoles.TabIndex = 0;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            // 
            // txtRno
            // 
            this.txtRno.Location = new System.Drawing.Point(119, 280);
            this.txtRno.Name = "txtRno";
            this.txtRno.Size = new System.Drawing.Size(114, 25);
            this.txtRno.TabIndex = 1;
            // 
            // txtRname
            // 
            this.txtRname.Location = new System.Drawing.Point(119, 320);
            this.txtRname.Name = "txtRname";
            this.txtRname.Size = new System.Drawing.Size(114, 25);
            this.txtRname.TabIndex = 2;
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(119, 400);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(114, 25);
            this.txtRace.TabIndex = 4;
            // 
            // txtRjob
            // 
            this.txtRjob.Location = new System.Drawing.Point(119, 440);
            this.txtRjob.Name = "txtRjob";
            this.txtRjob.Size = new System.Drawing.Size(114, 25);
            this.txtRjob.TabIndex = 5;
            // 
            // txtRjoin
            // 
            this.txtRjoin.Location = new System.Drawing.Point(119, 480);
            this.txtRjoin.Name = "txtRjoin";
            this.txtRjoin.Size = new System.Drawing.Size(114, 25);
            this.txtRjoin.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(457, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(457, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(457, 403);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 38);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblRno
            // 
            this.lblRno.AutoSize = true;
            this.lblRno.Location = new System.Drawing.Point(14, 283);
            this.lblRno.Name = "lblRno";
            this.lblRno.Size = new System.Drawing.Size(82, 15);
            this.lblRno.TabIndex = 11;
            this.lblRno.Text = "角色编号：";
            // 
            // lblRname
            // 
            this.lblRname.AutoSize = true;
            this.lblRname.Location = new System.Drawing.Point(14, 323);
            this.lblRname.Name = "lblRname";
            this.lblRname.Size = new System.Drawing.Size(82, 15);
            this.lblRname.TabIndex = 12;
            this.lblRname.Text = "角色名称：";
            // 
            // lblRsex
            // 
            this.lblRsex.AutoSize = true;
            this.lblRsex.Location = new System.Drawing.Point(14, 363);
            this.lblRsex.Name = "lblRsex";
            this.lblRsex.Size = new System.Drawing.Size(52, 15);
            this.lblRsex.TabIndex = 13;
            this.lblRsex.Text = "性别：";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(14, 403);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(82, 15);
            this.lblRace.TabIndex = 14;
            this.lblRace.Text = "角色种族：";
            // 
            // lblRjob
            // 
            this.lblRjob.AutoSize = true;
            this.lblRjob.Location = new System.Drawing.Point(14, 443);
            this.lblRjob.Name = "lblRjob";
            this.lblRjob.Size = new System.Drawing.Size(82, 15);
            this.lblRjob.TabIndex = 15;
            this.lblRjob.Text = "角色职业：";
            // 
            // lblRjoin
            // 
            this.lblRjoin.AutoSize = true;
            this.lblRjoin.Location = new System.Drawing.Point(14, 483);
            this.lblRjoin.Name = "lblRjoin";
            this.lblRjoin.Size = new System.Drawing.Size(67, 15);
            this.lblRjoin.TabIndex = 16;
            this.lblRjoin.Text = "出生地：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(119, 363);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 23);
            this.comboBox1.TabIndex = 17;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 531);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRjoin);
            this.Controls.Add(this.lblRjob);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblRsex);
            this.Controls.Add(this.lblRname);
            this.Controls.Add(this.lblRno);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRjoin);
            this.Controls.Add(this.txtRjob);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.txtRname);
            this.Controls.Add(this.txtRno);
            this.Controls.Add(this.dgvRoles);
            this.Name = "RolesForm";
            this.Text = "系统角色管理";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.TextBox txtRno;
        private System.Windows.Forms.TextBox txtRname;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.TextBox txtRjob;
        private System.Windows.Forms.TextBox txtRjoin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblRno;
        private System.Windows.Forms.Label lblRname;
        private System.Windows.Forms.Label lblRsex;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblRjob;
        private System.Windows.Forms.Label lblRjoin;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
