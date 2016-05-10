using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BingoLib
{
    [Serializable]
    public enum MatchedPattern
    {
        NoMatch = 0,
        LineBingo = 1,
        StampBingo = 2,
        FourCorners = 3,
        SixPack = 4,
        NinePack = 5
    }
}
