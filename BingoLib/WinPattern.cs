using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BingoLib
{
    [Serializable]
    public class WinPattern : CardPattern
    {
        public WinPattern()
        {
            this.init(new CardPattern());
        }
        public WinPattern(int[,] pattern)
        {
            this.init(new CardPattern(pattern));
        }
        public WinPattern(CardPattern pattern)
        {
            this.init(pattern);
        }
        private void init(CardPattern pattern)
        {
            base.RawGrid = pattern.RawGrid;
        }

        public CardPattern GetMask()
        {
            return (CardPattern)this;
        }
    }
}
