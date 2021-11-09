using System.Windows.Forms;

namespace MyGameLibrary.UI
{
    // fixes flickering bug by setting the panels to be double buffered
    // used https://stackoverflow.com/questions/21873441/panel-background-image-flickering
    public class DoubleBufferedPanel : Panel

    {
        public DoubleBufferedPanel() : base()
        {
            this.DoubleBuffered = true;
        }
    }
}
