using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeegStation
{
    public class Util
    {
        public static TimeSpan DurationToTimeSpan(double Duration)
        {
            return new TimeSpan((long)(Duration * 10000000));
        }

        public static double RawToSignal(short Raw)
        {
            return Raw / 7.78125;
        }
    }

    public class NationFileInfoComparer : IComparer<NationFileInfo>
    {
        public int Compare(NationFileInfo x, NationFileInfo y)
        {
            return -Math.Sign((x.StartTime - y.StartTime).TotalSeconds);
        }
    }

    public class VideoFileInfoComparer : IComparer<VideoFileInfo>
    {
        public int Compare(VideoFileInfo x, VideoFileInfo y)
        {
            return -Math.Sign((x.StartTime - y.StartTime).TotalSeconds);
        }
    }
}
