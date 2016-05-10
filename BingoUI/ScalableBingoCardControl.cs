using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BingoUI
{
    public partial class ScalableBingoCardControl : UserControl
    {
        private const int DefaultCellHeight = 25;
        private const int DefaultCellWidth = 20;
        private const int DefaultCellPadding = 2;

        private CellLabel[,] cells = {
            { null, null, null, null, null },
            { null, null, null, null, null },
            { null, null, null, null, null },
            { null, null, null, null, null },
            { null, null, null, null, null }
        };

        public ScalableBingoCardControl()
        {
            InitializeComponent();

            int cellNum = 0;

            int left = 2;
            int top = 2;
            int defW = 20;
            int defH = 25;

            for (int y = 0; y < cells.GetUpperBound(0); y++)
            {
                for (int x = 0; x < cells.GetUpperBound(1); x++)
                {
                    CellLabel c = new CellLabel(); ;
                    c.Location = new System.Drawing.Point(
                        (defW * x) + (left * x),
                        (defH * y) + (top * y)
                    );
                }
            }
        }

        private void ScalableBingoCardControl_Load(object sender, EventArgs e)
        {
        }
    }
}
