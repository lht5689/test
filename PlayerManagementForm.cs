using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class PlayerManagementForm : Form
    {
        public PlayerManagementForm()
        {
            InitializeComponent();
            LoadPlayerData();
        }

        // 加载玩家数据到 DataGridView
        private void LoadPlayerData()
        {
            string sql = "SELECT * FROM player";
            DataTable dt = DbHelper.ExecuteReader(sql);
            dgvPlayers.DataSource = dt;
        }

        // 保存玩家信息（新增或更新）
        private void btnSave_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            string pname = txtPname.Text.Trim();
            string psno = txtpsno.Text.Trim();
            string ptime = dtpPtime.Value.ToString("yyyy-MM-dd");
            string pmoney = txtPmoney.Text.Trim();

            if (string.IsNullOrEmpty(pno) || string.IsNullOrEmpty(pname))
            {
                MessageBox.Show("玩家号和玩家名不能为空！");
                return;
            }

            string sqlCheck = "SELECT COUNT(*) FROM player WHERE Pno = @Pno";
            var checkParams = new[] { new SqlParameter("@Pno", pno) };
            int count = Convert.ToInt32(DbHelper.ExecuteScalar(sqlCheck, checkParams));

            if (count > 0)
            {
                // 更新操作
                string sqlUpdate = "UPDATE player SET Pname = @Pname, psno = @psno, Ptime = @Ptime, Pmoney = @Pmoney WHERE Pno = @Pno";
                var updateParams = new[]
                {
                    new SqlParameter("@Pname", pname),
                    new SqlParameter("@psno", psno),
                    new SqlParameter("@Ptime", ptime),
                    new SqlParameter("@Pmoney", pmoney),
                    new SqlParameter("@Pno", pno)
                };
                DbHelper.ExecuteNonQuery(sqlUpdate, updateParams);
                MessageBox.Show("玩家信息更新成功！");
            }
            else
            {
                // 插入操作
                string sqlInsert = "INSERT INTO player (Pno, Pname, psno, Ptime, Pmoney) VALUES (@Pno, @Pname, @psno, @Ptime, @Pmoney)";
                var insertParams = new[]
                {
                    new SqlParameter("@Pno", pno),
                    new SqlParameter("@Pname", pname),
                    new SqlParameter("@psno", psno),
                    new SqlParameter("@Ptime", ptime),
                    new SqlParameter("@Pmoney", pmoney)
                };
                DbHelper.ExecuteNonQuery(sqlInsert, insertParams);
                MessageBox.Show("玩家信息保存成功！");
            }

            LoadPlayerData();
        }

        // 删除玩家信息
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            if (string.IsNullOrEmpty(pno))
            {
                MessageBox.Show("请输入玩家号！");
                return;
            }

            string sql = "DELETE FROM player WHERE Pno = @Pno";
            var parameters = new[] { new SqlParameter("@Pno", pno) };
            DbHelper.ExecuteNonQuery(sql, parameters);
            MessageBox.Show("玩家信息删除成功！");
            LoadPlayerData();
        }

        // 查询玩家信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            string sql = "SELECT * FROM player WHERE Pno = @Pno";
            var parameters = new[] { new SqlParameter("@Pno", pno) };
            DataTable dt = DbHelper.ExecuteReader(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                dgvPlayers.DataSource = dt;
            }
            else
            {
                MessageBox.Show("未找到玩家信息！");
                LoadPlayerData();
            }
        }

        // 关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 点击 DataGridView 的行填充到文本框
        private void dgvPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPlayers.Rows[e.RowIndex];
                txtPno.Text = row.Cells["Pno"].Value.ToString();
                txtPname.Text = row.Cells["Pname"].Value.ToString();
                txtpsno.Text = row.Cells["psno"].Value.ToString();
                dtpPtime.Value = Convert.ToDateTime(row.Cells["Ptime"].Value);
                txtPmoney.Text = row.Cells["Pmoney"].Value.ToString();
            }
        }

        private void PlayerManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
