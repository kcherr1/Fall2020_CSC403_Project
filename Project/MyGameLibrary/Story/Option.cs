using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGameLibrary.Story
{
    public class Option
    {
        public string OptionText { get; set; }
        public string OptionBackendMarkup { get; set; }
        private float _OptionDarkenBrightenPercent = (float).20; //Must be between 0-1
        private bool _OptionFocused;
        public bool OptionFocused
        {
            get
            {
                return _OptionFocused;
            }

            set
            {
                int a = OptionLabel.BackColor.A;
                float r = OptionLabel.BackColor.R;
                float g = OptionLabel.BackColor.G;
                float b = OptionLabel.BackColor.B;
                if(!_OptionFocused && value) //If set value is true and was previously false
                {
                    #region Darken BackColor
                    float correction  = 1 - _OptionDarkenBrightenPercent;
                    r = (float)(r * correction);
                    g = (float)(g * correction);
                    b = (float)(b * correction);
                    #endregion
                    OptionLabel.BackColor = Color.FromArgb(a, (int)r, (int)g, (int)b);
                }
                if (_OptionFocused && !value) //If set value to false and was previously true
                {
                    #region Brighten Backcolor
                    r = (float)((255 - r) * _OptionDarkenBrightenPercent + r);
                    g = (float)((255 - g) * _OptionDarkenBrightenPercent + g);
                    b = (float)((255 - b) * _OptionDarkenBrightenPercent + b);
                    #endregion
                    OptionLabel.BackColor = Color.FromArgb(a, (int)r, (int)g, (int)b);
                }
                _OptionFocused = value;
            }
        }
        public Label OptionLabel { get; set; }
        public Option(string text, string markup, bool focused=false)
        {
            this.OptionText = text;
            this.OptionBackendMarkup = markup;
        }
    }
}
