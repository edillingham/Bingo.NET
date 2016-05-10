using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using BingoLib;

namespace BingoUI
{
    public class WinPatternLeafNode : TreeNode
    {
        private bool _isDirty = false;
        private WinPattern p;

        public WinPatternLeafNode(string name, WinPattern pattern)
        {
            this.p = pattern;
            base.Text = name;
        }

        public WinPattern GetPattern()
        {
            return this.p;
        }

        public bool IsDirty
        {
            get { return this._isDirty; }
            set { this._isDirty = true; }
        }

        public override string ToString()
        {
            return base.Text;
        }

        public new TreeNodeCollection Nodes
        {
            get
            {
                return null;
            }
        }

    }
}
