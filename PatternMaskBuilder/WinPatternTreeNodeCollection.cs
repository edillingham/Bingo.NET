using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using BingoLib;

namespace PatternMaskBuilder
{
    public class WinPatternTreeNodeCollection : TreeNodeCollection
    {
        public WinPattern[] GetPatterns()
        {
            List<WinPattern> patterns = new List<WinPattern>();
            foreach (WinPatternTreeNode wptn in base.GetEnumerator())
            {
                patterns.Add(wptn.GetPattern());
            }
            return patterns.ToArray();
        }
    }
}
