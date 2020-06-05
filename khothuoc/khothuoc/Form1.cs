using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khothuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grvthuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvthuoc.CurrentRow.Index;
            txttenthuoc.Text = grvthuoc.Rows[i].Cells[0].Value.ToString();
            txtloaithuoc.Text = grvthuoc.Rows[i].Cells[1].Value.ToString();
            txthsd.Text = grvthuoc.Rows[i].Cells[1].Value.ToString();

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string sql = "select .... like N'%" + txttenthuoc.Text + "%'";
            grvthuoc.DataSource = db.getData(sql);
        }

       
    
}
