using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV_Winform
{
    public partial class Form2 : Form
    {
        ControllerSQL cs = new ControllerSQL();
        public Form2()
        {
            InitializeComponent();
        }
        private void outputDataSQL()
        {
            string idGV = ControllerSQL.IdQuery.Trim();
            DataTable dt = cs.adapterQueryDS(String.Format("SELECT * FROM TTCT_GV WHERE MaGV='{0}'", idGV));
            //MessageBox.Show(String.Format("SELECT * FROM GV WHERE '{0}'", idGV));
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox) ctr.DataBindings.Clear();
            }
            txt_hotengv.DataBindings.Add("Text", dt, "HoTen");
            txt_dvdt.DataBindings.Add("Text", dt, "TenDonVi");
            txt_ghichu.DataBindings.Add("Text", dt, "GhiChu");
            txt_sdt.DataBindings.Add("Text", dt, "Sdt");
            txt_coso.DataBindings.Add("Text", dt, "TenCoSo");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            outputDataSQL();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }
    }
}
