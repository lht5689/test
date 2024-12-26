using System;
using System.Data;
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class PropForm : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public PropForm()
        {
            InitializeComponent();
        }

        // 加载数据
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM prop";
                DataTable props = dbHelper.ExecuteQuery(query);
                dgvProps.DataSource = props;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载数据失败: " + ex.Message);
            }
        }

        // 添加数据
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string dno = txtDno.Text;
                string dname = txtDname.Text;
                string dgrade = txtDgrade.Text;
                string dlimit = chkDlimit.Checked ? "是" : "否";
                string dhave = txtDhave.Text;

                string query = $"INSERT INTO prop (Dno, Dname, Dgrade, Dlimit, Dhave) " +
                               $"VALUES ('{dno}', '{dname}', '{dgrade}', '{dlimit}', '{dhave}')";
                dbHelper.ExecuteNonQuery(query);

                MessageBox.Show("道具添加成功！");
                btnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加道具失败: " + ex.Message);
            }
        }

        // 更新数据
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string dno = txtDno.Text;
                string dname = txtDname.Text;
                string dgrade = txtDgrade.Text;
                string dlimit = chkDlimit.Checked ? "是" : "否";
                string dhave = txtDhave.Text;

                string query = $"UPDATE prop SET Dname = '{dname}', Dgrade = '{dgrade}', " +
                               $"Dlimit = '{dlimit}', Dhave = '{dhave}' WHERE Dno = '{dno}'";
                dbHelper.ExecuteNonQuery(query);

                MessageBox.Show("道具更新成功！");
                btnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新道具失败: " + ex.Message);
            }
        }

        // 删除数据
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string dno = txtDno.Text;

                string query = $"DELETE FROM prop WHERE Dno = '{dno}'";
                dbHelper.ExecuteNonQuery(query);

                MessageBox.Show("道具删除成功！");
                btnLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除道具失败: " + ex.Message);
            }
        }

        // 选中 DataGridView 的行后填充文本框
        private void dgvProps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProps.Rows[e.RowIndex];
                txtDno.Text = row.Cells["Dno"].Value.ToString();
                txtDname.Text = row.Cells["Dname"].Value.ToString();
                txtDgrade.Text = row.Cells["Dgrade"].Value.ToString();
                chkDlimit.Checked = row.Cells["Dlimit"].Value.ToString() == "是";
                txtDhave.Text = row.Cells["Dhave"].Value.ToString();
            }
        }

        private void PropForm_Load(object sender, EventArgs e)
        {
            btnLoad_Click(sender, e);
        }
    }
}
