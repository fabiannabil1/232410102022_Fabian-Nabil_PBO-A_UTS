using _232410102022_Fabian_Nabil_PBO_A_UTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _232410102022_Fabian_Nabil_PBO_A_UTS
{
    public partial class Register_Dosen : Form
    {
        private Register_Dosen register;
        DosenContext masuk_db;
        public Register_Dosen()
        {
            InitializeComponent();
            Register_Dosen register = new Register_Dosen();
            DosenContext masuk_db = new DosenContext();
        }
        public Dosen Get_Dosen()
        {
            Dosen dosen = new Dosen();
            dosen.NIK_dosen = Convert.ToInt32(NIK_dosen.Text);
            dosen.email_dosen = email_dosen.Text;
            dosen.nama_dosen = nama_dosen.Text;
            dosen.nomor_hp_dosen = Convert.ToInt32(no_hp_dosen.Text);
            dosen.password_dosen = password_dosen.Text;
            return dosen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Dosen_Load(object sender, EventArgs e)
        {

        }

        private void nama_dosen_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_dosen_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIK_dosen_TextChanged(object sender, EventArgs e)
        {

        }

        private void no_hp_dosen_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_dosen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reg_dosen_Click(object sender, EventArgs e)
        {
            using(Halaman_Dosen formhasildosen = new Halaman_Dosen())
            {
                if (formhasildosen.ShowDialog() == DialogResult.OK)
                {
                    Dosen form_dosen = register.Get_Dosen();
                    masuk_db.insert(form_dosen);
                    MessageBox.Show("Register berhasil");
                    formhasildosen.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Register gagal");
                }

            }
        }
    }
}
