using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace VeegStation
{
      public class DataFunc
    {
        public byte[] DataReadFun(FileStream natFile, int length)
        {
            byte[] dateDatabuf = new byte[length];
            natFile.Read(dateDatabuf, 0, length);
            return dateDatabuf;
        }

        public void HighToLow(ref byte[] bytes2invert)
        {
            byte temp;
            for (int i = 0; i < bytes2invert.Length / 2; i++)
            {
                temp = bytes2invert[i];
                bytes2invert[i] = bytes2invert[bytes2invert.Length - i - 1];
                bytes2invert[bytes2invert.Length - i - 1] = temp;
            }
        }

        public string ByteArrToHexString(byte[] bytes)
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }

    }
}
