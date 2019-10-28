using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EntitiesQLMayTinh;
namespace WcfQLMayTinh
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuanLyDB" in both code and config file together.
    [ServiceContract]
    public interface IQuanLyMayTinh
    {
        [OperationContract]
        List<ePhongHoc> getAllPhongHoc();
        [OperationContract]
        List<eMayTinh> getMayTinhThuocPhong(string maphonghoc);

        [OperationContract]
        bool CheckIfExist(string maMay);
        [OperationContract]
        int insertMayTinh(eMayTinh mtmoi);




    }
}
