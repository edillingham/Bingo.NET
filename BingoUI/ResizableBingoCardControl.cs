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
    public partial class ResizableBingoCardControl : UserControl
    {
        public const int WinFlashInterval = 400;
        public static Color DefaultFlashColor = Color.Red;

        public event EventHandler<CellDaubbedEventArgs> CellDaubbed;
        public virtual void OnDaub(CellDaubbedEventArgs e)
        {
            EventHandler<CellDaubbedEventArgs> handler = CellDaubbed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<EventArgs> CardToggled;
        public virtual void OnToggle(EventArgs e)
        {
            EventHandler<EventArgs> handler = CardToggled;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private BingoCard card = null;
        private CardPattern flashPattern;
        private CardPattern daubPattern;
        private bool isSelected = false;
        private bool isFlashed = false;
        private bool isFlashing = false;
        private Color flashColor = DefaultFlashColor;
        private EventHandler tickEventHandler;

        public ResizableBingoCardControl()
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
            if (this.isFlashed)
                this.flashMe();

            if (generateNumbers)
                card = BingoCardGenerator.Generate(sessionID);
            else
                card = new BingoCard(sessionID);

            flashPattern = card.GetBlankCard();
            daubPattern = card.GetBlankCard();

            drawCard();
        }

        private bool IsFlashing
        {
            get
            {
                return isFlashing;
            }
        }

        private void drawCard()
        {
            int val;
            BingoCardCellControl curCell = null;

            this.SuspendLayout();

            for (int r = 0; r < BingoCard.RowCount; r++)
            {
                for (int c = 0; c < BingoCard.ColumnCount; c++)
                {
                    curCell = this.GetCell(c, r);
                    val = card.Cells[c, r];

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
            CardPattern nums = card.GetGrid();
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

                            OnDaub(new CellDaubbedEventArgs(ballNum, card.GetMask()));

                            break;
                        }
                    }
                }
            }
        }

        public void Toggle()
        {
            bool isSelected = !this.pictureBox1.Visible;
            this.pictureBox1.Visible = isSelected;
            //this.init(card.SessionID, isSelected);
        }

        public void Flash()
        {
            flashMe();
        }

        public void Flash(CardPattern targets)
        {
            this.flashPattern = targets;
            this.daubPattern = card.GetMask();

            flashMe();
        }

        private void flashMe()
        {
            BingoCardCellControl curCell;

            for (int r = 0; r < BingoCard.RowCount; r++)
            {
                for (int c = 0; c < BingoCard.ColumnCount; c++)
                {
                    curCell = this.GetCell(c, r);
                    if (this.isFlashed)
                    {
                        if (flashPattern[r, c] == 1)
                            curCell.BackColor = Color.Red;
                    }
                    else
                    {
                        if (curCell.IsFreeSpace)
                            curCell.BackColor = Color.Yellow;
                        else if (daubPattern[r, c] == 1)
                            curCell.BackColor = Color.Green;
                        else
                            curCell.BackColor = Color.White;
                    }
                }
            }
            this.isFlashed = !this.isFlashed;
        }

        public bool IsSelected
        {
            get { return !this.pictureBox1.Visible; }
        }

        private void ResizableBingoCardControl_Click(object sender, EventArgs e)
        {
            this.Toggle();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Toggle();
        }

    }
    public class CellDaubbedEventArgs : EventArgs
    {
        private CardPattern _pattern;
        private int _ball;
        public static readonly new CellDaubbedEventArgs Empty = new CellDaubbedEventArgs(0, null);
        public CellDaubbedEventArgs(int ball, CardPattern pattern)
        {
            _ball = ball;
            _pattern = pattern;
        }

        public CardPattern Pattern
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
}