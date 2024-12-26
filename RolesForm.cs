using System;
using System.Data;
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();
        }
        public DatabaseHelper SqlServerHelper = new DatabaseHelper();

        // 加载角色数据到 DataGridView
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM roles";
                DataTable table = SqlServerHelper.ExecuteQuery(query);
                dgvRoles.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载失败：" + ex.Message);
            }
        }

        // 添加角色
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $@"
                INSERT INTO roles (Rno, Rname, Rsex, Race, Rjob, Rjoin) 
                VALUES ('{txtRno.Text}', '{txtRname.Text}', '{comboBox1.Text}', '{txtRace.Text}', '{txtRjob.Text}', '{txtRjoin.Text}')";

                 SqlServerHelper.ExecuteNonQuery(query);

              
                    MessageBox.Show("角色添加成功！");
                    btnLoad_Click(sender, e); // 刷新数据
                
               
                    MessageBox.Show("添加失败！");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败：" + ex.Message);
            }
        }

        // 更新角色
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $@"
                UPDATE roles 
                SET Rname = '{txtRname.Text}', 
                    Rsex = '{comboBox1.Text}', 
                    Race = '{txtRace.Text}', 
                    Rjob = '{txtRjob.Text}', 
                    Rjoin = '{txtRjoin.Text}' 
                WHERE Rno = '{txtRno.Text}'";

                SqlServerHelper.ExecuteNonQuery(query);

               
                    MessageBox.Show("角色更新成功！");
                    btnLoad_Click(sender, e); // 刷新数据
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失败：" + ex.Message);
            }
        }

        // 删除角色
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM roles WHERE Rno = '{txtRno.Text}'";

                SqlServerHelper.ExecuteNonQuery(query);

                MessageBox.Show("角色删除成功！");
                btnLoad_Click(sender, e); // 刷新数据
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败：" + ex.Message);
            }
        }

        // DataGridView 单元格点击事件
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoles.Rows[e.RowIndex];
                txtRno.Text = row.Cells["Rno"].Value.ToString();
                txtRname.Text = row.Cells["Rname"].Value.ToString();
                comboBox1.Text = row.Cells["Rsex"].Value.ToString();
                txtRace.Text = row.Cells["Race"].Value.ToString();
                txtRjob.Text = row.Cells["Rjob"].Value.ToString();
                txtRjoin.Text = row.Cells["Rjoin"].Value.ToString();
            }
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            btnLoad_Click(sender, e);
        }
    }
}
