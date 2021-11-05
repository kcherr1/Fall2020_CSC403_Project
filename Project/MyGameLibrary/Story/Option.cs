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
        private int correction = 51; // correction value of 51 is a 19.921875% change, cloest value to 20% change
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
                int r = OptionLabel.BackColor.R;
                int g = OptionLabel.BackColor.G;
                int b = OptionLabel.BackColor.B;
                if (!_OptionFocused && value) //If set value is true and was previously false
                {
                    #region Darken BackColor
                    r = (int)(r - correction);
                    g = (int)(g - correction);
                    b = (int)(b - correction);
                    #endregion
                    OptionLabel.BackColor = Color.FromArgb(a, (int)r, (int)g, (int)b);
                }
                if (_OptionFocused && !value) //If set value to false and was previously true
                {
                    #region Brighten Backcolor
                    r = (int)(r + correction);
                    g = (int)(g + correction);
                    b = (int)(b + correction);
                    #endregion
                    OptionLabel.BackColor = Color.FromArgb(a, (int)r, (int)g, (int)b);
                }
                _OptionFocused = value;
            }
        }
        public Label OptionLabel { get; set; }
        public Option(string text, string markup, bool focused = false)
        {
            this.OptionText = text;
            this.OptionBackendMarkup = markup;
        }
    }
}
