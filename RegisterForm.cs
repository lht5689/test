using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace GameManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string name = txtName.Text.Trim();


            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("所有字段均不能为空！");
                return;
            }

            if (RegisterPlayer(account, name))
            {
                MessageBox.Show("注册成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败，账号可能已存在！");
            }
        }

        private bool RegisterPlayer(string account, string name)
        {
            string sql = "INSERT INTO player (Pno, Pname, Ptime,Psno,Pmoney) VALUES (@Account, @Name, GETDATE(), 0,0)";
            SqlParameter[] parameters = {
            new SqlParameter("@Account", account),
            new SqlParameter("@Name", name),
        };

            try
            {
                return DbHelper.ExecuteNonQuery(sql, parameters) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}