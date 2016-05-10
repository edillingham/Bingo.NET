using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BingoLib;

namespace BingoUI
{
    public partial class SekretCardGenerator : Form
    {
        public SekretCardGenerator()
        {
            InitializeComponent();
        }

        private void btnGenCard_Click(object sender, EventArgs e)
        {
            //BingoCardGenerator cardgen = new BingoCardGenerator();
            BingoCard card = BingoCardGenerator.Generate(0);

            List<string> outputs = new List<string>();
            outputs.Add("BB  II  NN  GG  OO");
            outputs.Add("--  --  --  --  --");

            string output = "";
            CardPattern nums = card.GetGrid();

            // output the card numbers
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (c == 2 && r == 2)
                    {
                        output += "**";
                    }
                    else
                    {
                        output += nums[c, r].ToString("0#");
                    }

                    if (c < 4) output += "  ";
                }
                outputs.Add(output);
                output = "";
            }
            txtCard.Lines = outputs.ToArray();
        }

        private void SekretCardGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}