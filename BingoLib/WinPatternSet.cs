using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BingoLib
{
    [Serializable]
    public class WinPatternSet
    {
        [XmlEnum]
        private MatchedPattern _type = MatchedPattern.NoMatch;
        private List<WinPattern> _patterns = new List<WinPattern>();
        private int _mult = 0;

        public WinPatternSet()
        {
        }

        public WinPatternSet(MatchedPattern type)
        {
            _type = type;
        }

        [XmlAttribute()]
        public int Multiplier
        {
            get { return _mult; }
            set { _mult = value; }
        }

        [XmlAttribute()]
        public MatchedPattern PatternType
        {
            get { return _type; }
            set { _type = value; }
        }

        [XmlArray()]
        public WinPattern[] Patterns
        {
            get
            {
                return _patterns.ToArray();
            }
            set
            {
                _patterns.AddRange(value);
            }
        }

        public int PatternCount
        {
            get
            {
                return _patterns.Count;
            }
        }

        public void Add(WinPattern pattern)
        {
            _patterns.Add(pattern);
        }
    }
}
