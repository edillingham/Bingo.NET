using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bingo
{
    public partial class GameOptions : Form
    {
        public GameOptions()
        {
            InitializeComponent();
        }

        private void trackFlashSpeed_Scroll(object sender, EventArgs e)
        {
            ((BingoTestForm)this.Owner).WinningCardFlashInterval = trackFlashSpeed.Value; // 20ths of a second
        }
    }
}