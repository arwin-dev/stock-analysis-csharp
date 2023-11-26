﻿using Stonks.Models;
using System.Collections.Generic;

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
    class bullishRecognizer : Recognizer
    {
        public bullishRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isBullish;
        }
    }

    class bearishRecognizer : Recognizer
    {
        public bearishRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isBearish;
        }
    }

    class neutralRecognizer : Recognizer
    {
        public neutralRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isNeutral;
        }
    }

    class marubozuRecognizer : Recognizer
    {
        public marubozuRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isMarubozu;
        }
    }

    class dragonflyDojiRecognizer : Recognizer
    {
        public dragonflyDojiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isDragonFlyDoji;
        }
    }

    class gravestoneDojiRecognizer : Recognizer
    {
        public gravestoneDojiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isGravestoneDoji;
        }
    }

    class invertedHammerRecognizer : Recognizer
    {
        public invertedHammerRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isInvertedHammer;
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

    class valleyRecognizer : Recognizer
    {
        public valleyRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizePattern(List<smartCandlestick> sc)
        {
            if (sc.Count == 3)
            {
                smartCandlestick sc1 = sc[0];
                smartCandlestick sc2 = sc[1];
                smartCandlestick sc3 = sc[2];

                return (sc2.low < sc1.low) && (sc2.low < sc3.low);
            }

            return false;
        }
    }

    class bullishEngulfingRecognizer : Recognizer
    {
        public bullishEngulfingRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizePattern(List<smartCandlestick> sc)
        {
            if (sc.Count == patternSize)
            {
                smartCandlestick sc1 = sc[0];
                smartCandlestick sc2 = sc[1];

                return (sc2.close > sc2.open) && (sc1.close < sc1.open) && (sc2.close > sc1.open) && (sc2.open < sc1.close);
            }

            return false;
        }
    }

    class bearishEngulfingRecognizer : Recognizer
    {
        public bearishEngulfingRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizePattern(List<smartCandlestick> sc)
        {
            if (sc.Count == patternSize)
            {
                smartCandlestick sc1 = sc[0];
                smartCandlestick sc2 = sc[1];

                return (sc2.close < sc2.open) && (sc1.close > sc1.open) && (sc2.close < sc1.open) && (sc2.open > sc1.close);
            }

            return false;
        }
    }

    class bullishHaramiRecognizer : Recognizer
    {
        public bullishHaramiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizePattern(List<smartCandlestick> sc)
        {
            if (sc.Count == patternSize)
            {
                smartCandlestick sc1 = sc[0];
                smartCandlestick sc2 = sc[1];

                return (sc2.close > sc2.open) && (sc2.open > sc1.close) && (sc2.close < sc1.open) && (sc1.close > sc2.open);
            }

            return false;
        }
    }

    class bearishHaramiRecognizer : Recognizer
    {
        public bearishHaramiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizePattern(List<smartCandlestick> sc)
        {
            if (sc.Count == patternSize)
            {
                smartCandlestick sc1 = sc[0];
                smartCandlestick sc2 = sc[1];

                return (sc2.close < sc2.open) && (sc2.open < sc1.close) && (sc2.close > sc1.open) && (sc1.close < sc2.open);
            }

            return false;
        }
    }


}
