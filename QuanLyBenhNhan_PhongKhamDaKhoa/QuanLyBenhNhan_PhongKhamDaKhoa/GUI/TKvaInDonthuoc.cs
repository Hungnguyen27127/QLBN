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
    public partial class TKvaInDonthuoc : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EADVFVM;Initial Catalog=QUANLYBENHNHAN;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public TKvaInDonthuoc()
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

        private void Showcbxbenhnhan()
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
            dt = null;
        }

        private void TKvaInDonthuoc_Load(object sender, EventArgs e)
        {
            Show();
            Showcbxbenhnhan();
        }

        private void cbxbenhnhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String sql;
                con.Open();
                sql = "SHOWDONTHUOC_THEOBN";
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenbn", cbxbenhnhan.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                //da = new SqlDataAdapter(cmd);
                //da.Fill(dt);
                //dgvDonthuoc.DataSource = dt;
                Show();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            

        }
    }
}
