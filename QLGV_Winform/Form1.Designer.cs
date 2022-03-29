namespace QLGV_Winform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_coso = new System.Windows.Forms.ComboBox();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.contextMenuTr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_donvidt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.contextMenuTr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở";
            // 
            // cb_coso
            // 
            this.cb_coso.FormattingEnabled = true;
            this.cb_coso.Location = new System.Drawing.Point(136, 24);
            this.cb_coso.Name = "cb_coso";
            this.cb_coso.Size = new System.Drawing.Size(266, 21);
            this.cb_coso.TabIndex = 1;
            this.cb_coso.SelectedIndexChanged += new System.EventHandler(this.cb_coso_SelectedIndexChanged);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.HoTen,
            this.MaGV});
            this.dataGV.Location = new System.Drawing.Point(12, 95);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(418, 144);
            this.dataGV.TabIndex = 2;
            this.dataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellContentClick);
            this.dataGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGV_CellMouseUp);
            this.dataGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGV_MouseClick);
            // 
            // contextMenuTr
            // 
            this.contextMenuTr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem,
            this.xóaGiáoViênToolStripMenuItem});
            this.contextMenuTr.Name = "contextMenuStrip1";
            this.contextMenuTr.Size = new System.Drawing.Size(264, 70);
            // 
            // hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem
            // 
            this.hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem.Name = "hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem";
            this.hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem.Text = "Hiện thông tin chi tiết của giáo viên";
            this.hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem_Click);
            // 
            // xóaGiáoViênToolStripMenuItem
            // 
            this.xóaGiáoViênToolStripMenuItem.Name = "xóaGiáoViênToolStripMenuItem";
            this.xóaGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.xóaGiáoViênToolStripMenuItem.Text = "Xóa giáo viên";
            this.xóaGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.xóaGiáoViênToolStripMenuItem_Click);
            // 
            // cb_donvidt
            // 
            this.cb_donvidt.FormattingEnabled = true;
            this.cb_donvidt.Location = new System.Drawing.Point(136, 51);
            this.cb_donvidt.Name = "cb_donvidt";
            this.cb_donvidt.Size = new System.Drawing.Size(266, 21);
            this.cb_donvidt.TabIndex = 5;
            this.cb_donvidt.SelectedIndexChanged += new System.EventHandler(this.cb_donvidt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đơn vị đào tạo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Và Tên Giáo Viên";
            this.HoTen.MinimumWidth = 100;
            this.HoTen.Name = "HoTen";
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_donvidt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.cb_coso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.contextMenuTr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_coso;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.ContextMenuStrip contextMenuTr;
        private System.Windows.Forms.ToolStripMenuItem hiệnThôngTinChiTiếtCủaGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb_donvidt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
    }
}

