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
    public partial class FDonThuoc : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM;Initial Catalog=QUANLYBENHNHAN;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public FDonThuoc()
        {
            InitializeComponent();
        }
        private void Show()
        {
            try
            {
                con.Open();
                String sql = "SHOWDONTHUOC";
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgvDonthuoc.DataSource = dt;
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            
        }
        private String Sinhmatudong()
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(MADT)+1 FROM DONTHUOC", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            String somadt = "00" + dt.Rows[0][0].ToString();
            somadt = somadt.Substring(somadt.Length - 3, 3);
            con.Close();
            return "DT" + somadt;

        }
        private void FDonThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DONTHUOC' table. You can move, or remove it, as needed.
            grbdonthuoc.Enabled = false;
            btnluu.Enabled = false;
            Show();
            Showcbxbacsy();
            Showcbxthuoc();
            Showcbxbenhnhan();
        }

        #region Hiển thị mã trong label
        public void showlblmabs()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT MABS FROM BACSY WHERE TENBS = N'" + cbxbacsy.Text.Trim() + "'", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                lblmabs.Text = "Mã BS: " + dt.Rows[0][0].ToString();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

        }

        public void showlblmabn()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT MABN FROM BENHNHAN WHERE TENBN = N'" + cbxbenhnhan.Text.Trim() + "'", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                lblmabn.Text = "Mã BN: " + dt.Rows[0][0].ToString();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

        }

        public void showlblmathuoc()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT MATHUOC FROM THUOC WHERE TENTHUOC = N'" + cbxthuoc.Text.Trim() + "'", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                lblmathuoc.Text = "Mã thuốc: " + dt.Rows[0][0].ToString();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

        }
        #endregion

        #region Hiển thị combobox
        public void Showcbxbacsy()
        {
            con.Open();
            cmd = new SqlCommand("SELECT MABS, TENBS FROM BACSY", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cbxbacsy.DataSource = dt;
            cbxbacsy.DisplayMember = "TENBS";
            cbxbacsy.ValueMember = "MABS";
            con.Close();
        }

        public void Showcbxthuoc()
        {
            con.Open();
            cmd = new SqlCommand("SELECT MATHUOC, TENTHUOC FROM THUOC", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cbxthuoc.DataSource = dt;
            cbxthuoc.DisplayMember = "TENTHUOC";
            cbxthuoc.ValueMember = "MATHUOC";
            con.Close();
        }

        public void Showcbxbenhnhan()
        {
            con.Open();
            cmd = new SqlCommand("SELECT MABN, TENBN FROM BENHNHAN ORDER BY TENBN, MABN", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cbxbenhnhan.DataSource = dt;
            cbxbenhnhan.DisplayMember = "TENBN";
            cbxbenhnhan.ValueMember = "MABN";
            con.Close();
        }
        #endregion
        public void Showtxttien()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT GIATHUOC FROM THUOC WHERE TENTHUOC = N'" + cbxthuoc.Text.Trim() + "'", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                txttienthuoc.Text = dt.Rows[0][0].ToString();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

        }
        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void cbxthuoc_TextChanged(object sender, EventArgs e)
        {
            Showtxttien();
            showlblmathuoc();
        }

        private void cbxbacsy_TextChanged(object sender, EventArgs e)
        {
            showlblmabs();
        }

        private void cbxbenhnhan_TextChanged(object sender, EventArgs e)
        {
            showlblmabn();
        }
        String luu;

        private void btnluu_Click(object sender, EventArgs e)
        {
            con.Open();
            luu = "INSERT INTO DONTHUOC VALUES ('" + txtmadonthuoc.Text.Trim() + "', '" + lblmabs.Text.Substring(7).Trim() + "', '" + lblmabn.Text.Substring(7).Trim() + "', '" + lblmathuoc.Text.Substring(10).Trim() + "', '" + txttienthuoc.Text.Trim() + "', N'" + txtlieudung.Text.Trim() + "')";
            cmd = new SqlCommand(luu, con);
            cmd.ExecuteNonQuery();
            Show();
            con.Close();
            btnthem.Enabled = true;
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            grbdonthuoc.Enabled = true;
            btnluu.Enabled = true;
            txtmadonthuoc.Text = Sinhmatudong();
            txtlieudung.Focus();
            btnthem.Enabled = false;
        }
    }
}
