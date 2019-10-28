using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace EntitiesQLMayTinh
{
    [DataContract]
    public class ePhongHoc
    {
        private string msPhong, tenPhong, toaNha;
        private int tangLau;

        public ePhongHoc()
        {
            this.MsPhong = "";
            this.TenPhong = "";
            this.ToaNha = "";
            this.TangLau = 0;
        }
        public ePhongHoc(string ms, string t, string tn, int tl)
        {
            this.MsPhong = ms;
            this.TenPhong = t;
            this.ToaNha = tn;
            this.TangLau = tl;
        }
        [DataMember]
        public string MsPhong
        {
            get
            {
                return msPhong;
            }

            set
            {
                msPhong = value;
            }
        }
        [DataMember]
        public int TangLau
        {
            get
            {
                return tangLau;
            }

            set
            {
                tangLau = value;
            }
        }
        [DataMember]
        public string TenPhong
        {
            get
            {
                return tenPhong;
            }

            set
            {
                tenPhong = value;
            }
        }
        [DataMember]
        public string ToaNha
        {
            get
            {
                return toaNha;
            }

            set
            {
                toaNha = value;
            }
        }
    }    
}
