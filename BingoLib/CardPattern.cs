using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BingoLib
{
    [Serializable]
    public class CardPattern
    {
        private int[,] grid = BingoCard.getBlankGrid();

        public CardPattern()
        {
        }
        public CardPattern(int[,] p)
        {
            grid = p;
        }

        [XmlAttribute]
        public int[] B
        {
            get
            {
                return getColumn(0);
            }
            set
            {
                setColumn(0, value);
            }
        }
        [XmlAttribute]
        public int[] I
        {
            get
            {
                return getColumn(1);
            }
            set
            {
                setColumn(1, value);
            }
        }
        [XmlAttribute]
        public int[] N
        {
            get
            {
                return getColumn(2);
            }
            set
            {
                setColumn(2, value);
            }
        }
        [XmlAttribute]
        public int[] G
        {
            get
            {
                return getColumn(3);
            }
            set
            {
                setColumn(3, value);
            }
        }
        [XmlAttribute]
        public int[] O
        {
            get
            {
                return getColumn(4);
            }
            set
            {
                setColumn(4, value);
            }
        }

        private void setColumn(int column, int[] value)
        {
            for (int i = 0; i < 5; i++)
            {
                grid[column, i] = value[i];
            }
        }

        private int[] getColumn(int column)
        {
            int[] col = { -1, -1, -1, -1, -1 };
            for (int i = 0; i < 5; i++)
            {
                col[i] = grid[column, i];
            }
            return col;
        }

        public int this[int row, int col]
        {
            get
            {
                if (grid == null)
                    return -1;
                //throw new InvalidOperationException("CardPattern's grid has not been initialized.");
                else
                    return grid[col, row];
            }
            set { grid[col, row] = value; }
        }
        public CardPattern Clone()
        {
            return new CardPattern((int[,])this.grid.Clone());
        }

        internal int[,] RawGrid
        {
            get { return grid; }
            set { grid = value; }
        }
    }
}
