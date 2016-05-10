using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BingoLib
{

    public class PatternMatcher
    {
        private Dictionary<MatchedPattern, List<CardPattern>> winningPatterns;

        public PatternMatcher(string patternPath)
        {
            winningPatterns = new Dictionary<MatchedPattern, List<CardPattern>>();
            if (!Directory.Exists(patternPath))
            {
                this.load(patternPath);
            }
        }

        public MatchedPattern Match(CardPattern pattern, out CardPattern mask)
        {
            MatchedPattern bestMatch = MatchedPattern.NoMatch;
            //winningPatterns = buildWinLadder();

            mask = null;

            // loop through the win ranks
            foreach(MatchedPattern m in winningPatterns.Keys)
            {
                // loop through the current rank's patterns
                List<CardPattern> rank = winningPatterns[m];

                for (int i = 0; i < rank.Count; i++)
                {
                    // mask the card according to the win pattern
                    CardPattern masked = maskCard(pattern, rank[i]);

                    /*System.Diagnostics.Debug.WriteLine("\n\n------------------------------------\n\n");
                    System.Diagnostics.Debug.WriteLine("Winning Pattern:");
                    System.Diagnostics.Debug.WriteLine(PatternMatcher.RawToString(rank[i]));
                    System.Diagnostics.Debug.WriteLine("\nCard Pattern:");
                    System.Diagnostics.Debug.WriteLine(PatternMatcher.RawToString(pattern));
                    System.Diagnostics.Debug.WriteLine("\nCard Mask:");
                    System.Diagnostics.Debug.WriteLine(PatternMatcher.RawToString(masked));
                    System.Diagnostics.Debug.WriteLine("\n\n------------------------------------\n\n");*/

                    if (RawToString(rank[i]).Equals(RawToString(masked)))
                    {
                        bestMatch = m;
                        mask = masked;
                        break;
                    }
                }
            }

            //WinPattern wp;
            //if (mask != null)
            //    wp = new WinPattern(mask);
            //else
            //    wp = new WinPattern();

            //return wp;
            return bestMatch;
        }

        private static CardPattern maskCard(CardPattern pattern, CardPattern win)
        {
            CardPattern masked = pattern.Clone();
            for (int r = 0; r < BingoCard.RowCount; r++)
            {
                for (int c = 0; c < BingoCard.ColumnCount; c++)
                {
                    // if the current cell is not part of the winning pattern, remove it from the mask
                    if (win[r, c] == 0)
                        masked[r, c] = 0;
                }
            }
            return masked;
        }

        internal void load(string path)
        {
            // the enum is both the source of and the definition for serialized object filenames & dictionary keys
            string[] ptypes = Enum.GetNames(typeof(MatchedPattern));
            winningPatterns.Clear();

            for (int i = 0; i < ptypes.Length; i++)
            {
                string ptype = ptypes[i];
                WinPatternSet wps = PatternSerializer.DeserializePatternSet(path, ptype);

                if (wps != null)
                {
                    for (int j = 0; j < wps.PatternCount; j++)
                    {
                        winningPatterns.Add(wps.PatternType, new List<CardPattern>(wps.Patterns));
                    }
                }
            }

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("WinPatterns.xml");

            XmlNodeList xnl = xmldoc.SelectNodes("//WinPattern");
            XmlSerializer xs = new XmlSerializer(typeof(CardPattern));

            foreach (XmlNode xn in xnl)
            {
                string mtypestr = xn.Attributes.GetNamedItem("PatternType").Value;
                MatchedPattern mtype = (MatchedPattern)Enum.Parse(typeof(MatchedPattern), mtypestr, true);

                if (!this.winningPatterns.ContainsKey(mtype))
                {
                    this.winningPatterns.Add(mtype, new List<CardPattern>());
                }
                this.winningPatterns[mtype].Add((CardPattern)xs.Deserialize(new XmlNodeReader(xn)));
            }

        }

        //private static Dictionary<MatchedPattern, List<CardPattern>> buildWinLadder()
        //{
        //    // six-packs
        //    patterns = new List<CardPattern>();
        //    patterns.Add(new CardPattern(NINE_PACK_1));
        //    patterns.Add(new CardPattern(NINE_PACK_2));
        //    patterns.Add(new CardPattern(NINE_PACK_3));
        //    patterns.Add(new CardPattern(NINE_PACK_4));
        //    winpatterns.Add(MatchedPattern.NinePack, patterns);

        //    // six-packs
        //    patterns = new List<CardPattern>();
        //    patterns.Add(new CardPattern(SIX_PACK_1));
        //    patterns.Add(new CardPattern(SIX_PACK_2));
        //    patterns.Add(new CardPattern(SIX_PACK_3));
        //    patterns.Add(new CardPattern(SIX_PACK_4));
        //    patterns.Add(new CardPattern(SIX_PACK_5));
        //    patterns.Add(new CardPattern(SIX_PACK_6));
        //    patterns.Add(new CardPattern(SIX_PACK_7));
        //    patterns.Add(new CardPattern(SIX_PACK_8));
        //    winpatterns.Add(MatchedPattern.SixPack, patterns);

        //    // stamps
        //    patterns = new List<CardPattern>();
        //    patterns.Add(new CardPattern(STAMP_BINGO_1));
        //    patterns.Add(new CardPattern(STAMP_BINGO_2));
        //    patterns.Add(new CardPattern(STAMP_BINGO_3));
        //    patterns.Add(new CardPattern(STAMP_BINGO_4));
        //    winpatterns.Add(MatchedPattern.StampBingo, patterns);

        //    // four corners
        //    patterns = new List<CardPattern>();
        //    patterns.Add(new CardPattern(FOUR_CORNERS));
        //    winpatterns.Add(MatchedPattern.FourCorners, patterns);

        //    //lines
        //    patterns = new List<CardPattern>();
        //    patterns.Add(new CardPattern(LINE_BINGO_1));
        //    patterns.Add(new CardPattern(LINE_BINGO_2));
        //    patterns.Add(new CardPattern(LINE_BINGO_3));
        //    patterns.Add(new CardPattern(LINE_BINGO_4));
        //    patterns.Add(new CardPattern(LINE_BINGO_5));
        //    patterns.Add(new CardPattern(LINE_BINGO_6));
        //    patterns.Add(new CardPattern(LINE_BINGO_7));
        //    patterns.Add(new CardPattern(LINE_BINGO_8));
        //    patterns.Add(new CardPattern(LINE_BINGO_9));
        //    patterns.Add(new CardPattern(LINE_BINGO_10));
        //    patterns.Add(new CardPattern(LINE_BINGO_11));
        //    patterns.Add(new CardPattern(LINE_BINGO_12));
        //    winpatterns.Add(MatchedPattern.LineBingo, patterns);

        //    return winpatterns;

        //}

        public static string RawToString(CardPattern raw)
        {
            string output = "";
            for (int r = 0; r < BingoCard.RowCount; r++)
            {
                for (int c = 0; c < BingoCard.ColumnCount; c++)
                {
                    output += raw[r, c].ToString();

                    if (c < BingoCard.ColumnCount)
                        output += " ";
                }
                output += "\n";
            }
            return output;
        }

        private static int[,] LINE_BINGO_1 = {
                {1,1,1,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] LINE_BINGO_2 = {
                {0,0,0,0,0},
                {1,1,1,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] LINE_BINGO_3 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,1,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] LINE_BINGO_4 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,1,1,1},
                {0,0,0,0,0}
            };
        private static int[,] LINE_BINGO_5 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,1,1,1}
            };
        private static int[,] LINE_BINGO_6 = {
                {1,0,0,0,0},
                {1,0,0,0,0},
                {1,0,0,0,0},
                {1,0,0,0,0},
                {1,0,0,0,0}
            };
        private static int[,] LINE_BINGO_7 = {
                {0,1,0,0,0},
                {0,1,0,0,0},
                {0,1,0,0,0},
                {0,1,0,0,0},
                {0,1,0,0,0}
            };
        private static int[,] LINE_BINGO_8 = {
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0}
            };
        private static int[,] LINE_BINGO_9 = {
                {0,0,0,1,0},
                {0,0,0,1,0},
                {0,0,0,1,0},
                {0,0,0,1,0},
                {0,0,0,1,0}
            };
        private static int[,] LINE_BINGO_10 = {
                {0,0,0,0,1},
                {0,0,0,0,1},
                {0,0,0,0,1},
                {0,0,0,0,1},
                {0,0,0,0,1}
            };
        private static int[,] LINE_BINGO_11 = {
                {1,0,0,0,0},
                {0,1,0,0,0},
                {0,0,1,0,0},
                {0,0,0,1,0},
                {0,0,0,0,1}
            };
        private static int[,] LINE_BINGO_12 = {
                {0,0,0,0,1},
                {0,0,0,1,0},
                {0,0,1,0,0},
                {0,1,0,0,0},
                {1,0,0,0,0}
            };
        private static int[,] FOUR_CORNERS = {
                {1,0,0,0,1},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,0,0,0,1}
            };
        private static int[,] STAMP_BINGO_1 = {
                {1,1,0,0,0},
                {1,1,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] STAMP_BINGO_2 = {
                {0,0,0,1,1},
                {0,0,0,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] STAMP_BINGO_3 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,0,0,0},
                {1,1,0,0,0}
            };
        private static int[,] STAMP_BINGO_4 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,1,1},
                {0,0,0,1,1}
            };
        private static int[,] SIX_PACK_1 = {
                {1,1,1,0,0},
                {1,1,1,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] SIX_PACK_2 = {
                {1,1,0,0,0},
                {1,1,0,0,0},
                {1,1,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] SIX_PACK_3 = {
                {0,0,1,1,1},
                {0,0,1,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] SIX_PACK_4 = {
                {0,0,0,1,1},
                {0,0,0,1,1},
                {0,0,0,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] SIX_PACK_5 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,1,0,0},
                {1,1,1,0,0}
            };
        private static int[,] SIX_PACK_6 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,0,0,0},
                {1,1,0,0,0},
                {1,1,0,0,0}
            };
        private static int[,] SIX_PACK_7 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,1,1,1},
                {0,0,1,1,1}
            };
        private static int[,] SIX_PACK_8 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,1,1},
                {0,0,0,1,1},
                {0,0,0,1,1}
            };
        private static int[,] NINE_PACK_1 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,1,1,1},
                {0,0,1,1,1},
                {0,0,1,1,1}
            };
        private static int[,] NINE_PACK_2 = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,1,0,0},
                {1,1,1,0,0},
                {1,1,1,0,0}
            };
        private static int[,] NINE_PACK_3 = {
                {1,1,1,0,0},
                {1,1,1,0,0},
                {1,1,1,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
        private static int[,] NINE_PACK_4 = {
                {0,0,1,1,1},
                {0,0,1,1,1},
                {0,0,1,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };
    }
}
