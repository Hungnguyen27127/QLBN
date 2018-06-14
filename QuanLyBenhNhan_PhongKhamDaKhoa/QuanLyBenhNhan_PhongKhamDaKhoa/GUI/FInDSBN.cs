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
using System.Threading;
using Microsoft.Office.Interop.Excel;

namespace QuanLyBenhNhan_PhongKhamDaKhoa.GUI
{
    public partial class FInDSBN : Form
    {
        String cn = @"Data Source=DESKTOP-EADVFVM;Initial Catalog=QUANLYBENHNHAN;Integrated Security=True";
        SqlConnection con;
        public FInDSBN()
        {
            InitializeComponent();
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<BENHNHAN> list = ((DataParameter)e.Argument).DSBN;
            String filename = ((DataParameter)e.Argument).FileName;
            MessageBox.Show(list.Count.ToString());
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = list.Count;
            //Thêm cột 
            ws.Cells[1, 1] = "Mã bệnh nhân";
            ws.Cells[1, 2] = "Tên bệnh nhân";
            ws.Cells[1, 3] = "Tuổi";
            ws.Cells[1, 4] = "Giới tính";
            ws.Cells[1, 5] = "Địa chỉ";
            ws.Cells[1, 6] = "Số điện thoại";
            ws.Cells[1, 7] = "BHYT";
            foreach (BENHNHAN bn in list)
            {
                if(!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = bn.MABN.ToString();
                    ws.Cells[index, 2] = bn.TENBN.ToString();
                    ws.Cells[index, 3] = bn.TUOIBN.ToString();
                    ws.Cells[index, 4] = bn.GIOITINH.ToString();
                    ws.Cells[index, 5] = bn.DIACHI.ToString();
                    ws.Cells[index, 6] = bn.SDTBN.ToString();
                    ws.Cells[index, 7] = bn.BHYT.ToString();
                }
            }
            //Lưu File
            ws.SaveAs(filename, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            excel.Quit();
        } 

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblTrangthai.Text = String.Format("Đang chạy... {0}", e.ProgressPercentage);
            progressBar1.Update();
        }

        private void FInDanhSach_Load(object sender, EventArgs e)
        {
            using (QUANLYBENHNHANEntities1 db = new QUANLYBENHNHANEntities1())
            {
                bENHNHANBindingSource.DataSource = db.BENHNHANs.ToList();
            }
        }   

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error == null)
            {
                Thread.Sleep(100);
                lblTrangthai.Text = "Xuất ra file thành công";
            }
        }
        struct DataParameter
        {
            public List<BENHNHAN> DSBN;
            public String FileName { get; set; }
        }

        DataParameter _dataParameter;
        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                return;
            }
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls" })
            {
                
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    _dataParameter.FileName = sfd.FileName;
                    _dataParameter.DSBN = bENHNHANBindingSource.DataSource as List<BENHNHAN>;
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync(_dataParameter);
                }
            }
        }
    }
}
