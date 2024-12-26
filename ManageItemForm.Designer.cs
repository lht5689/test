namespace GameManagementSystem
{
    partial class ManageItemForm
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
            this.lblPno = new System.Windows.Forms.Label();
            this.txtPno = new System.Windows.Forms.TextBox();
            this.lblPrno = new System.Windows.Forms.Label();
            this.txtPrno = new System.Windows.Forms.TextBox();
            this.lblPrname = new System.Windows.Forms.Label();
            this.txtPrname = new System.Windows.Forms.TextBox();
            this.lblDno = new System.Windows.Forms.Label();
            this.txtDno = new System.Windows.Forms.TextBox();
            this.lblDname = new System.Windows.Forms.Label();
            this.txtDname = new System.Windows.Forms.TextBox();
            this.lblHnum = new System.Windows.Forms.Label();
            this.txtHnum = new System.Windows.Forms.TextBox();
            this.lblDhave = new System.Windows.Forms.Label();
            this.txtDhave = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPno
            // 
            this.lblPno.AutoSize = true;
            this.lblPno.Location = new System.Drawing.Point(30, 20);
            this.lblPno.Name = "lblPno";
            this.lblPno.Size = new System.Drawing.Size(67, 15);
            this.lblPno.TabIndex = 0;
            this.lblPno.Text = "玩家号：";
            // 
            // txtPno
            // 
            this.txtPno.Location = new System.Drawing.Point(144, 21);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(150, 25);
            this.txtPno.TabIndex = 1;
            // 
            // lblPrno
            // 
            this.lblPrno.AutoSize = true;
            this.lblPrno.Location = new System.Drawing.Point(30, 60);
            this.lblPrno.Name = "lblPrno";
            this.lblPrno.Size = new System.Drawing.Size(97, 15);
            this.lblPrno.TabIndex = 2;
            this.lblPrno.Text = "创建角色号：";
            // 
            // txtPrno
            // 
            this.txtPrno.Location = new System.Drawing.Point(144, 61);
            this.txtPrno.Name = "txtPrno";
            this.txtPrno.Size = new System.Drawing.Size(150, 25);
            this.txtPrno.TabIndex = 3;
            // 
            // lblPrname
            // 
            this.lblPrname.AutoSize = true;
            this.lblPrname.Location = new System.Drawing.Point(30, 100);
            this.lblPrname.Name = "lblPrname";
            this.lblPrname.Size = new System.Drawing.Size(97, 15);
            this.lblPrname.TabIndex = 4;
            this.lblPrname.Text = "创建角色名：";
            // 
            // txtPrname
            // 
            this.txtPrname.Location = new System.Drawing.Point(144, 101);
            this.txtPrname.Name = "txtPrname";
            this.txtPrname.Size = new System.Drawing.Size(150, 25);
            this.txtPrname.TabIndex = 5;
            // 
            // lblDno
            // 
            this.lblDno.AutoSize = true;
            this.lblDno.Location = new System.Drawing.Point(30, 140);
            this.lblDno.Name = "lblDno";
            this.lblDno.Size = new System.Drawing.Size(67, 15);
            this.lblDno.TabIndex = 6;
            this.lblDno.Text = "道具号：";
            // 
            // txtDno
            // 
            this.txtDno.Location = new System.Drawing.Point(144, 141);
            this.txtDno.Name = "txtDno";
            this.txtDno.Size = new System.Drawing.Size(150, 25);
            this.txtDno.TabIndex = 7;
            // 
            // lblDname
            // 
            this.lblDname.AutoSize = true;
            this.lblDname.Location = new System.Drawing.Point(30, 180);
            this.lblDname.Name = "lblDname";
            this.lblDname.Size = new System.Drawing.Size(67, 15);
            this.lblDname.TabIndex = 8;
            this.lblDname.Text = "道具名：";
            // 
            // txtDname
            // 
            this.txtDname.Location = new System.Drawing.Point(144, 181);
            this.txtDname.Name = "txtDname";
            this.txtDname.Size = new System.Drawing.Size(150, 25);
            this.txtDname.TabIndex = 9;
            // 
            // lblHnum
            // 
            this.lblHnum.AutoSize = true;
            this.lblHnum.Location = new System.Drawing.Point(30, 220);
            this.lblHnum.Name = "lblHnum";
            this.lblHnum.Size = new System.Drawing.Size(82, 15);
            this.lblHnum.TabIndex = 10;
            this.lblHnum.Text = "道具数量：";
            // 
            // txtHnum
            // 
            this.txtHnum.Location = new System.Drawing.Point(144, 221);
            this.txtHnum.Name = "txtHnum";
            this.txtHnum.Size = new System.Drawing.Size(150, 25);
            this.txtHnum.TabIndex = 11;
            // 
            // lblDhave
            // 
            this.lblDhave.AutoSize = true;
            this.lblDhave.Location = new System.Drawing.Point(30, 260);
            this.lblDhave.Name = "lblDhave";
            this.lblDhave.Size = new System.Drawing.Size(82, 15);
            this.lblDhave.TabIndex = 12;
            this.lblDhave.Text = "获取途径：";
            // 
            // txtDhave
            // 
            this.txtDhave.Location = new System.Drawing.Point(144, 261);
            this.txtDhave.Name = "txtDhave";
            this.txtDhave.Size = new System.Drawing.Size(150, 25);
            this.txtDhave.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(416, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(416, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(416, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(416, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(30, 300);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 23;
            this.dgvItems.Size = new System.Drawing.Size(500, 200);
            this.dgvItems.TabIndex = 19;
            // 
            // ManageItemForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDhave);
            this.Controls.Add(this.lblDhave);
            this.Controls.Add(this.txtHnum);
            this.Controls.Add(this.lblHnum);
            this.Controls.Add(this.txtDname);
            this.Controls.Add(this.lblDname);
            this.Controls.Add(this.txtDno);
            this.Controls.Add(this.lblDno);
            this.Controls.Add(this.txtPrname);
            this.Controls.Add(this.lblPrname);
            this.Controls.Add(this.txtPrno);
            this.Controls.Add(this.lblPrno);
            this.Controls.Add(this.txtPno);
            this.Controls.Add(this.lblPno);
            this.Name = "ManageItemForm";
            this.Text = "道具管理";
            this.Load += new System.EventHandler(this.ManageItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblPno, lblPrno, lblPrname, lblDno, lblDname, lblHnum, lblDhave;
        private System.Windows.Forms.TextBox txtPno, txtPrno, txtPrname, txtDno, txtDname, txtHnum, txtDhave;
        private System.Windows.Forms.Button btnSave, btnDelete, btnUpdate, btnSearch, btnClose;
        private System.Windows.Forms.DataGridView dgvItems;
    }
}
