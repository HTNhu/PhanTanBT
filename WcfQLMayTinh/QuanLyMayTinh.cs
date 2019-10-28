using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DALQLMayTinh;
using EntitiesQLMayTinh;

namespace WcfQLMayTinh
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QuanLyDB" in both code and config file together.
    public class QuanLyMayTinh : IQuanLyMayTinh
    {
        QLMayTinhDataContext db;
        public QuanLyMayTinh()
        {
            db = new QLMayTinhDataContext();
        }
        
        public List<ePhongHoc> getAllPhongHoc()
        {
            IEnumerable<tblPhonghoc> phonghoclist1 = db.tblPhonghocs;
            // var  phonghoclist = db.tblPhonghocs.ToList();//??
            List<ePhongHoc> ls = new List<ePhongHoc>();
            foreach (tblPhonghoc ph in phonghoclist1)
            {
                ePhongHoc p = new ePhongHoc();
                p.MsPhong = ph.msPhong;
                p.TenPhong = ph.tenPhong;
                p.ToaNha = ph.toaNha;
                p.TangLau = (int)ph.tangLau;
                ls.Add(p);
            }
            return ls;
        }
        public bool CheckIfExist(string maMay)
        {
            tblMaytinh mttemp = db.tblMaytinhs.Where(x => x.msMay == maMay).FirstOrDefault();
            if (mttemp != null)
                return true;
            return false;
        }

        public int insertMayTinh(eMayTinh mtmoi)
        {
            // if (CheckIfExist(mtmoi.MaMay)==true)
            if (CheckIfExist(mtmoi.MaMay))
                return 0;

            tblMaytinh mttemp = new tblMaytinh();
            mttemp.msMay = mtmoi.MaMay;
            mttemp.RAM = mtmoi.RAM;
            mttemp.Monitor = mtmoi.Monitor;
            mttemp.VGA = mtmoi.VGA;
            mttemp.HardDisk = mtmoi.HardDisk;
            mttemp.CPU = mtmoi.CPU;
            mttemp.msPhong = mtmoi.MsPhong;

            db.tblMaytinhs.InsertOnSubmit(mttemp);
            db.SubmitChanges();
            return 1;
        }
        public List<eMayTinh> getMayTinhThuocPhong(string maphonghoc)
        {
            var dsmaytinh = db.tblMaytinhs.Where
                (x => x.msPhong == maphonghoc).ToList().OrderBy(x => x.CPU);


            var dsmaytinh1 = (from x in db.tblMaytinhs
                              where x.msPhong == maphonghoc
                              orderby x.CPU descending
                              select x).ToList();


            List<eMayTinh> ls = new List<eMayTinh>();
            foreach (tblMaytinh mttemp in dsmaytinh)
            {
                eMayTinh mt = new eMayTinh();
                mt.MaMay = mttemp.msMay;
                mt.CPU = mttemp.CPU;
                mt.HardDisk = mttemp.HardDisk;
                mt.RAM = mttemp.RAM;
                mt.Monitor = mttemp.Monitor;
                mt.VGA = mttemp.VGA;
                mt.MsPhong = mttemp.msPhong;
                ls.Add(mt);
            }
            return ls;

        }
    }
}
