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
    public partial class role : Form
    {
        public role()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register_Dosen register = new Register_Dosen();
            register.Visible = true;
        }
    }
}
