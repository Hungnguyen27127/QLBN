using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan_PhongKhamDaKhoa.GUI
{
    public partial class FBenhNhan : Form
    {
        public FBenhNhan()
        {
            InitializeComponent();
        }

        private void bENHNHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void bENHNHANBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            /*
            this.Validate();
            this.bENHNHANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            */
        }

        private void FBenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.BENHNHAN' table. You can move, or remove it, as needed.
            this.bENHNHANTableAdapter.Fill(this.dataSet1.BENHNHAN);
            grbBenhnhan.Enabled = false;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            grbBenhnhan.Enabled = true;
            bENHNHANBindingSource.AddNew();
            txtMa.Text = Sinhmatudong();
            txtTen.Focus();
            btnThem.Enabled = false;
        }

        private String Sinhmatudong()
        {
            DataSet1TableAdapters.QueriesTableAdapter q = new DataSet1TableAdapters.QueriesTableAdapter();
            String somabn = "00" + q.getSOMABN().ToString();
            somabn = somabn.Substring(somabn.Length - 3, 3);
            return "BN" + somabn;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bENHNHANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            btnThem.Enabled = true;
        }
    }
}
