using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace VeegStation
{
    public class PationInfo : PatInfo
    {
        DataFunc datafunc = new DataFunc();

        public PationInfo(string NatFileFullName, int patoff)
        {
            FileInfo fi = new FileInfo(NatFileFullName);
            string natFileName = NatFileFullName.Substring(0, NatFileFullName.Length - fi.Extension.Length) + ".NAT";

            FileStream natFile = new FileStream(natFileName, FileMode.Open);

            //get pation infomation

            natFile.Seek(patoff, SeekOrigin.Begin);
            byte[] patsectionbuf = datafunc.DataReadFun(natFile, 6);
            string patsection = new string(Encoding.ASCII.GetChars(patsectionbuf));
            string _patsection = patsection.Trim('\0');

            if (_patsection == "[PAT]")
            {
                natFile.Seek(6, SeekOrigin.Current);

                string pationName = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.Name = pationName.Trim('\0');

                string patgender = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 4));
                this.Gender = patgender.Trim('\0');

                string patid = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.ID = patid.Trim('\0');

                byte[] patagebuf = datafunc.DataReadFun(natFile, 7);
                string patage = new string(Encoding.ASCII.GetChars(patagebuf));
                this.Age = patage.Trim('\0');

                string pathandedness = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.Handedness = pathandedness.Trim('\0');

                string patstate = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.State = patstate.Trim('\0');

                string patresidentdoctor = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.ResidentDoctor = patresidentdoctor.Trim('\0');

                string pattype = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.Type = pattype.Trim('\0');

                natFile.Seek(13, SeekOrigin.Current);

                string patmengzhen = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.MengZhen = patmengzhen.Trim('\0');

                string patzhuyuan = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.ZhuYuan = patzhuyuan.Trim('\0');

                string patoperatedoctor = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.OperateDoctor = patoperatedoctor.Trim('\0');

                natFile.Seek(3, SeekOrigin.Current);

                string patdiagnosis = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 100));
                this.Diagnosis = patdiagnosis.Trim('\0').Replace("\0","");

                //pation history can not be parsed

                natFile.Seek(14, SeekOrigin.Current);

                string patmedicine = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 40));
                this.Medicine = patmedicine.Trim('\0');

                string patarchives = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 9));
                this.Archives = patarchives.Trim('\0');

                string patnote = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 80));
                this.Note = patnote.Trim('\0');

                string patbingqu = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 30));
                this.BingQu = patbingqu.Trim('\0');

                string patchuanghao = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.ChuangHao = patchuanghao.Trim('\0');

                string patkeshi = Encoding.GetEncoding(936).GetString(datafunc.DataReadFun(natFile, 20));
                this.KeShi = patkeshi.Trim('\0');

                this.FilePath = natFileName;
            }
        }
    }
}
