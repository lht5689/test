using System;
using System.Windows.Forms;

namespace GameManagementSystem
{
    partial class HaveForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPno;
        private TextBox txtPno;
        private Label lblPrno;
        private TextBox txtPrno;
        private Label lblPrname;
        private TextBox txtPrname;
        private Label lblDno;
        private TextBox txtDno;
        private Label lblDname;
        private TextBox txtDname;
        private Label lblHnum;
        private TextBox txtHnum;
        private Label lblDhave;
        private TextBox txtDhave;
        private Button btnSave;
        private Button btnClose;

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
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPno
            // 
            this.lblPno.Location = new System.Drawing.Point(30, 20);
            this.lblPno.Name = "lblPno";
            this.lblPno.Size = new System.Drawing.Size(100, 23);
            this.lblPno.TabIndex = 0;
            this.lblPno.Text = "玩家号:";
            // 
            // txtPno
            // 
            this.txtPno.Location = new System.Drawing.Point(150, 20);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(100, 25);
            this.txtPno.TabIndex = 1;
            // 
            // lblPrno
            // 
            this.lblPrno.Location = new System.Drawing.Point(30, 60);
            this.lblPrno.Name = "lblPrno";
            this.lblPrno.Size = new System.Drawing.Size(100, 23);
            this.lblPrno.TabIndex = 2;
            this.lblPrno.Text = "创建角色号:";
            // 
            // txtPrno
            // 
            this.txtPrno.Location = new System.Drawing.Point(150, 60);
            this.txtPrno.Name = "txtPrno";
            this.txtPrno.Size = new System.Drawing.Size(100, 25);
            this.txtPrno.TabIndex = 3;
            // 
            // lblPrname
            // 
            this.lblPrname.Location = new System.Drawing.Point(30, 100);
            this.lblPrname.Name = "lblPrname";
            this.lblPrname.Size = new System.Drawing.Size(100, 23);
            this.lblPrname.TabIndex = 4;
            this.lblPrname.Text = "创建角色名:";
            // 
            // txtPrname
            // 
            this.txtPrname.Location = new System.Drawing.Point(150, 100);
            this.txtPrname.Name = "txtPrname";
            this.txtPrname.Size = new System.Drawing.Size(100, 25);
            this.txtPrname.TabIndex = 5;
            // 
            // lblDno
            // 
            this.lblDno.Location = new System.Drawing.Point(30, 140);
            this.lblDno.Name = "lblDno";
            this.lblDno.Size = new System.Drawing.Size(100, 23);
            this.lblDno.TabIndex = 6;
            this.lblDno.Text = "道具号:";
            // 
            // txtDno
            // 
            this.txtDno.Location = new System.Drawing.Point(150, 140);
            this.txtDno.Name = "txtDno";
            this.txtDno.Size = new System.Drawing.Size(100, 25);
            this.txtDno.TabIndex = 7;
            // 
            // lblDname
            // 
            this.lblDname.Location = new System.Drawing.Point(30, 180);
            this.lblDname.Name = "lblDname";
            this.lblDname.Size = new System.Drawing.Size(100, 23);
            this.lblDname.TabIndex = 8;
            this.lblDname.Text = "道具名:";
            // 
            // txtDname
            // 
            this.txtDname.Location = new System.Drawing.Point(150, 180);
            this.txtDname.Name = "txtDname";
            this.txtDname.Size = new System.Drawing.Size(100, 25);
            this.txtDname.TabIndex = 9;
            // 
            // lblHnum
            // 
            this.lblHnum.Location = new System.Drawing.Point(30, 220);
            this.lblHnum.Name = "lblHnum";
            this.lblHnum.Size = new System.Drawing.Size(100, 23);
            this.lblHnum.TabIndex = 10;
            this.lblHnum.Text = "道具数量:";
            // 
            // txtHnum
            // 
            this.txtHnum.Location = new System.Drawing.Point(150, 220);
            this.txtHnum.Name = "txtHnum";
            this.txtHnum.Size = new System.Drawing.Size(100, 25);
            this.txtHnum.TabIndex = 11;
            // 
            // lblDhave
            // 
            this.lblDhave.Location = new System.Drawing.Point(30, 260);
            this.lblDhave.Name = "lblDhave";
            this.lblDhave.Size = new System.Drawing.Size(100, 23);
            this.lblDhave.TabIndex = 12;
            this.lblDhave.Text = "获取途径:";
            // 
            // txtDhave
            // 
            this.txtDhave.Location = new System.Drawing.Point(150, 260);
            this.txtDhave.Name = "txtDhave";
            this.txtDhave.Size = new System.Drawing.Size(100, 25);
            this.txtDhave.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(80, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(200, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HaveForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblPno);
            this.Controls.Add(this.txtPno);
            this.Controls.Add(this.lblPrno);
            this.Controls.Add(this.txtPrno);
            this.Controls.Add(this.lblPrname);
            this.Controls.Add(this.txtPrname);
            this.Controls.Add(this.lblDno);
            this.Controls.Add(this.txtDno);
            this.Controls.Add(this.lblDname);
            this.Controls.Add(this.txtDname);
            this.Controls.Add(this.lblHnum);
            this.Controls.Add(this.txtHnum);
            this.Controls.Add(this.lblDhave);
            this.Controls.Add(this.txtDhave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "HaveForm";
            this.Text = "玩家获取道具表";
            this.Load += new System.EventHandler(this.HaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
