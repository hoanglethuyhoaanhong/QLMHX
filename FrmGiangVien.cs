﻿using DevExpress.XtraEditors;
using QLMHX.QuanLyDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMHX
{
    public partial class FrmGiangVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool dangThemMoi = false;
        public FrmGiangVien()
        {
            InitializeComponent();
        }

        private void giangVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giangVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyDS);

        }

        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            quanLyDS.EnforceConstraints = false;
            giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.giangVienTableAdapter.Fill(this.quanLyDS.GiangVien);

            comboBox1.DataSource = Program.bindingSource;
            comboBox1.DisplayMember = "Ten";
            comboBox1.ValueMember = "IdKhoa";
        }

        public string ConvertToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            if (input[input.Length - 1] == ' ')
            {
                input = input.Substring(0, input.Length - 1);
            }

            string[] words = input.ToLower().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    char[] letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    words[i] = new string(letters);
                }
            }

            return string.Join(" ", words);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            giangVienTableAdapter.Fill(quanLyDS.GiangVien);

            dangThemMoi = true;
            groupControl1.Enabled = false;

            comboBox1.Visible = true;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            giangVienBindingSource.AddNew();
            comboBox1.SelectedIndex = 0;
            idKhoaTextEdit.Text = comboBox1.SelectedValue.ToString();

            string sql = "SELECT MAX(idGV) FROM GiangVien";
            SqlCommand command = new SqlCommand(sql, Program.conn);
            string tmp = string.Empty;

            try
            {
                Program.conn.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    tmp = result.ToString();

                    txtId.Text = (int.Parse(tmp) + 1).ToString();
                }

                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo");
                Console.WriteLine(ex.Message);

                Program.conn.Close();

                return;
            }

            groupControl3.Enabled = true;

            labelHo.Text = "Không được bỏ trống!";
            labelTen.Text = "Không được bỏ trống!";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {           
            if (txtId.Text.Trim() == Program.magv)
            {
                MessageBox.Show("Không thể tự xóa dữ liệu của bản thân!", "Thông báo");
                return;
            }

            if (txtNhom.Text.Length != 0)
            {
                MessageBox.Show("Giảng viên này đã tham gia vào 01 nhóm, không thể xóa!", "Thông báo");
                return;
            }
            else
            {
                string txt = "Tiến hành xóa giảng viên " + txtHo.Text + " " + txtTen.Text + " (Id: " + txtId.Text.Trim() + ") ra khỏi DB?";

                if (MessageBox.Show(txt, "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    vitri = giangVienBindingSource.Position;

                    giangVienBindingSource.RemoveCurrent();

                    giangVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    giangVienTableAdapter.Update(quanLyDS.GiangVien);

                    MessageBox.Show("Xóa giảng viên thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Xóa giảng viên thất bại!", "Thông báo");
                    giangVienTableAdapter.Fill(quanLyDS.GiangVien);
                    giangVienBindingSource.Position = vitri;
                    return;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            vitri = giangVienBindingSource.Position;

            BtnXoa.Enabled = false;
            BtnSua.Enabled = false;
            BtnThem.Enabled = false;
            BtnReload.Enabled = false;
            BtnUndo.Enabled = true;
            BtnGhi.Enabled = true;

            if (txtNhom.Text.Trim() == "")
            {
                comboBox1.Visible = true;
                comboBox1.SelectedValue = int.Parse(idKhoaTextEdit.Text);
            }

            groupControl1.Enabled = false;
            groupControl3.Enabled = true;
            txtHo.Focus();
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (labelHo.Text != "" || labelTen.Text != "" || labelSDT.Text != "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }

            txtHo.Text = ConvertToTitleCase(txtHo.Text);
            txtTen.Text = ConvertToTitleCase(txtTen.Text);

            string txt = "Lưu thông tin giảng viên vừa được thêm/sửa?";

            if (MessageBox.Show(txt, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    giangVienBindingSource.EndEdit();
                    giangVienTableAdapter.Update(quanLyDS.GiangVien);

                    groupControl1.Enabled = true;
                    groupControl3.Enabled = false;

                    BtnXoa.Enabled = true;
                    BtnSua.Enabled = true;
                    BtnThem.Enabled = true;
                    BtnReload.Enabled = true;
                    BtnUndo.Enabled = false;
                    BtnGhi.Enabled = false;
                    comboBox1.Visible = false;

                    if (dangThemMoi == true)
                    {
                        dangThemMoi = false;
                        giangVienTableAdapter.Fill(quanLyDS.GiangVien);
                    }
                    else
                    {
                        giangVienBindingSource.ResetCurrentItem();
                    }

                    MessageBox.Show("Lưu thành công!\nHệ thống sẽ tự động reload...", "Thông báo");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu thông tin thất bại!\n" + ex.Message, "Thông báo");
                    return;
                }
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (dangThemMoi == true && BtnThem.Enabled == false)
            {
                giangVienBindingSource.CancelEdit();
                giangVienBindingSource.Position = vitri;

                dangThemMoi = false;
            }
            else
            {
                giangVienTableAdapter.Fill(quanLyDS.GiangVien);
                giangVienBindingSource.Position = vitri;
            }

            groupControl1.Enabled = true;
            groupControl3.Enabled = false;
            comboBox1.Visible = false;

            BtnXoa.Enabled = true;
            BtnSua.Enabled = true;
            BtnThem.Enabled = true;
            BtnReload.Enabled = true;
            BtnUndo.Enabled = false;
            BtnGhi.Enabled = false;
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            giangVienTableAdapter.Fill(quanLyDS.GiangVien);
        }

        private void hoTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 20)
            {
                textBox.Text = textBox.Text.Substring(0, 20);
                textBox.Select(20, 0);
            }

            if (string.IsNullOrWhiteSpace(txtHo.Text))
            {
                labelHo.Text = "Không được để trống!";
            }
            else
            {
                labelHo.Text = "";
            }
        }

        private void tenTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length > 30)
            {
                textBox.Text = textBox.Text.Substring(0, 30);
                textBox.Select(30, 0);
            }

            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                labelTen.Text = "Không được để trống!";
            }
            else
            {
                labelTen.Text = "";
            }
        }

        private void hoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                labelHo.Text = "Chỉ nhận ký tự alphabet!";
            }

            if (e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Space)
            {
                e.Handled = false;
            }
        }

        private void hoTextBox_Leave(object sender, EventArgs e)
        {
            if (labelHo.Text == "Chỉ nhận ký tự alphabet!")
            {
                if (txtHo.Text.Length != 0) labelHo.Text = "";
                else labelHo.Text = "Không được để trống!";
            }

            txtHo.Text = txtHo.Text.Trim();
        }

        private void tenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                labelTen.Text = "Chỉ nhận ký tự alphabet!";
            }

            if (e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Space)
            {
                e.Handled = false;
            }
        }

        private void tenTextBox_Leave(object sender, EventArgs e)
        {
            if (labelTen.Text == "Chỉ nhận ký tự alphabet!")
            {
                if (txtTen.Text.Length != 0) labelTen.Text = "";
                else labelTen.Text = "Không được để trống!";
            }
        }

        private void emailTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "@ptithcm.edu.vn")
            {
                labelEmail.Text = "Vui lòng nhập đầy đủ!";
            }
            else
            {
                labelEmail.Text = "";
            }
        }

        private void sDTTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length == 0)
            {
                labelSDT.Text = "Không được bỏ trống";
            }
            else
            {
                labelSDT.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "@ptithcm.edu.vn")
            {
                txtEmail.Text = "";
            }
        }

        private void idKhoaTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idKhoaTextEdit.Text = comboBox1.SelectedValue.ToString();
        }
    }
}