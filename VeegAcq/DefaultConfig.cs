using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeegStation
{
    class DefaultConfig
    {
        //现在从系统配置文件中加载
        //private static string _CameraIP = "192.168.137.103";
        private static string[] _PlayerOptions = { ":network-caching=300", ":clock-synchro=0" };
        private static string _EegDataPath = @"D:\EEG\EEGDATA";
        private static string _VideoBasePath = @"D:\VEEG";

        //public static string CameraIP { get { return _CameraIP; } }
        public static string[] PlayerOptions { get { return _PlayerOptions; } }
        public static string EegDataPath { get { return _EegDataPath; } }
        public static string VideoSegmentPath { get { return _VideoBasePath + @"\VSEG"; } }
        public static string AssociatedVideoPath { get { return _VideoBasePath + @"\VSOC"; } }
    }
}
