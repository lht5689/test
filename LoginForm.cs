using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace GameManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();


            if (string.IsNullOrEmpty(account) )
            {
                MessageBox.Show("账号不能为空！");
                return;
            }

            if (rbPlayer.Checked) // 玩家登录
            {
                if (ValidatePlayerLogin(account))
                {
                    MessageBox.Show("玩家登录成功！");
                    Program.code = account;
                    // 打开玩家主界面
                    PlayerMainForm playerForm = new PlayerMainForm();
                    playerForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("玩家账号错误！");
                }
            }
            else if (rbAdmin.Checked) // 管理员登录
            {
                if (ValidateAdminLogin(account))
                {
                    MessageBox.Show("管理员登录成功！");
                    Program.code = account;
                    // 打开管理员主界面
                    AdminMainForm adminForm = new AdminMainForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("管理员账号错误！");
                }
            }
            else
            {
                MessageBox.Show("请选择登录角色！");
            }
        }

        private bool ValidatePlayerLogin(string account)
        {
            string sql = "SELECT COUNT(*) FROM player WHERE Pno = @Account";
            SqlParameter[] parameters = {
            new SqlParameter("@Account", account),

        };

            object result = DbHelper.ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private bool ValidateAdminLogin(string account)
        {
            string sql = "SELECT COUNT(*) FROM administrator WHERE Ano = @Account";
            SqlParameter[] parameters = {
            new SqlParameter("@Account", account),
          
        };

            object result = DbHelper.ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }
    }
}