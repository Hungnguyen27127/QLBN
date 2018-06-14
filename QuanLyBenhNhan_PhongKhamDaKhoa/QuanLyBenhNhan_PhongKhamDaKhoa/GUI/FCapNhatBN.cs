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
    public partial class FCapNhatBN : Form
    {
        String cn = @"Data Source=DESKTOP-EADVFVM;Initial Catalog=QUANLYBENHNHAN;Integrated Security=True";
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        public FCapNhatBN()
        {
            InitializeComponent();
        }
        private void Show()
        {
            SqlConnection con = new SqlConnection(cn);
            con.Open();
            String sql = "DS_BN";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dgvDSBN.DataSource = dt;
            con.Close();
        }
        private void FCapNhatBN_Load(object sender, EventArgs e)
        {
            Show();
            txtma.Enabled = false;
        }

        String bhyt;
        String gioitinh;
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cn);
            if (rbtCo.Checked)
            {
                bhyt = "Có";
            }
            else if (rbtKhong.Checked)
            {
                bhyt = "Không";
            }

            if (rbtnam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rbtnu.Checked)
            {
                gioitinh = "Nữ";
            }
            else if (rbtkhac.Checked)
            {
                gioitinh = "Khác";
            }
            con.Open();
            String sql = "UPDATE BENHNHAN SET TENBN = '" + txtten.Text + "', TUOIBN = '" + txttuoi.Text + "', GIOITINH = N'" + gioitinh + "', DIACHI = '" + txtdiachi.Text + "', SDTBN = '" + txtsdt.Text + "', BHYT = N'" + bhyt + "' WHERE MABN = '" + txtma.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            Show();
            MessageBox.Show("Lưu thành công");
            con.Close();
        }

        private void dgvDSBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int index;
        private void dgvDSBN_Click(object sender, EventArgs e)
        {
            index = dgvDSBN.CurrentRow.Index;
            txtma.Text = dgvDSBN.Rows[index].Cells[0].Value .ToString();
            txtten.Text = dgvDSBN.Rows[index].Cells[1].Value.ToString();
            txttuoi.Text = dgvDSBN.Rows[index].Cells[2].Value.ToString();
            txtdiachi.Text = dgvDSBN.Rows[index].Cells[4].Value.ToString();
            txtsdt.Text = dgvDSBN.Rows[index].Cells[5].Value.ToString();

            if (dgvDSBN.Rows[index].Cells[3].Value.ToString().Trim() == rbtnam.Text)
            {
                rbtnam.Checked = true;
            }
            else if(dgvDSBN.Rows[index].Cells[3].Value.ToString().Trim() == rbtnu.Text)
            {
                rbtnu.Checked = true;
            }
            else
            {
                rbtkhac.Checked = true;
            }

            if (dgvDSBN.Rows[index].Cells[6].Value.ToString().Trim() == rbtCo.Text)
            {
                rbtCo.Checked = true;
            }
            else 
            {

                rbtKhong.Checked = true;
            }
        }
        #region Không cần thiết
        private void rbtCo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtKhong_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtnam_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtnu_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtkhac_CheckedChanged(object sender, EventArgs e)
        {
        }
        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cn);
            con.Open();
            String sql = "DELETE FROM BENHNHAN WHERE MABN = '"+txtma.Text+"'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            Show();
            MessageBox.Show("Xóa thành công");
            con.Close();
        }
    }
}
