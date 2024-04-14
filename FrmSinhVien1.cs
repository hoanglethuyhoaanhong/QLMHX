using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class FrmSinhVien1 : DevExpress.XtraEditors.XtraForm
    {
        public FrmSinhVien1()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDS);

        }

        private void FrmSinhVien1_Load(object sender, EventArgs e)
        {
            quanLyDS.EnforceConstraints = false;
            this.sinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhVienTableAdapter.Fill(this.quanLyDS.SinhVien);

        }
    }
}