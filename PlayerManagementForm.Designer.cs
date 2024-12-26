namespace GameManagementSystem
{
    partial class PlayerManagementForm
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
            this.lblPname = new System.Windows.Forms.Label();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.lblpsno = new System.Windows.Forms.Label();
            this.txtpsno = new System.Windows.Forms.TextBox();
            this.lblPtime = new System.Windows.Forms.Label();
            this.dtpPtime = new System.Windows.Forms.DateTimePicker();
            this.lblPmoney = new System.Windows.Forms.Label();
            this.txtPmoney = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPno
            // 
            this.lblPno.AutoSize = true;
            this.lblPno.Location = new System.Drawing.Point(20, 20);
            this.lblPno.Name = "lblPno";
            this.lblPno.Size = new System.Drawing.Size(92, 15);
            this.lblPno.TabIndex = 0;
            this.lblPno.Text = "玩家号(Pno)";
            // 
            // txtPno
            // 
            this.txtPno.Location = new System.Drawing.Point(158, 17);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(150, 25);
            this.txtPno.TabIndex = 1;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Location = new System.Drawing.Point(20, 60);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(108, 15);
            this.lblPname.TabIndex = 2;
            this.lblPname.Text = "玩家名(Pname)";
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(158, 57);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(150, 25);
            this.txtPname.TabIndex = 3;
            // 
            // lblpsno
            // 
            this.lblpsno.AutoSize = true;
            this.lblpsno.Location = new System.Drawing.Point(20, 100);
            this.lblpsno.Name = "lblpsno";
            this.lblpsno.Size = new System.Drawing.Size(107, 15);
            this.lblpsno.TabIndex = 4;
            this.lblpsno.Text = "角色数量(psno)";
            // 
            // txtpsno
            // 
            this.txtpsno.Location = new System.Drawing.Point(158, 97);
            this.txtpsno.Name = "txtpsno";
            this.txtpsno.Size = new System.Drawing.Size(150, 25);
            this.txtpsno.TabIndex = 5;
            // 
            // lblPtime
            // 
            this.lblPtime.AutoSize = true;
            this.lblPtime.Location = new System.Drawing.Point(20, 140);
            this.lblPtime.Name = "lblPtime";
            this.lblPtime.Size = new System.Drawing.Size(123, 15);
            this.lblPtime.TabIndex = 6;
            this.lblPtime.Text = "注册时间(Ptime)";
            // 
            // dtpPtime
            // 
            this.dtpPtime.Location = new System.Drawing.Point(158, 137);
            this.dtpPtime.Name = "dtpPtime";
            this.dtpPtime.Size = new System.Drawing.Size(150, 25);
            this.dtpPtime.TabIndex = 7;
            // 
            // lblPmoney
            // 
            this.lblPmoney.AutoSize = true;
            this.lblPmoney.Location = new System.Drawing.Point(20, 180);
            this.lblPmoney.Name = "lblPmoney";
            this.lblPmoney.Size = new System.Drawing.Size(131, 15);
            this.lblPmoney.TabIndex = 8;
            this.lblPmoney.Text = "充值额度(Pmoney)";
            // 
            // txtPmoney
            // 
            this.txtPmoney.Location = new System.Drawing.Point(158, 177);
            this.txtPmoney.Name = "txtPmoney";
            this.txtPmoney.Size = new System.Drawing.Size(150, 25);
            this.txtPmoney.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(345, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(345, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(345, 140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(20, 220);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.RowTemplate.Height = 23;
            this.dgvPlayers.Size = new System.Drawing.Size(400, 150);
            this.dgvPlayers.TabIndex = 14;
            this.dgvPlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayers_CellClick);
            // 
            // PlayerManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPmoney);
            this.Controls.Add(this.lblPmoney);
            this.Controls.Add(this.dtpPtime);
            this.Controls.Add(this.lblPtime);
            this.Controls.Add(this.txtpsno);
            this.Controls.Add(this.lblpsno);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.txtPno);
            this.Controls.Add(this.lblPno);
            this.Name = "PlayerManagementForm";
            this.Text = "玩家管理";
            this.Load += new System.EventHandler(this.PlayerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblPno, lblPname, lblpsno, lblPtime, lblPmoney;
        private System.Windows.Forms.TextBox txtPno, txtPname, txtpsno, txtPmoney;
        private System.Windows.Forms.DateTimePicker dtpPtime;
        private System.Windows.Forms.Button btnSave, btnDelete, btnSearch, btnClose;
        private System.Windows.Forms.DataGridView dgvPlayers;
    }
}
