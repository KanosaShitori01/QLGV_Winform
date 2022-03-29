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
    public partial class Form1 : Form
    {
        // Khai báo class thao túng quyền năng SQL
        ControllerSQL cs = new ControllerSQL();
        public Form1()
        {
            InitializeComponent();
        }
        // Hàm in dữ liệu ra SQL ra ngoài
        private void outputDataSQL()
        {
            DataTable data = cs.adapterQueryDS("SELECT * FROM COSO");
            // gắn dữ liệu của bảng COSO vào combobox
            cb_coso.DataSource = data;
            cb_coso.DisplayMember = "MaCoSo";
            cb_coso.ValueMember = "MaCoSo";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            outputDataSQL();
        }
        // Thiết lập sự kiện lựa chọn cơ sở cho Combobox
        private void cb_coso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = String.Format("SELECT * FROM DONVI WHERE MaCoSo='{0}'", cb_coso.Text.Trim());
            // Gắn dữ liệu của bảng DONVI dựa trên Mã Cơ Sở vào ComboBox
            cb_donvidt.DataSource = cs.adapterQueryDS(query);
            cb_donvidt.DisplayMember = "MaDonVi";
            cb_donvidt.ValueMember = "MaDonVi";
        }

        private void cb_donvidt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // In dữ liệu cần thiết ra DataGridView
            dataGV.DataSource = cs.adapterQueryDS("SELECT MaGV,HoTen FROM GV WHERE MaDonVi='" + cb_donvidt.Text + "'");
            // Lập STT cho Data Grid View
            for (int i = 0; i < dataGV.RowCount - 1; i++)
            {
                dataGV.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dataGV_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        // Thiết lập sự kiện chuột phải vào các dòng trong comboBox
        private void dataGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGV.Rows[e.RowIndex].Selected = true;
                dataGV.CurrentCell = dataGV.Rows[e.RowIndex].Cells[1];
                contextMenuTr.Show(dataGV, e.Location);
                contextMenuTr.Show(Cursor.Position);
            }
        }
        // Context Menu Trip 1
        private void hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Khai báo Form chi tiết thông tin giáo viên
            Form2 TTCT = new Form2();
            // Lưu trữ mã giáo viên của Form 1 để gửi sang Form 2
            ControllerSQL.IdQuery = dataGV.CurrentRow.Cells["MaGV"].Value.ToString();
            // Gọi Form 2 ra
            TTCT.Show();
        }
        // Context Menu Trip 2
        private void xóaGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Khai báo hai biến mã GV và Họ Tên
            string idGV = dataGV.CurrentRow.Cells["MaGV"].Value.ToString();
            string nameGV = dataGV.CurrentRow.Cells["HoTen"].Value.ToString();
            // Khai báo hai biến lệnh SQL và thông báo
            string query = String.Format("DELETE FROM GV WHERE MaGV='{0}'", idGV);
            string alert = String.Format("Đã xóa giáo viên {0}", nameGV);
            // Hộp thông báo xác thực
            DialogResult dia_res = MessageBox.Show("Bạn có chắc muốn xóa " + nameGV + " không?", "Xóa Giáo Viên", MessageBoxButtons.YesNo);
            // Nếu nhấn Yes sẽ tiếp tục xóa
            if (dia_res == DialogResult.Yes)
            {
                cs.commandQuerySQL(query, alert);
                outputDataSQL();
            }
        }
    }
}
