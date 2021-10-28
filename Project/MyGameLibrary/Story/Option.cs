using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary.Story
{
    public class Option
    {
        public string OptionText { get; set; }
        public string OptionBackendMarkup { get; set; }
        public bool OptionFocused { get; set; }

        public Option(string text, string markup, bool focused=false)
        {
            this.OptionText = text;
            this.OptionBackendMarkup = markup;
            this.OptionFocused = focused;
        }
    }
}
