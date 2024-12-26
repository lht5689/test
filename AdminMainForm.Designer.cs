
namespace GameManagementSystem
{
    partial class AdminMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.角色管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.道具管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.玩家管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.玩家常见角色管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取道具管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.角色管理ToolStripMenuItem,
            this.道具管理ToolStripMenuItem,
            this.玩家管理ToolStripMenuItem,
            this.玩家常见角色管理ToolStripMenuItem,
            this.获取道具管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 角色管理ToolStripMenuItem
            // 
            this.角色管理ToolStripMenuItem.Name = "角色管理ToolStripMenuItem";
            this.角色管理ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.角色管理ToolStripMenuItem.Text = "角色管理";
            this.角色管理ToolStripMenuItem.Click += new System.EventHandler(this.角色管理ToolStripMenuItem_Click);
            // 
            // 道具管理ToolStripMenuItem
            // 
            this.道具管理ToolStripMenuItem.Name = "道具管理ToolStripMenuItem";
            this.道具管理ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.道具管理ToolStripMenuItem.Text = "道具管理";
            this.道具管理ToolStripMenuItem.Click += new System.EventHandler(this.道具管理ToolStripMenuItem_Click);
            // 
            // 玩家管理ToolStripMenuItem
            // 
            this.玩家管理ToolStripMenuItem.Name = "玩家管理ToolStripMenuItem";
            this.玩家管理ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.玩家管理ToolStripMenuItem.Text = "玩家管理";
            this.玩家管理ToolStripMenuItem.Click += new System.EventHandler(this.玩家管理ToolStripMenuItem_Click);
            // 
            // 玩家常见角色管理ToolStripMenuItem
            // 
            this.玩家常见角色管理ToolStripMenuItem.Name = "玩家常见角色管理ToolStripMenuItem";
            this.玩家常见角色管理ToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.玩家常见角色管理ToolStripMenuItem.Text = "玩家创建角色管理";
            this.玩家常见角色管理ToolStripMenuItem.Click += new System.EventHandler(this.玩家常见角色管理ToolStripMenuItem_Click);
            // 
            // 获取道具管理ToolStripMenuItem
            // 
            this.获取道具管理ToolStripMenuItem.Name = "获取道具管理ToolStripMenuItem";
            this.获取道具管理ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.获取道具管理ToolStripMenuItem.Text = "获取道具管理";
            this.获取道具管理ToolStripMenuItem.Click += new System.EventHandler(this.获取道具管理ToolStripMenuItem_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 角色管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 道具管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 玩家管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 玩家常见角色管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 获取道具管理ToolStripMenuItem;
    }
}