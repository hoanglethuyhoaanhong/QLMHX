using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = Program.mHoten + " - " + Program.mGroup;

            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            string cmd = "SELECT * FROM Khoa";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);

            Program.conn.Close();
            Program.bindingSource.DataSource = dt;

            string sql = "SELECT IdKhoa FROM GiangVien WHERE IdGV = '" + Program.magv + "'";
            SqlCommand command = new SqlCommand(sql, Program.conn);
            string tmp = string.Empty;

            try
            {
                Program.conn.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    tmp = result.ToString();

                    Program.khoa = tmp;
                }

                Program.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Program.conn.Close();

                return;
            }

            Console.WriteLine(Program.khoa);
        }

        private Form isActive(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype) return f;
            }

            return null;
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmGiangVien));
            if (form == null)
            {
                FrmGiangVien f = new FrmGiangVien();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmSinhVien));
            if (form == null)
            {
                FrmSinhVien f = new FrmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void BtnKhoa_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(frmKhoa));
            if (form == null)
            {
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnNhomGV_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmNhomGV));
            if (form == null)
            {
                FrmNhomGV f = new FrmNhomGV();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnNhomSV_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmNhomSV));
            if (form == null)
            {
                FrmNhomSV f = new FrmNhomSV();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnDiaBan_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmDiaBan));
            if (form == null)
            {
                FrmDiaBan f = new FrmDiaBan();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnNhaDan_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmNhaDan));
            if (form == null)
            {
                FrmNhaDan f = new FrmNhaDan();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnCuTru_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmAp));
            if (form == null)
            {
                FrmAp f = new FrmAp();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Hide();

            Program.conn.Close();

            Login loginForm = new Login();

            loginForm.ShowDialog();
        }

        private void btnXa_Click(object sender, EventArgs e)
        {
            Form form = isActive(typeof(FrmXa));
            if (form == null)
            {
                FrmXa f = new FrmXa();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }
    }
}