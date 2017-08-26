using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoiceTagMatcher
{
    class AudioTag
    {
        private string tag;
        private int start, end;
        private double confidence;

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        public int Start
        {
            get { return start; }
            set { start = value; }
        }

        public int End
        {
            get { return end; }
            set { end = value; }
        }

        public double Confidence
        {
            get { return confidence; }
            set { confidence = value; }
        }

        public override string ToString()
        {
            return tag;
        }
    }
}
