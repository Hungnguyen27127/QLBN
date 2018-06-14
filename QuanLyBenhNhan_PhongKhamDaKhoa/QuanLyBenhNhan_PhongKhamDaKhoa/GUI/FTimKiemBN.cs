using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBenhNhan_PhongKhamDaKhoa.GUI
{
    public partial class FTimKiemBN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM;Initial Catalog=QUANLYBENHNHAN;Integrated Security=True");
        public FTimKiemBN()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bENHNHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void bENHNHANBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }

        private void FTimKiemBN_Load(object sender, EventArgs e)
        {
            using (QUANLYBENHNHANEntities1 db = new QUANLYBENHNHANEntities1())
            {
                bENHNHANBindingSource.DataSource = db.BENHNHANs.ToList();
            }
        }

        private void cbxTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxTimkiem_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            String sql;
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlCommand cmd;
            if(cbxTimkiem.Text.Trim() == "Mã bệnh nhân")
            {
                txtTimkiem.Enabled = true;
                sql = "SELECT * FROM BENHNHAN WHERE MABN = '" + txtTimkiem.Text + "'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            else if (cbxTimkiem.Text.Trim() == "Tên bệnh nhân")
            {
                txtTimkiem.Enabled = true;
                sql = "SELECT * FROM BENHNHAN WHERE TENBN = '" + txtTimkiem.Text + "'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            else if (cbxTimkiem.Text.Trim() == "Tuổi")
            {
                txtTimkiem.Enabled = true;
                sql = "SELECT * FROM BENHNHAN WHERE TUOIBN = '" + txtTimkiem.Text + "'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            else if (cbxTimkiem.Text.Trim() == "Giới tính nam")
            {
                txtTimkiem.Enabled = false;
                sql = "SELECT * FROM BENHNHAN WHERE GIOITINH = N'Nam'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            else if (cbxTimkiem.Text.Trim() == "Giới tính nữ")
            {
                txtTimkiem.Enabled = false;
                sql = "SELECT * FROM BENHNHAN WHERE GIOITINH = N'Nữ'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            else if (cbxTimkiem.Text.Trim() == "Giới tính khác")
            {
                txtTimkiem.Enabled = false;
                sql = "SELECT * FROM BENHNHAN WHERE TENBN = N'Khác'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            
            }
            else if (cbxTimkiem.Text.Trim() == "Địa chỉ")
            {
                txtTimkiem.Enabled = true;
                sql = "SELECT * FROM BENHNHAN WHERE DIACHI = '" + txtTimkiem.Text + "'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            else if(cbxTimkiem.Text.Trim() == "Số điện thoại")
            {
                txtTimkiem.Enabled = true;
                sql = "SELECT * FROM BENHNHAN WHERE SDTBN = '" + txtTimkiem.Text + "'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            else if (cbxTimkiem.Text.Trim() == "Có thẻ BHYT")
            {
                txtTimkiem.Enabled = false;
                sql = "SELECT * FROM BENHNHAN WHERE BHYT = N'Có'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            else if (cbxTimkiem.Text.Trim() == "Không có thẻ BHYT")
            {
                txtTimkiem.Enabled = false;
                sql = "SELECT * FROM BENHNHAN WHERE BHYT = N'Không'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvBN.DataSource = dt;
            }
            con.Close();
        }
    }
}
