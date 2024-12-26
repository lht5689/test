using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void 玩家常见角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatedRoleManageForm f = new CreatedRoleManageForm();
            f.ShowDialog();
        }

        private void 角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm f = new RolesForm();
            f.ShowDialog();
        }

        private void 道具管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropForm f = new PropForm();
            f.ShowDialog();
        }

        private void 玩家管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerManagementForm f = new PlayerManagementForm();
            f.ShowDialog();
        }

        private void 获取道具管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageItemForm f = new ManageItemForm();
            f.ShowDialog();
        }
    }
}
