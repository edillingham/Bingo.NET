using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Collections;

using BingoLib;
using BingoUI;

namespace Bingo
{
    public partial class BingoTestForm : Form
    {
        private const int NUM_BALLS_TO_PULL = 24;

        private BallBlower blower = new BallBlower();
        private PatternMatcher verifier;
        private ArrayList cards = new ArrayList();
        private Dictionary<ResizableBingoCardControl, CardPattern> winners = new Dictionary<ResizableBingoCardControl, CardPattern>();

        private float denomination = .05F;
        private float balance = 10F;

        public BingoTestForm()
        {
            InitializeComponent();

            cards.Add(resizableBingoCardControl1);
            cards.Add(resizableBingoCardControl2);
            cards.Add(resizableBingoCardControl3);
            cards.Add(resizableBingoCardControl4);
            cards.Add(resizableBingoCardControl5);
            cards.Add(resizableBingoCardControl6);
            cards.Add(resizableBingoCardControl7);
            cards.Add(resizableBingoCardControl8);
            cards.Add(resizableBingoCardControl9);

            loadWinningPatterns();
        }

        private void loadWinningPatterns()
        {
            //string path = Path.Combine(Application.StartupPath, "data");
            string path = ConfigurationManager.AppSettings["patternPath"];
            verifier = new PatternMatcher(path);
        }

        private void BingoTestForm_Load(object sender, EventArgs e)
        {
            txtBalls.Text = "";
            this.txtBalance .Text= this.balance.ToString("$0.00");
        }

        private void btnPullBalls_Click(object sender, EventArgs e)
        {
            flashTimer.Enabled = false;
            winners.Clear();
            
            txtBalls.Text = "";

            blower.Reset();
            this.generateCards();
            
            ballTimer.Enabled = true;

        }

        private void generateCards()
        {
            ResizableBingoCardControl card;
            
            for (int i = 0; i < cards.Count; i++)
            {
                card = (ResizableBingoCardControl)cards[i];
                
                if(card.IsSelected)
                    card.Buy(0, denomination);
            }
        }

        private void daubCards(int nextBall)
        {
            for (int n = 0; n < cards.Count; n++)
                ((ResizableBingoCardControl)cards[n]).Daub(nextBall);
        }

        private void flashTimer_Tick(object sender, EventArgs e)
        {
            foreach (ResizableBingoCardControl cardCtl in winners.Keys)
            {
                cardCtl.Flash(winners[cardCtl]);
            }
        }

        private void ballTimer_Tick(object sender, EventArgs e)
        {
            if (blower.DrawCount >= blower.MaxBalls)
                ballTimer.Enabled = false;
            else
            {
                BingoBall nextBall = blower.GetNextBall();
                daubCards(nextBall.Number);

                if(blower.DrawCount > 0)
                    txtBalls.Text += " ";

                txtBalls.Text += (nextBall.ToString());

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            switch (trackBar1.Value)
            {
                case 1:
                    this.ballTimer.Interval = 800;
                    break;
                case 2:
                    this.ballTimer.Interval = 350;
                    break;
                case 3:
                    this.ballTimer.Interval = 100;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResizableBingoCardControl_CellDaubbed(object sender, CellDaubbedEventArgs e)
        {
            //Debug.WriteLine("Cell " + ((Control)sender).Name + ": daubed #" + e.Ball.ToString() + ".");

            checkForBingo((ResizableBingoCardControl)sender, e.Pattern);
        }

        private void checkForBingo(ResizableBingoCardControl card, CardPattern pattern)
        {
            CardPattern mask;
            MatchedPattern match = verifier.Match(pattern, out mask);
            
            // if the card's pattern matches a winning pattern
            if (match != MatchedPattern.NoMatch)
            {
                // set the flash pattern
                if (winners.ContainsKey(card))
                    winners[card] = mask;
                else
                    winners.Add(card, mask);

                // enable win flashing
                if(!flashTimer.Enabled)
                    flashTimer.Enabled = true;

                // update the game balance
            }
        }

        private void resetDenominations()
        {

        }

        private void btnUseNickels_Click(object sender, EventArgs e)
        {
            this.denomination = .05F;
            //this.BackColor = Color.Blue;
        }

        private void btnUseDimes_Click(object sender, EventArgs e)
        {
            this.denomination = .1F;
        }

        private void btnUseQuarters_Click(object sender, EventArgs e)
        {
            this.denomination = .25F;
        }

        private void btnUseHalfDollars_Click(object sender, EventArgs e)
        {
            this.denomination = .5F;
        }

        private void btnUseDollars_Click(object sender, EventArgs e)
        {
            this.denomination = 1F;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameOptions options = new GameOptions();
            options.Show(this);
            options = null;
        }

        public System.Windows.Forms.Timer FlashTimer
        {
            get { return flashTimer; }
        }
 
        public int WinningCardFlashInterval
        {
            get { return flashTimer.Interval; }
            set { flashTimer.Interval = value; }
        }
    }
}