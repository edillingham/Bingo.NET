using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BingoUI
{
    public static class HotKeyController
    {
        public static void Process(KeyPressEventArgs e)
        {
            {
                // process the hotkey
                if(e.KeyChar.ToString() == "C")
                {
                    SekretCardGenerator sgf = new SekretCardGenerator();
                    sgf.Show();
                }
            }
        }

        

    }
}
