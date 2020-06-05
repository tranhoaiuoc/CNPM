using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace khothuoc
{
    public partial class NhapThuoc : Form
    {
        SqlConnection conn;
        DBconnect db = new DBconnect();

        public NhapThuoc()
        {
            InitializeComponent();
        }

        private void NhapThuoc_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            cboIDThuoc.DisplayMember = "IDThuoc";
            cboIDThuoc.ValueMember = "IDThuoc";
            cboIDThuoc.DataSource = db.getData("select * from tblthuoc");

        }
        private void RefreshDataGridView()
        {
            dgvNhapThuoc.DataSource = db.getData("SELECT * FROM tblnhaphang");
        }

        private int check(string st, string str, string txt)
        {
            string sql = "select COUNT(*) from " + str + " where " + st + " = '" + txt + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int a = (int)cmd.ExecuteScalar();
            return a;
        }
        private Boolean checkAll()
        {
            if (cboIDThuoc.Text.Equals("") | txtIDDonNhap.Text.Equals("") | txtNgayNhap.Text.Equals("") | txtSoLuongNhap.Text.Equals(""))
                return true;

            return false;
        }

        private void dgvNhapThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhapThuoc.CurrentRow.Index;
            cboIDThuoc.Text = dgvNhapThuoc.Rows[i].Cells[0].Value.ToString();
            txtIDDonNhap.Text = dgvNhapThuoc.Rows[i].Cells[1].Value.ToString();
            txtNgayNhap.Text = dgvNhapThuoc.Rows[i].Cells[2].Value.ToString();
            txtSoLuongNhap.Text = dgvNhapThuoc.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void xoatext(Control ctr)
        {
            if (ctr is TextBox)
            {
                ctr.Text = string.Empty;
            }
            foreach (Control i in ctr.Controls)
            {
                xoatext(i);
            }
        }

        private void btbThem_Click(object sender, EventArgs e)
        {
            xoatext(this);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (checkAll())
            {
                MessageBox.Show("Không được để trống!", "Thông báo");
            }
            else
            {
                conn = db.connected();
                conn.Open();
                if(check("IDDonNhap","tblnhaphang",txtIDDonNhap.Text) == 0)
                {
                    String sql = "insert into tblnhaphang values('" + txtIDDonNhap.Text + "','" + cboIDThuoc.Text + "','" + txtSoLuongNhap.Text + "','" + txtNgayNhap.Text + "')";
                    db.excute(sql);
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("don nhap nay da ton tai!", "Thong bao!");
                }
                conn.Close();
            }
        }
    }
}
