using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationGUIMayTinh.DungQLMTVoiWCF;
namespace PresentationGUIMayTinh
{
    public partial class frmMayTinh : Form
    {
        QuanLyMayTinhClient qlMTinh;
       
        List<ePhongHoc> listPH; //Khai báo danh sách phòng học (TreeView)
        TreeNode nGoc;
        public frmMayTinh()
        {
            InitializeComponent();
            qlMTinh = new QuanLyMayTinhClient();
        }
        
        private void frmMayTinh_Load(object sender, EventArgs e)
        {
            nGoc = new TreeNode("Danh Sách các Phòng");
            trePhong.Nodes.Add(nGoc);
            listPH = qlMTinh.getAllPhongHoc().ToList();
            LoadDataPhongTreeView(trePhong, listPH);
            lvwDSMay.LargeImageList = imgHinhLon;
            lvwDSMay.SmallImageList = imgHinhNho;
            lvwDSMay.ContextMenuStrip = contextMenuStripChoListView;
            trePhong.ImageList = imgTre;
            trePhong.ImageIndex = 0;
            trePhong.SelectedImageIndex = 1;
            CreateColumn(lvwDSMay);
        }
        void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();// xoa het column
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã máy", 80);
            lvw.Columns.Add("CPU", 150);
            lvw.Columns.Add("Đĩa Cứng", 100);
            lvw.Columns.Add("Ram ", 80);
            lvw.Columns.Add("VGa", 80);
            lvw.Columns.Add("màn hình", 180);

        }
        public void LoadDataPhongTreeView(TreeView tre, List<ePhongHoc> l)
        {
            nGoc.Nodes.Clear();
            foreach (ePhongHoc ph in l)
            {
                TreeNode n = new TreeNode(ph.TenPhong);
                n.Tag = ph.MsPhong;//lưu mã phòng trong thuộc tính Tag của node, dùng để truy vấn ds Máy tính khi nhấn chuột vào Node
                nGoc.Nodes.Add(n);
                
            }
            tre.ExpandAll();
        }

        void LoadDSVaoListView(ListView lvw)
        {
            string strMaPhong = "";
            strMaPhong = (string)trePhong.SelectedNode.Tag;//
            IEnumerable<eMayTinh> dsMT = qlMTinh.getMayTinhThuocPhong(strMaPhong);

            {
                lvw.Items.Clear();
                foreach (eMayTinh mt in dsMT)
                {
                    ListViewItem lvwItem = new ListViewItem();
                    lvwItem.Text = mt.MaMay;
                    lvwItem.SubItems.Add(mt.CPU);
                    lvwItem.SubItems.Add(mt.HardDisk.ToString());
                    lvwItem.SubItems.Add(mt.RAM);
                    lvwItem.SubItems.Add(mt.VGA);
                    lvwItem.SubItems.Add(mt.Monitor);
                    lvwItem.ImageIndex = 0;//lấy hình đầu tiên trong tập img
                    lvwItem.Tag = mt;//phục vụ xóa
                    lvw.Items.Add(lvwItem);
                }
            }
        }
        private void trePhong_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //string strMaPhong = "";
            if (trePhong.SelectedNode != null)
            {
                if (trePhong.SelectedNode.Level == 1)
                {
                   
                   LoadDSVaoListView(lvwDSMay);
                }
            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDSMay.View = View.Details;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDSMay.View = View.LargeIcon;
        }

        private void smalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwDSMay.View = View.SmallIcon;
        }

        private void lvwDSMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSMay.SelectedItems.Count > 0)//co chon
            {
                eMayTinh mt = (eMayTinh)lvwDSMay.SelectedItems[0].Tag;
                txtMsMay.Text = mt.MaMay;
                txtCPU.Text = mt.CPU;
                txtHard.Text = mt.HardDisk;
                txtRam.Text = mt.RAM;
                txtVGA.Text = mt.VGA;
                txtMonitor.Text = mt.Monitor;
               
            }

        }

        eMayTinh TaoMoiMayTinh()
        {
            eMayTinh newmt = new eMayTinh();
            newmt.MaMay = txtMsMay.Text.Trim();
            newmt.CPU = txtCPU.Text;
            newmt.HardDisk = txtHard.Text;
            newmt.RAM = txtRam.Text;
            newmt.VGA = txtVGA.Text;
            newmt.Monitor = txtMonitor.Text;
            newmt.MsPhong = trePhong.SelectedNode.Tag.ToString();
            return newmt;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            eMayTinh newmt = TaoMoiMayTinh();
            int kq = qlMTinh.insertMayTinh(newmt);
            if (kq == 1)
                MessageBox.Show("Thêm thành công!!!");
            else
                MessageBox.Show("Lỗi trùng khóa, vui lòng kiểm tra lại!");
            //đưa lại datagridview
            LoadDSVaoListView(lvwDSMay);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
