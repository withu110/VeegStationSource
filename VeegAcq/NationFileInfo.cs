using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace VeegStation
{
    public class NationFileInfo
    {
        private string _SerialNo;
        private DateTime _StartTime;
        private string _Patient;
        private int _SampleCount;
        private int _SampleRate;
        private bool _HasVideo;
        private string _NedFullName;
        private string _VideoFullName;
        private double _VideoOffset;

        public string SerialNo { get { return _SerialNo; } }
        public DateTime StartTime { get { return _StartTime;} }
        public string Patient { get { return _Patient; } }
        public int SampleCount { get { return _SampleCount; } }
        public int SampleRate { get { return _SampleRate; } }
        public TimeSpan Duration { get { return Util.DurationToTimeSpan(_SampleCount * 1.0 / _SampleRate); } }
        public bool HasVideo { get { return _HasVideo; } }
        public string NedFullName { get { return _NedFullName; } }
        public string VideoFullName { get { return _VideoFullName; } }
        public double VideoOffset { get { return _VideoOffset; } }

        private string TrimZero(string Source)
        {
            int index = Source.IndexOf('\0');
            if (index < 0)
                return Source;
            return Source.Substring(0, index);
        }

        public NationFileInfo(string NedFileFullName)
        {
            _NedFullName = NedFileFullName;

            FileInfo fi = new FileInfo(NedFileFullName);
            string natFileName = NedFileFullName.Substring(0, NedFileFullName.Length - fi.Extension.Length) + ".NAT";
            string prrFileName = NedFileFullName.Substring(0, NedFileFullName.Length - fi.Extension.Length) + ".PRR";

            _SerialNo = fi.Name.Substring(1, fi.Name.Length - fi.Extension.Length - 1);

            FileStream nedFile = new FileStream(NedFileFullName, FileMode.Open);
            byte[] nedPartialHeader = new byte[64];
            nedFile.Read(nedPartialHeader, 0, 64);
            _SampleRate = nedPartialHeader[28] | (nedPartialHeader[29] << 8);
            _SampleCount = nedPartialHeader[36] | (nedPartialHeader[37] << 8) | (nedPartialHeader[38] << 16) | (nedPartialHeader[39] << 24);
            nedFile.Close();
            nedFile.Dispose();

            FileStream prrFile = new FileStream(prrFileName, FileMode.Open);
            byte[] prrHeaderBuf = new byte[24];
            prrFile.Read(prrHeaderBuf, 0, 24);
            string prrHeader = new string(Encoding.ASCII.GetChars(prrHeaderBuf));
            string t = prrHeader.Substring(5, 19);
            DateTime dt = DateTime.Parse(t);
            _StartTime = dt;
            Debug.WriteLine(dt);
            prrFile.Close();
            prrFile.Dispose();

            FileStream natFile = new FileStream(natFileName, FileMode.Open);
            natFile.Seek(0x90, SeekOrigin.Begin);
            while (true)
            {
                int ret;

                byte[] sectionNameBuf = new byte[8];
                ret = natFile.Read(sectionNameBuf, 0, 8);
                if (ret < 8)
                    break;
                string sectionName = new string(Encoding.ASCII.GetChars(sectionNameBuf));
                sectionName = TrimZero(sectionName);
                
                byte[] sectionSizeBuf = new byte[2];
                ret = natFile.Read(sectionSizeBuf, 0, 2);
                if (ret < 2)
                    break;

                int sectionBodySize = (sectionSizeBuf[0] | sectionSizeBuf[1] << 8) - 10;
                byte[] sectionBodyBuf = new byte[sectionBodySize];
                ret = natFile.Read(sectionBodyBuf, 0, sectionBodySize);
                if (ret < sectionBodySize)
                    break;
                Debug.WriteLine(string.Format("Section {0} size {1}", sectionName, sectionBodySize + 10));
                if (sectionName == "[PAT]")
                {
                    string patientName = Encoding.GetEncoding(936).GetString(sectionBodyBuf.Skip(2).Take(20).ToArray());
                    patientName = TrimZero(patientName);
                    _Patient = patientName;
                    Debug.WriteLine(string.Format("Patient {0}", patientName));
                }
            }
            natFile.Close();
            natFile.Dispose();

            DirectoryInfo diTop = new DirectoryInfo(DefaultConfig.AssociatedVideoPath);
            var files = diTop.EnumerateFiles("*.MP4");
            _HasVideo = false;
            foreach (var file in files)
            {
                if (file.Name.StartsWith(_SerialNo + "_"))
                {
                    _HasVideo = true;
                    _VideoFullName = file.FullName;
                    string offsetStr = file.Name.Substring(_SerialNo.Length + 1);
                    offsetStr = offsetStr.Substring(0, offsetStr.LastIndexOf('.'));
                    _VideoOffset = double.Parse(offsetStr) / 1000;
                    break;
                }
            }
        }
    }
}
