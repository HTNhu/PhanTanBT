namespace PresentationGUIMayTinh
{
    partial class frmMayTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMayTinh));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.trePhong = new System.Windows.Forms.TreeView();
            this.imgTre = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwDSMay = new System.Windows.Forms.ListView();
            this.dgvMT = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhong = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsMay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgHinhLon = new System.Windows.Forms.ImageList(this.components);
            this.imgHinhNho = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripChoListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStripChoListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnThemPhong);
            this.splitContainer1.Panel1.Controls.Add(this.trePhong);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(852, 559);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(19, 476);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(242, 43);
            this.btnThemPhong.TabIndex = 6;
            this.btnThemPhong.Text = "Thêm Phòng học";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // trePhong
            // 
            this.trePhong.ImageIndex = 0;
            this.trePhong.ImageList = this.imgTre;
            this.trePhong.Location = new System.Drawing.Point(11, 11);
            this.trePhong.Margin = new System.Windows.Forms.Padding(4);
            this.trePhong.Name = "trePhong";
            this.trePhong.SelectedImageIndex = 0;
            this.trePhong.Size = new System.Drawing.Size(242, 430);
            this.trePhong.TabIndex = 5;
            this.trePhong.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trePhong_AfterSelect);
            // 
            // imgTre
            // 
            this.imgTre.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTre.ImageStream")));
            this.imgTre.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTre.Images.SetKeyName(0, "REFBARH.ICO");
            this.imgTre.Images.SetKeyName(1, "caycanh.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwDSMay);
            this.splitContainer2.Panel1.Controls.Add(this.dgvMT);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(564, 559);
            this.splitContainer2.SplitterDistance = 240;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvwDSMay
            // 
            this.lvwDSMay.Location = new System.Drawing.Point(10, 100);
            this.lvwDSMay.Name = "lvwDSMay";
            this.lvwDSMay.Size = new System.Drawing.Size(540, 133);
            this.lvwDSMay.TabIndex = 1;
            this.lvwDSMay.UseCompatibleStateImageBehavior = false;
            this.lvwDSMay.SelectedIndexChanged += new System.EventHandler(this.lvwDSMay_SelectedIndexChanged);
            // 
            // dgvMT
            // 
            this.dgvMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMT.Location = new System.Drawing.Point(0, 0);
            this.dgvMT.Name = "dgvMT";
            this.dgvMT.Size = new System.Drawing.Size(560, 92);
            this.dgvMT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhong);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMonitor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtVGA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRam);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHard);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCPU);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMsMay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 311);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtPhong
            // 
            this.txtPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhong.Location = new System.Drawing.Point(133, 227);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(424, 29);
            this.txtPhong.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(480, 274);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 34);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(369, 274);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 34);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(261, 274);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 34);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(154, 274);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 34);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu Mới";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 274);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phòng:";
            // 
            // txtMonitor
            // 
            this.txtMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonitor.Location = new System.Drawing.Point(131, 190);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(426, 26);
            this.txtMonitor.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monitor:";
            // 
            // txtVGA
            // 
            this.txtVGA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVGA.Location = new System.Drawing.Point(131, 157);
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.Size = new System.Drawing.Size(426, 26);
            this.txtVGA.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "VGA:";
            // 
            // txtRam
            // 
            this.txtRam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRam.Location = new System.Drawing.Point(131, 124);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(426, 26);
            this.txtRam.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "RAM:";
            // 
            // txtHard
            // 
            this.txtHard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHard.Location = new System.Drawing.Point(131, 91);
            this.txtHard.Name = "txtHard";
            this.txtHard.Size = new System.Drawing.Size(426, 26);
            this.txtHard.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Harddisk:";
            // 
            // txtCPU
            // 
            this.txtCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPU.Location = new System.Drawing.Point(131, 58);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(426, 26);
            this.txtCPU.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU:";
            // 
            // txtMsMay
            // 
            this.txtMsMay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsMay.Location = new System.Drawing.Point(131, 25);
            this.txtMsMay.Name = "txtMsMay";
            this.txtMsMay.Size = new System.Drawing.Size(426, 26);
            this.txtMsMay.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã số máy:";
            // 
            // imgHinhLon
            // 
            this.imgHinhLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHinhLon.ImageStream")));
            this.imgHinhLon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHinhLon.Images.SetKeyName(0, "cacanh.png");
            // 
            // imgHinhNho
            // 
            this.imgHinhNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHinhNho.ImageStream")));
            this.imgHinhNho.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHinhNho.Images.SetKeyName(0, "cacanh.png");
            // 
            // contextMenuStripChoListView
            // 
            this.contextMenuStripChoListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.smalToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailToolStripMenuItem});
            this.contextMenuStripChoListView.Name = "contextMenuStripChoListView";
            this.contextMenuStripChoListView.Size = new System.Drawing.Size(104, 114);
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.titleToolStripMenuItem.Text = "Title";
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // smalToolStripMenuItem
            // 
            this.smalToolStripMenuItem.Name = "smalToolStripMenuItem";
            this.smalToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.smalToolStripMenuItem.Text = "smal";
            this.smalToolStripMenuItem.Click += new System.EventHandler(this.smalToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.listToolStripMenuItem.Text = "list";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.detailToolStripMenuItem.Text = "detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // frmMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 559);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMayTinh";
            this.Text = "Dung WCF";
            this.Load += new System.EventHandler(this.frmMayTinh_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStripChoListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.TreeView trePhong;
        private System.Windows.Forms.ImageList imgTre;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvMT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwDSMay;
        private System.Windows.Forms.ImageList imgHinhLon;
        private System.Windows.Forms.ImageList imgHinhNho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripChoListView;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
    }
}

