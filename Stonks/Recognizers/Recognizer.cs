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
        public override bool recognizePattern(List<smartCandlestick> smartCandlesticks)
        {
            if(patternSize == 3)
            {
                return true;
            }
            return false;
        }
    }

    class hammerRecognizer : Recognizer
    {
        public hammerRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {
            
        }
        public override bool recognizePattern(List<smartCandlestick> smartCandlesticks)
        {
            return smartCandlesticks[0].isHammer;
        }
    }
}
