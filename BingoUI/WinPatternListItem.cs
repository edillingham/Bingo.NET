using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using BingoLib;

namespace BingoUI
{
    public class WinPatternListItem : ListViewItem
    {
        private WinPattern p;
        private string name = "noname pattern";

        public WinPatternListItem(string name, WinPattern pattern)
        {
            this.p = pattern;
            base.Text = name;
        }

        public WinPattern GetPattern()
        {
            return this.p;
        }

        public override string ToString()
        {
            return base.Text;
        }
    }
}
