using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatternMaskBuilder
{
    public class CellLabel : Label
    {
        bool _isSelected = false;
        bool _isHighlighted = false;
        bool _isFreeSpace = false;

        Color _defaultColor;
        Color _hiliteColor;
        Color _selectColor;
        Color _specialColor;

        public CellLabel() : base()
        {
            this.init(false);
        }

        public CellLabel(bool isFreeSpace)
        {
            this.init(isFreeSpace);
        }

        private void init(bool isFree)
        {
            this._isFreeSpace = isFree;

            try
            {
                _defaultColor = Color.FromName(ConfigurationSettings.AppSettings["cellDefaultColor"]);
                _hiliteColor = Color.FromName(ConfigurationSettings.AppSettings["cellHighlightColor"]);
                _selectColor = Color.FromName(ConfigurationSettings.AppSettings["cellSelectedColor"]);
                _specialColor = Color.FromName(ConfigurationSettings.AppSettings["cellSpecialColor"]);
            }
            catch (Exception e) { }
        }

        public bool IsHighlighted
        {
            get
            {
                return this._isHighlighted;
            }
            set
            {
                this._isHighlighted = value;

                if (this._isHighlighted)
                    this.BackColor = this._hiliteColor;
                else
                    if (this._isFreeSpace)
                        this.BackColor = this._specialColor;
                    else
                        if (this._isSelected)
                            this.BackColor = this._selectColor;
                        else
                            this.BackColor = this._defaultColor;
            }
        }
        
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }

            set
            {
                _isSelected = value;

                if (_isSelected)
                    this.BackColor = _selectColor;
                else
                    if (this._isFreeSpace)
                        this.BackColor = _specialColor;
                    else
                        this.BackColor = _defaultColor;
            }
        }

        public bool IsFreeSpace
        {
            get { return this._isFreeSpace; }
        }
    }
}
