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
    public partial class PlayerMainForm : Form
    {
        public PlayerMainForm()
        {
            InitializeComponent();
        }

        private void 创建角色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRoleForm f = new CreateRoleForm();
            f.ShowDialog();
        }

        private void 充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerRechargeForm f = new PlayerRechargeForm();
            f.ShowDialog();
        }

        private void 获取道具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HaveForm f = new HaveForm();
            f.ShowDialog();
        }
    }
}
