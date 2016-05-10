using System;
using System.Collections.Generic;
using System.Text;

namespace BingoLib
{
    public class BingoGame
    {
        private long _sessionID;
        private long _gameID;
        private float _denom;

        public long SessionID
        {
            get { return _sessionID; }
        }
        public long GameID
        {
            get { return _gameID; }
        }
        public float Denomination
        {
            get { return _denom; }
            set { _denom = value; }
        }

    }
}
