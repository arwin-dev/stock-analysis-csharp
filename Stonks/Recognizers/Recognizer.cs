using Stonks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks.Recognizers
{
    abstract class Recognizer
    {
        public int patternSize;
        public string patternName;
        public Recognizer(int patternSize, string patternName)
        {
            this.patternSize = patternSize;

            this.patternName = patternName;
        }
        public List<smartCandlestick> Recognize(List<smartCandlestick> smartCandlesticks)
        {
            List<smartCandlestick> smartCandlesticksTemp = new List<smartCandlestick>();
            foreach (smartCandlestick cs in smartCandlesticks)
            {
                if(recognizePattern(cs)) 
                {
                    smartCandlesticksTemp.Add(cs);
                }
            }
            return smartCandlesticksTemp;
        }

        public virtual bool recognizePattern(smartCandlestick sc)
        {
            return false;
        }

        public virtual bool recognizePattern(List<smartCandlestick> sc)
        {
            return false;
        }
    }

    class dojiRecognizer : Recognizer
    {
        public dojiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {
            
        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isDoji;
        }
    }

    class hammerRecognizer : Recognizer
    {
        public hammerRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {
            
        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isHammer;
        }
    }

    class peakRecognizer : Recognizer
    {
        public peakRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {
            
        }

        public override bool recognizePattern(List<smartCandlestick> sc)
        {
            if (sc.Count == 3) 
            {
                smartCandlestick sc1 = sc[0];
                smartCandlestick sc2 = sc[1];
                smartCandlestick sc3 = sc[2];

                return (sc2.high > sc1.high) && (sc2.high > sc3.high);
            }

            return false;
        }
    }
}
