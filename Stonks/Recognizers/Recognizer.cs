using Stonks.Models;
using System.Collections.Generic;

namespace Stonks.Recognizers
{
    /// <summary>
    /// Abstract class representing a generic pattern recognizer
    /// </summary>
    abstract class Recognizer
    {
        public int patternSize;
        public string patternName;
        public Recognizer(int patternSize, string patternName)
        {
            this.patternSize = patternSize;

            this.patternName = patternName;
        }

        /// <summary>
        /// Virtual method to be implemented by derived classes for pattern recognition of a list of smartCandlesticks
        /// </summary>
        /// <param name="sc">A smartCandlestick</param>
        /// <returns></returns>
        public virtual bool recognizePattern(smartCandlestick sc)
        {
            return false;
        }

        /// <summary>
        /// Virtual method to be implemented by derived classes for pattern recognition of a list of smartCandlesticks
        /// </summary>
        /// <param name="sc">A list of smartCandlesticks</param>
        /// <returns></returns>
        public virtual bool recognizePattern(List<smartCandlestick> sc)
        {
            return false;
        }
    }

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Doji candlesticks
    /// </summary>
    class dojiRecognizer : Recognizer
    {
        public dojiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {
            
        }

        // Override of the recognizePattern method for a single smartCandlestick
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isDoji;
        }
    }

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Hammer candlesticks
    /// </summary>
    class hammerRecognizer : Recognizer
    {
        public hammerRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {
            
        }

        // Override of the recognizePattern method for a single smartCandlestick
        public override bool recognizePattern(smartCandlestick cs)
        {
            return cs.isHammer;
        }
    }

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting bullish candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting bearish candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting neutral candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting marubozu candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Dragonfly Doji candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Gravestone Doji candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Inverted Hammer candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting peak candlesticks
    /// </summary>
    class peakRecognizer : Recognizer
    {
        public peakRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {
            
        }

        // Override of the recognizePattern method for multi smartCandlestick
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting valley candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Bullish Engulfing candlesticks
    /// </summary>
    class bullishEngulfingRecognizer : Recognizer
    {
        public bullishEngulfingRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        // Override of the recognizePattern method for multi smartCandlestick
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Bearish Engulfing candlesticks
    /// </summary>
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

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Bullish Harami candlesticks
    /// </summary>
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

                return ((sc2.close > sc2.open) && (sc1.close < sc1.open) && (sc2.close < sc1.open) && (sc2.open > sc1.close));
            }

            return false;
        }
    }

    /// <summary>
    /// Class representing a specific pattern recognizer for detecting Bearish Harami candlesticks
    /// </summary>
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

                return ((sc2.close < sc2.open) && (sc1.close > sc1.open) && (sc2.close > sc1.open) && (sc2.open < sc1.close));
            }

            return false;
        }
    }


}
