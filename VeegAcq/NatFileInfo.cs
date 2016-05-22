using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace VeegStation
{
    public class NatFileInfo : NatInfo
    {

        DataFunc datafunc = new DataFunc();

        public NatFileInfo(string NatFileFullName)
        {
            FileInfo fi = new FileInfo(NatFileFullName);
            string natFileName = NatFileFullName.Substring(0, NatFileFullName.Length - fi.Extension.Length) + ".NAT";

            FileStream natFile = new FileStream(natFileName, FileMode.Open);

            byte[] sighdatabuf = datafunc.DataReadFun(natFile, 2);
            string sighdata = new string(Encoding.ASCII.GetChars(sighdatabuf));
            this.Sign = sighdata;

            byte[] versiondatabuf = datafunc.DataReadFun(natFile, 2);
            string strversiondata = datafunc.ByteArrToHexString(versiondatabuf);
            this.Version = strversiondata;

            int day = Convert.ToInt32(datafunc.ByteArrToHexString(datafunc.DataReadFun(natFile, 1)), 16);
            int mouth = Convert.ToInt32(datafunc.ByteArrToHexString(datafunc.DataReadFun(natFile, 1)), 16);
            byte[] dateyearbuf = datafunc.DataReadFun(natFile, 2);
            datafunc.HighToLow(ref dateyearbuf);
            int year = Convert.ToInt32(datafunc.ByteArrToHexString(dateyearbuf), 16);

            byte[] frequcebuf = datafunc.DataReadFun(natFile, 2);
            datafunc.HighToLow(ref  frequcebuf);
            this.Freq = Convert.ToInt32(datafunc.ByteArrToHexString(frequcebuf), 16);
            this.BrainNumber = Convert.ToByte(datafunc.ByteArrToHexString(datafunc.DataReadFun(natFile, 1)), 16);

            this.HeartNumber = Convert.ToByte(datafunc.ByteArrToHexString(datafunc.DataReadFun(natFile, 1)), 16);

            this.EegType = Encoding.ASCII.GetChars(datafunc.DataReadFun(natFile, 1))[0];

            natFile.Seek(3, SeekOrigin.Current);

            byte[] patoffbuf = datafunc.DataReadFun(natFile, 4);
            datafunc.HighToLow(ref patoffbuf);
            this.PatOff = Convert.ToInt32(datafunc.ByteArrToHexString(patoffbuf), 16);

            byte[] entoffbuf = datafunc.DataReadFun(natFile, 4);
            datafunc.HighToLow(ref entoffbuf);
            this.EntOff = Convert.ToInt32(datafunc.ByteArrToHexString(entoffbuf), 16);

            byte[] monoffbuf = datafunc.DataReadFun(natFile, 4);
            datafunc.HighToLow(ref monoffbuf);
            this.MonOff = Convert.ToInt32(datafunc.ByteArrToHexString(monoffbuf), 16);

            byte[] cfgoffbuf = datafunc.DataReadFun(natFile, 4);
            datafunc.HighToLow(ref cfgoffbuf);
            this.CfgOff = Convert.ToInt32(datafunc.ByteArrToHexString(cfgoffbuf), 16);

            byte[] dataoffbuf = datafunc.DataReadFun(natFile, 4);
            datafunc.HighToLow(ref dataoffbuf);
            this.DatOff = Convert.ToInt32(datafunc.ByteArrToHexString(dataoffbuf), 16);

            this.RespNumber = Convert.ToByte(datafunc.ByteArrToHexString(datafunc.DataReadFun(natFile, 1)), 16);

            this.FlashNumber = Convert.ToByte(datafunc.ByteArrToHexString(datafunc.DataReadFun(natFile, 1)), 16);

            this.Operate = Convert.ToByte(datafunc.ByteArrToHexString(datafunc.DataReadFun(natFile, 1)), 16);

            natFile.Seek(1, SeekOrigin.Current);

            byte[] flgbuf = datafunc.DataReadFun(natFile, 4);
            datafunc.HighToLow(ref flgbuf);
            string flgdata = datafunc.ByteArrToHexString(flgbuf);
            this.Flag = flgdata;

            byte[] vidioflgbuf = datafunc.DataReadFun(natFile, 4);
            datafunc.HighToLow(ref vidioflgbuf);
            int flg = Convert.ToInt32(datafunc.ByteArrToHexString(vidioflgbuf), 16);
            if (flg == 0)
                this.bIsHaveVideo = true;
            else
                this.bIsHaveVideo = false;

            byte[] nrowsofdatabuf = datafunc.DataReadFun(natFile, 4);
            datafunc.HighToLow(ref nrowsofdatabuf);
            this.nRowsOfData = Convert.ToInt32(datafunc.ByteArrToHexString(nrowsofdatabuf), 16);

            this.byteConfigType = Convert.ToByte(datafunc.ByteArrToHexString(datafunc.DataReadFun(natFile, 1)), 16);

            this.Remain = datafunc.DataReadFun(natFile, 88);

            natFile.Close();
            natFile.Dispose();
        }
    }
}
