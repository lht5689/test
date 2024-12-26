using System;
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class PlayerRechargeForm : Form
    {
        public PlayerRechargeForm()
        {
            InitializeComponent();
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            // 获取输入数据
            string pno = txtPno.Text.Trim();
            string amountText = txtAmount.Text.Trim();

            // 检查输入是否为空
            if (string.IsNullOrEmpty(pno) || string.IsNullOrEmpty(amountText))
            {
                MessageBox.Show("请填写完整信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 验证充值金额是否为数字
            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("请输入有效的充值金额！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 拼接 SQL 语句更新充值额度
                string query = $"UPDATE player SET Pmoney = Pmoney + {amount} WHERE Pno = '{pno}'";

                // 使用 DbHelp 执行查询
                int rowsAffected = DbHelper.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("充值成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("未找到指定的玩家号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("充值失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 关闭窗体
            this.Close();
        }

        private void PlayerRechargeForm_Load(object sender, EventArgs e)
        {
            txtPno.Text = Program.code;
        }
    }
}
