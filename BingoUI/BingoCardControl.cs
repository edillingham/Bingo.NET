using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Resources;
using System.Drawing.Imaging;
using System.IO;

using BingoLib;

namespace BingoUI
{
    public partial class BingoCardControl : UserControl
    {
        public class CellDaubbedEventArgs : EventArgs
        {
            private int[,] _pattern;
            private int _ball;
            public static readonly new CellDaubbedEventArgs Empty = new CellDaubbedEventArgs(0, null);
            
            public CellDaubbedEventArgs(int ball, int[,] pattern)
            {
                _ball = ball;
                _pattern = pattern;
            }
            public int[,] Pattern
            {
                get { return _pattern; }
            }
            public int Ball
            {
                get
                {
                    return _ball;
                }
            }
        }

        public event EventHandler<CellDaubbedEventArgs> CellDaubbed;
        public virtual void OnCellDaubbed(CellDaubbedEventArgs e)
        {
            EventHandler<CellDaubbedEventArgs> handler = CellDaubbed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private BingoCard card = null;
        private bool isSelected = false;
        
        private float denomination = 0.00F;

        public BingoCardControl()
        {
            InitializeComponent();
            init(0, false);
        }

        public void Buy(long sessionID, float denom)
        {
            init(sessionID, true);
        }

        private void init(long sessionID, bool generateNumbers)
        {
            if (generateNumbers)
                card = BingoCardGenerator.Generate(sessionID);
            else
                card = new BingoCard(sessionID);

            drawCard(card);
        }

        private void drawCard(BingoCard card)
        {
            int[,] nums = card.GetGrid();
            int val;
            BingoCardCellControl curCell = null;

            this.SuspendLayout();

            for (int r = 0; r < BingoCard.RowCount; r++)
            {
                for (int c = 0; c < BingoCard.ColumnCount; c++)
                {
                    curCell = this.GetCell(c, r);
                    val = nums[c, r];

                    if (curCell.IsFreeSpace)
                    {
                        curCell.BackColor = Color.Yellow;
                    } 
                    else
                    {
                        curCell.BackColor = Color.White;

                        if (val > 0)
                            curCell.Content = val.ToString("0#");
                        else
                            curCell.Content = "";
                    }
                }
            }
            this.ResumeLayout();
        }

        private BingoCardCellControl GetCell(int x, int y)
        {
            string letter = "";

            switch (x)
            {
                case 0:
                    letter = "B";
                    break;
                case 1:
                    letter = "I";
                    break;
                case 2:
                    letter = "N";
                    break;
                case 3:
                    letter = "G";
                    break;
                case 4:
                    letter = "O";
                    break;
            }

            BingoCardCellControl cell = (BingoCardCellControl)this.Controls["cell" + letter + y.ToString()];
            
            return cell;
        }

        public void Daub(int ballNum)
        {
            int[,] nums = card.GetGrid();
            BingoCardCellControl curCell = null;

            for (int r = 0; r < BingoCard.RowCount; r++)
            {
                for (int c = 0; c < BingoCard.ColumnCount; c++)
                {
                    curCell = this.GetCell(c, r);
                    if (!curCell.IsFreeSpace)
                    {
                        if (curCell.Value == ballNum)
                        {
                            card.Daub(r, c);
                            this.GetCell(c, r).BackColor = Color.Green;

                            OnCellDaubbed(new CellDaubbedEventArgs(ballNum, card.GetMask()));

                            break;
                        }
                    }
                }
            }
        }

        public void Toggle()
        {
            if (isSelected)
                init(card.SessionID, false);
            else
                init(card.SessionID, true);
        }

        private void BingoCardControl_Click(object sender, EventArgs e)
        {
            this.Toggle();
        }

        public void Highlight(int[,] targets)
        {
            BingoCardCellControl curCell;

            for (int r = 0; r < BingoCard.RowCount; r++)
            {
                for (int c = 0; c < BingoCard.ColumnCount; c++)
                {
                    if (targets[r, c] == 1)
                    {
                        curCell = this.GetCell(c, r);
                        curCell.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}