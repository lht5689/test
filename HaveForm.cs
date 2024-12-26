using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class HaveForm : Form
    {
        public HaveForm()
        {
            InitializeComponent();
        }

        // 保存按钮点击事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            string prno = txtPrno.Text.Trim();
            string prname = txtPrname.Text.Trim();
            string dno = txtDno.Text.Trim();
            string dname = txtDname.Text.Trim();
            string hnum = txtHnum.Text.Trim();
            string dhave = txtDhave.Text.Trim();

            // 检查必填字段
            if (string.IsNullOrEmpty(pno) || string.IsNullOrEmpty(prno) || string.IsNullOrEmpty(dno) || string.IsNullOrEmpty(dname))
            {
                MessageBox.Show("玩家号、创建角色号、道具号和道具名为必填字段，请填写完整！");
                return;
            }

            string sql = "INSERT INTO have (Pno, Prno, Prname, Dno, Dname, Hnum, Dhave) VALUES (@Pno, @Prno, @Prname, @Dno, @Dname, @Hnum, @Dhave)";
            SqlParameter[] parameters = {
                new SqlParameter("@Pno", pno),
                new SqlParameter("@Prno", prno),
                new SqlParameter("@Prname", prname),
                new SqlParameter("@Dno", dno),
                new SqlParameter("@Dname", dname),
                new SqlParameter("@Hnum", hnum),
                new SqlParameter("@Dhave", dhave)
            };

            int result = DbHelper.ExecuteNonQuery(sql, parameters);
            if (result > 0)
            {
                MessageBox.Show("道具信息保存成功！");
                ClearFields();
            }
            else
            {
                MessageBox.Show("保存失败，请检查输入！");
            }
        }

        // 清空输入框
        private void ClearFields()
        {
            txtPno.Clear();
            txtPrno.Clear();
            txtPrname.Clear();
            txtDno.Clear();
            txtDname.Clear();
            txtHnum.Clear();
            txtDhave.Clear();
        }

        // 关闭按钮点击事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HaveForm_Load(object sender, EventArgs e)
        {
            txtPno.Text = Program.code;
        }
    }
}
