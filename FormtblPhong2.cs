using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan1
{
    public partial class FormtblPhong2 : Form
    {
        SqlConnection con = new SqlConnection();
        public FormtblPhong2()
        {
            InitializeComponent();
        }

        private void FormtblPhong2_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();
            loaddatatogridview();
        }

        private void loaddatatogridview()
        {
            string sql = "select*from tblPhong";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tabletblPhong = new DataTable();
            adp.Fill(tabletblPhong);
            dataGridView_tblPhong.DataSource = tabletblPhong;
        }

        private void btnthem_click(object sender, EventArgs e)
        {
            txtMaP.Enabled = true;
            txtMaP.Text = "";
            txtDonGia.Text = "";
            txtTenP.Text = "";
        }

        private void dataGridView_tblPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDonGia.Text = dataGridView_tblPhong.CurrentRow.Cells["DonGia"].Value.ToString();
            txtMaP.Text = dataGridView_tblPhong.CurrentRow.Cells["MaP"].Value.ToString();
            txtTenP.Text = dataGridView_tblPhong.CurrentRow.Cells["TenP"].Value.ToString();
            txtMaP.Enabled = false;
        }

        private void btnxoa_click(object sender, EventArgs e)
        {
            string sql = "delete from blPhong where MaP='"+ txtMaP.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loaddatatogridview();
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <=9)) ||
                (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtMaP.Text = "";
            txtDonGia.Text = "";
            txtTenP.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "update blPhong set TenP= '" + txtTenP.Text + txtDonGia.Text + "' where MaP='" + txtMaP.Text + "'";
                if (txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đơn giá");
                txtDonGia.Focus();
                return;
            }
            if (txtTenP.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên phòng");
                txtTenP.Focus();
                return;
            }
            //txtmaP.Enable = false;
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loaddatatogridview();
        }
    }
}
