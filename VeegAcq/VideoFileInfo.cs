using Shell32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Shell32;
using System.Text.RegularExpressions;

namespace VeegStation
{
    public class VideoFileInfo
    {
        private DateTime _StartTime;
        private TimeSpan _Duration;
        private readonly string _FileFullName;

        public DateTime StartTime { get { return _StartTime; } }
        public TimeSpan Duration { get { return _Duration; } }
        public string FileFullName { get { return _FileFullName; } }

        /// <summary>
        /// 获取媒体文件播放时长/// 
        /// </summary>
        /// <param name="path">媒体文件路径</param>
        /// <returns></returns>
        public TimeSpan GetMediaTimeLen(string path) 
        {         
                Shell32.Shell shell = new Shell32.ShellClass( );        
                //文件路径        
                Shell32.Folder folder = shell.NameSpace(path.Substring(0, path.LastIndexOf("\\")));        
                //文件名称        
                Shell32.FolderItem folderitem = folder.ParseName(path.Substring(path.LastIndexOf("\\") + 1));
                string _duration = Regex.Match(folder.GetDetailsOf(folderitem, -1), "\\d:\\d{2}:\\d{2}").Value;            
                string[] sp = _duration.Split(new char[] { ':' });
                TimeSpan ts = new TimeSpan(int.Parse(sp[0]), int.Parse(sp[1]), int.Parse(sp[2]));
                return ts;  
      }
  
        public VideoFileInfo(string FileFullName)
        {
            _FileFullName = FileFullName;

            FileInfo fi = new FileInfo(_FileFullName);
           
            string baseFileName = fi.Name;
            if (baseFileName.Length == 18) // YYYYMMDDHHmmSS.MP4
            {
                try
                {
                    DateTime dt = DateTime.Parse(baseFileName.Substring(0, 4)
                        + "-" + baseFileName.Substring(4, 2)
                        + "-" + baseFileName.Substring(6, 2)
                        + "T" + baseFileName.Substring(8, 2)
                        + ":" + baseFileName.Substring(10, 2)
                        + ":" + baseFileName.Substring(12, 2)
                        );
                    _StartTime = dt;
                    _Duration = GetMediaTimeLen(_FileFullName);
                }
                catch { }
            }
        }
    }
}
