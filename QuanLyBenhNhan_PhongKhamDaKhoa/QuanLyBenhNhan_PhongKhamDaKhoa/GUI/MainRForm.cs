using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QuanLyBenhNhan_PhongKhamDaKhoa
{
    public partial class MainRForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainRForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void btnThemBN_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Hide();
            GUI.FBenhNhan fbn = new GUI.FBenhNhan();
            fbn.MdiParent = this;
            fbn.Show();
        }

        private void btnCapnhatTTBN_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Hide();
            GUI.FCapNhatBN fbn = new GUI.FCapNhatBN();
            fbn.MdiParent = this;
            fbn.Show();
        }

        private void btnXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Hide();
            GUI.FInDSBN ids = new GUI.FInDSBN();
            ids.MdiParent = this;
            ids.Show();
        }

        private void btnTimkiemBN_ItemClick(object sender, ItemClickEventArgs e)
        {
            pictureBox1.Hide();
            GUI.FTimKiemBN tkbn = new GUI.FTimKiemBN();
            tkbn.MdiParent = this;
            tkbn.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.FDonThuoc dt = new GUI.FDonThuoc();
            dt.MdiParent = this;
            dt.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.TKvaInDonthuoc donthuoc = new GUI.TKvaInDonthuoc();
            donthuoc.MdiParent = this;
            donthuoc.Show();
        }
    }
}