using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BingoUI
{
    internal class CellLabel : Label
    {
        private int _value;

        public CellLabel()
        {
            this.SuspendLayout();

            this.AutoSize = false;
            this.Dock = DockStyle.None;
            this.Anchor = AnchorStyles.None;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackColor = Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size = new System.Drawing.Size(40, 40);
            this.Text = "00";
            this.Visible = true;

            this.ResumeLayout();
        }

        public override string ToString()
        {
            return _value.ToString("0#");
        }
        public int Number
        {
            get
            {
                return this._value;
            }
        }
        public string Letter
        {
            get
            {
                if (_value < 0 || _value > 75)
                    throw new ApplicationException("Cell is assigned invalid value (outside the range of 1-75).");
                else if (_value > 0 || _value <= 15)
                    return "B";
                else if (_value > 15 || _value <= 30)
                    return "I";
                else if (_value > 30 || _value <= 45)
                    return "N";
                else if (_value > 45 || _value <= 60)
                    return "G";
                else if (_value > 60 || _value <= 75)
                    return "O";
                else
                    return null;
            }
        }
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

    }
}
