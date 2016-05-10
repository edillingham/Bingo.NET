using System;
using System.Collections.Generic;
using System.Collections;

namespace BingoLib
{
 
    public enum CardColumns
    {
        B = 0,
        I = 1,
        N = 2,
        G = 3,
        O = 4
    }

    public class BingoCard : IBingoCard
    {
        public static int RowCount = 5;
        public static int ColumnCount = 5;

        private const int X_CENTER = 2;
        private const int Y_CENTER = 2;
        private const int ARRAY_DIMENSION_ROW = 0;
        private const int ARRAY_DIMENSION_COLUMN = 1;

        private long _sessionID;
        private CardPattern grid;
        private CardPattern daub;

        public BingoCard(long sessionID)
        {
            grid = this.GetBlankCard();
            daub = this.GetBlankCard();

            daub[X_CENTER, Y_CENTER] = 1;

            _sessionID = sessionID;
        }

        public CardPattern GetBlankCard()
        {
            return new CardPattern(BingoCard.getBlankGrid());
        }

        internal static int[,] getBlankGrid()
        {
            int[,] blank = {
                        {0,0,0,0,0},
                        {0,0,0,0,0},
                        {0,0,-1,0,0},
                        {0,0,0,0,0},
                        {0,0,0,0,0}
                    };
            return blank;
        }

        public CardPattern Cells
        {
            get { return grid; }
            internal set
            {
                grid = value;
            }
        }

        public long SessionID
        {
            get { return _sessionID; }
        }

        public CardPattern GetGrid()
        {
            return grid;
        }

        public CardPattern GetMask()
        {
            return daub;
        }

        public void Daub(int x, int y)
        {
            daub[x, y] = 1;
        }

        public bool Contains(int ballNum)
        {
            bool foundIt = false;

            for (int x = 0; x < RowCount; x++)
            {
                for (int y = 0; y < ColumnCount; y++)
                {
                    if (!(x == X_CENTER && y == Y_CENTER))
                    {
                        // draw a cell
                        if (!foundIt)
                        {
                            if (grid[x, y] == ballNum)
                                foundIt = true;
                        }
                    }
                }
            }
            return foundIt;
        }

    }

    public class BingoCardCollection : IList
    {
        private List<BingoCard> cards = new List<BingoCard>();
        
        public void Daub(int ballNum)
        {

        }

#region IList Members
        public int Add(object card)
        {
            this.cards.Add((BingoCard)card);
            return this.cards.Count - 1;
        }
        public void Clear()
        {
            this.cards.Clear();
        }
        public bool Contains(object card)
        {
            return this.cards.Contains((BingoCard)card);
        }
        public int IndexOf(object card)
        {
            return cards.IndexOf((BingoCard)card);
        }
        public void Insert(int index, object card)
        {
            this.cards.Insert(index, (BingoCard)card);
        }
        public bool IsFixedSize
        {
            get { return false; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public void Remove(object card)
        {
            this.cards.Remove((BingoCard)card);
            this.cards.TrimExcess();
        }
        public void RemoveAt(int index)
        {
            this.cards.RemoveAt(index);
            this.cards.TrimExcess();
        }
        public object this[int index]
        {
            get
            {
                return (object)this.cards[index];
            }
            set
            {
                this.cards[index] = (BingoCard)value;
            }
        }
#endregion

#region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return this.cards.GetEnumerator();
        }

#endregion

#region ICollection Members
        public int Count
        {
            get { return this.cards.Count; }
        }

        public void CopyTo(Array array, int index)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        public bool IsSynchronized
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }
        public object SyncRoot
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }
#endregion
    }
	

}
