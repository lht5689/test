using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GameManagementSystem
{
    public partial class CreatedRoleManageForm : Form
    {
        public CreatedRoleManageForm()
        {
            InitializeComponent();
            LoadData();
        }
           public DatabaseHelper helper = new DatabaseHelper();
        // 加载数据到 DataGridView
        private void LoadData()
        {
            string sql = "SELECT * FROM created";
            DataTable dt = helper.ExecuteQuery(sql);
            dgvRoles.DataSource = dt;
        }

        // 添加玩家创建角色
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            string pname = txtPname.Text.Trim();
            string rno = txtRno.Text.Trim();
            string prno = txtPrno.Text.Trim();
            string prname = txtPrname.Text.Trim();
            string cdate = dtpCdate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(pno) || string.IsNullOrEmpty(prno))
            {
                MessageBox.Show("玩家号和创建角色号不能为空！");
                return;
            }

            string sql = "INSERT INTO created (Pno, Pname, Rno, Prno, Prname, Cdate) VALUES (@Pno, @Pname, @Rno, @Prno, @Prname, @Cdate)";
            SqlParameter[] parameters = {
                new SqlParameter("@Pno", pno),
                new SqlParameter("@Pname", pname),
                new SqlParameter("@Rno", rno),
                new SqlParameter("@Prno", prno),
                new SqlParameter("@Prname", prname),
                new SqlParameter("@Cdate", cdate)
            };

            int result = DbHelper.ExecuteNonQuery(sql, parameters);
            if (result > 0)
            {
                MessageBox.Show("添加成功！");
                LoadData();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        // 修改选中记录
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null)
            {
                MessageBox.Show("请先选择一行进行修改！");
                return;
            }

            string pno = txtPno.Text.Trim();
            string pname = txtPname.Text.Trim();
            string rno = txtRno.Text.Trim();
            string prno = txtPrno.Text.Trim();
            string prname = txtPrname.Text.Trim();
            string cdate = dtpCdate.Value.ToString("yyyy-MM-dd");

            string sql = "UPDATE created SET Pname = @Pname, Rno = @Rno, Prname = @Prname, Cdate = @Cdate WHERE Pno = @Pno AND Prno = @Prno";
            SqlParameter[] parameters = {
                new SqlParameter("@Pno", pno),
                new SqlParameter("@Pname", pname),
                new SqlParameter("@Rno", rno),
                new SqlParameter("@Prno", prno),
                new SqlParameter("@Prname", prname),
                new SqlParameter("@Cdate", cdate)
            };

            int result = DbHelper.ExecuteNonQuery(sql, parameters);
            if (result > 0)
            {
                MessageBox.Show("修改成功！");
                LoadData();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        // 删除选中记录
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null)
            {
                MessageBox.Show("请先选择一行进行删除！");
                return;
            }

            string pno = dgvRoles.CurrentRow.Cells["Pno"].Value.ToString();
            string prno = dgvRoles.CurrentRow.Cells["Prno"].Value.ToString();

            string sql = "DELETE FROM created WHERE Pno = @Pno AND Prno = @Prno";
            SqlParameter[] parameters = {
                new SqlParameter("@Pno", pno),
                new SqlParameter("@Prno", prno)
            };

            int result = DbHelper.ExecuteNonQuery(sql, parameters);
            if (result > 0)
            {
                MessageBox.Show("删除成功！");
                LoadData();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        // 查询记录
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pno = txtPno.Text.Trim();
            string prno = txtPrno.Text.Trim();

            string sql = "SELECT * FROM created WHERE 1=1";
            if (!string.IsNullOrEmpty(pno))
            {
                sql += " AND Pno = @Pno";
            }
            if (!string.IsNullOrEmpty(prno))
            {
                sql += " AND Prno = @Prno";
            }

            SqlParameter[] parameters = {
                new SqlParameter("@Pno", pno),
                new SqlParameter("@Prno", prno)
            };

            DataTable dt = DbHelper.ExecuteReader(sql, parameters);
            dgvRoles.DataSource = dt;
        }

        // 刷新列表
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // DataGridView 单击事件，填充文本框
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPno.Text = dgvRoles.Rows[e.RowIndex].Cells["Pno"].Value.ToString();
                txtPname.Text = dgvRoles.Rows[e.RowIndex].Cells["Pname"].Value.ToString();
                txtRno.Text = dgvRoles.Rows[e.RowIndex].Cells["Rno"].Value.ToString();
                txtPrno.Text = dgvRoles.Rows[e.RowIndex].Cells["Prno"].Value.ToString();
                txtPrname.Text = dgvRoles.Rows[e.RowIndex].Cells["Prname"].Value.ToString();
                dtpCdate.Value = DateTime.Parse(dgvRoles.Rows[e.RowIndex].Cells["Cdate"].Value.ToString());
            }
        }

        private void CreatedRoleManageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
