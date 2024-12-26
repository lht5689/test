using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class ManageItemForm : Form
    {
        public ManageItemForm()
        {
            InitializeComponent();
        }

        // 保存（新增）道具记录
        private void btnSave_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            string prno = txtPrno.Text.Trim();
            string prname = txtPrname.Text.Trim();
            string dno = txtDno.Text.Trim();
            string dname = txtDname.Text.Trim();
            string hnum = txtHnum.Text.Trim();
            string dhave = txtDhave.Text.Trim();

            if (string.IsNullOrEmpty(pno) || string.IsNullOrEmpty(prno) || string.IsNullOrEmpty(dno) || string.IsNullOrEmpty(dname))
            {
                MessageBox.Show("请填写完整信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"INSERT INTO have (Pno, Prno, Prname, Dno, Dname, Hnum, Dhave) " +
                         $"VALUES ('{pno}', '{prno}', '{prname}', '{dno}', '{dname}', '{hnum}', '{dhave}')";
            try
            {
                int result = DbHelper.ExecuteNonQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("道具记录保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // 刷新数据
                }
                else
                {
                    MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 删除道具记录
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            string dno = txtDno.Text.Trim();

            if (string.IsNullOrEmpty(pno) || string.IsNullOrEmpty(dno))
            {
                MessageBox.Show("请填写玩家号和道具号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"DELETE FROM have WHERE Pno = '{pno}' AND Dno = '{dno}'";
            try
            {
                int result = DbHelper.ExecuteNonQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("道具记录删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // 刷新数据
                }
                else
                {
                    MessageBox.Show("删除失败，记录可能不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 修改道具记录
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            string prno = txtPrno.Text.Trim();
            string prname = txtPrname.Text.Trim();
            string dno = txtDno.Text.Trim();
            string dname = txtDname.Text.Trim();
            string hnum = txtHnum.Text.Trim();
            string dhave = txtDhave.Text.Trim();

            if (string.IsNullOrEmpty(pno) || string.IsNullOrEmpty(prno) || string.IsNullOrEmpty(dno))
            {
                MessageBox.Show("请填写玩家号、角色号和道具号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $"UPDATE have SET Prname = '{prname}', Dname = '{dname}', Hnum = '{hnum}', Dhave = '{dhave}' " +
                         $"WHERE Pno = '{pno}' AND Prno = '{prno}' AND Dno = '{dno}'";
            try
            {
                int result = DbHelper.ExecuteNonQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("道具记录更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // 刷新数据
                }
                else
                {
                    MessageBox.Show("更新失败，记录可能不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 查询道具记录
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // 加载数据到 DataGridView
        private void LoadData()
        {
            string sql = "SELECT * FROM have";
            if (!string.IsNullOrEmpty(txtPno.Text.Trim()))
            {
                sql += $" WHERE Pno = '{txtPno.Text.Trim()}'";
            }

            try
            {
                DataTable dt = DbHelper.ExecuteReader(sql);
                dgvItems.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageItemForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
