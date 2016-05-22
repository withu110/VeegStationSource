using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeegStation
{
    class EegPacket
    {
        private double _EKG;
        private double[] _EEG;

        public double EKG { get { return _EKG; } }
        public double[] EEG { get { return _EEG; } }
        public EegPacket(double EKG, double[] EEG)
        {
            _EKG = EKG;
            _EEG = EEG;
        }
    }
}
