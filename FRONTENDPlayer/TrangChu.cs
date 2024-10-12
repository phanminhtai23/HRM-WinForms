using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONTENDPlayer
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();

        }


        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Ten_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắn chắn muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dangnhap dangnhap = new Dangnhap();
                dangnhap.Show();
            }
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị thông báo xác nhận
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?",
                                           "Xác nhận thoát",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", hủy việc đóng form
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy hành động đóng
            }
        }
    }
}