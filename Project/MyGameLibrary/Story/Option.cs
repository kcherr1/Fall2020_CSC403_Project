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
        private float _OptionDarkenBrightenPercent = (float)0.2;
        private bool _OptionFocused;
        public bool OptionFocused
        {
            get
            {
                return _OptionFocused;
            }

            set
            {
                if(!_OptionFocused && value) //If set value is true and was previously false
                {
                    #region Darken BackColor
                    int a = OptionLabel.BackColor.A;
                    float r = OptionLabel.BackColor.R;
                    float g = OptionLabel.BackColor.G;
                    float b = OptionLabel.BackColor.B;
                    r = (float)(r * (-1 * _OptionDarkenBrightenPercent / 100.0));
                    g = (float)(g * (-1 * _OptionDarkenBrightenPercent / 100.0));
                    b = (float)(b * (-1 * _OptionDarkenBrightenPercent / 100.0));
                    #endregion
                    OptionLabel.BackColor = Color.FromArgb(a, (int)r, (int)g, (int)b);
                }
                else if (_OptionFocused && !value) //If set value to false and was previously true
                {
                    #region Brighten Backcolor
                    int a = OptionLabel.BackColor.A;
                    float r = OptionLabel.BackColor.R;
                    float g = OptionLabel.BackColor.G;
                    float b = OptionLabel.BackColor.B;
                    r = (float)(r * (_OptionDarkenBrightenPercent / 100.0));
                    g = (float)(g * (_OptionDarkenBrightenPercent / 100.0));
                    b = (float)(b * (_OptionDarkenBrightenPercent / 100.0));
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
