using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_2
{
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            lstQuanLySach.View = View.Details;
            lstQuanLySach.GridLines = true;
            lstQuanLySach.Columns.Add("ma_sach", 100);
            lstQuanLySach.Columns.Add("ten_sach", 200);
            lstQuanLySach.Columns.Add("tac_gia", 150);
            lstQuanLySach.Columns.Add("nha_xuat_ban", 150);
            lstQuanLySach.Columns.Add("the_loai", 150);
            lstQuanLySach.Columns[0].Text = "Mã sách";
            lstQuanLySach.Columns[0].Text = "Tên sách";
            lstQuanLySach.Columns[0].Text = "Tác giả";
            lstQuanLySach.Columns[0].Text = "Nhà xuất bản";
            lstQuanLySach.Columns[0].Text = "Thể loại";
        }
    }
}
