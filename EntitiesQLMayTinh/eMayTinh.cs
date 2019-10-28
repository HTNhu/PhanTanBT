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
    public class eMayTinh
    {
        private string maMay, cPU, hardDisk, rAM, vGA, monitor, msPhong;
        [DataMember]
        public string CPU
        {
            get
            {
                return cPU;
            }

            set
            {
                cPU = value;
            }
        }
        [DataMember]
        public string HardDisk
        {
            get
            {
                return hardDisk;
            }

            set
            {
                hardDisk = value;
            }
        }
        [DataMember]
        public string MaMay
        {
            get
            {
                return maMay;
            }

            set
            {
                maMay = value;
            }
        }
        [DataMember]
        public string Monitor
        {
            get
            {
                return monitor;
            }

            set
            {
                monitor = value;
            }
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
        public string RAM
        {
            get
            {
                return rAM;
            }

            set
            {
                rAM = value;
            }
        }
        [DataMember]
        public string VGA
        {
            get
            {
                return vGA;
            }

            set
            {
                vGA = value;
            }
        }
        
        public eMayTinh()
        {
            this.maMay = "";
            this.cPU = "";
            this.hardDisk = "";
            this.rAM = "";
            this.vGA = "";
            this.monitor = "";
            this.msPhong = "";
        }
        public eMayTinh(string mm, string c, string h, string r, string v, string m, string msphong)
        {
            this.maMay = mm;
            this.cPU = c;
            this.hardDisk = h;
            this.rAM = r;
            this.vGA = v;
            this.monitor = m;
            this.msPhong = msphong;
        }

    }
}
