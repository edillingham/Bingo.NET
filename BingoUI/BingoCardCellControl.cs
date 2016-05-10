using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BingoUI
{
    public partial class BingoCardCellControl : UserControl
    {
        bool isFree = false;

        ToolTip tt = new ToolTip();

        public BingoCardCellControl()
        {
            InitializeComponent();
            
        }

        public bool IsFreeSpace
        {
            get { return isFree; }
            set { isFree = value; }
        }

        public string Content
        {
            get { return this.CellContent.Text; }
            set { 
                this.CellContent.Text = value;
                tt.SetToolTip(this, this.Content);
            }
        }

        public int Value
        {
            get
            {
                if (this.Content == "")
                    return 0;
                else
                    return int.Parse(this.Content);
            }
        }

        public override Color BackColor
        {
            get { return this.CellContent.BackColor; }
            set { this.CellContent.BackColor = value; }
        }

        private void BingoCardCellControl_MouseEnter(object sender, EventArgs e)
        {
            tt.Active = true;
            tt.Show(this.Content, null);

        }

        private void BingoCardCellControl_MouseLeave(object sender, EventArgs e)
        {
            tt.Active = false;
        }
    }
}
