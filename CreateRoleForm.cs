using System;
using System.Collections.Generic;
using System.Data.OleDb; // 使用 Access 数据库
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class CreateRoleForm : Form
    {
        public CreateRoleForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // 获取输入数据
            string pno = txtPno.Text.Trim();
            string pname = txtPname.Text.Trim();
            string rno = txtRno.Text.Trim();
            string prno = txtPrno.Text.Trim();
            string prname = txtPrname.Text.Trim();
            string cdate = dtpCdate.Value.ToString("yyyy-MM-dd");

            // 检查输入
            if (string.IsNullOrEmpty(pno) || string.IsNullOrEmpty(pname) || string.IsNullOrEmpty(rno) ||
                string.IsNullOrEmpty(prno) || string.IsNullOrEmpty(prname))
            {
                MessageBox.Show("请填写完整信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 插入数据的 SQL 语句
                string query = $"INSERT INTO created (Pno, Pname, Rno, Prno, Prname, Cdate) " +
                       $"VALUES ('{pno}', '{pname}', '{rno}', '{prno}', '{prname}', '{cdate}')";

                // 使用 DBHelper 执行 SQL
                int result = DbHelper.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("角色创建成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("角色创建失败，请稍后再试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateRoleForm_Load(object sender, EventArgs e)
        {
            txtPno.Text = Program.code;
        }
    }
}
