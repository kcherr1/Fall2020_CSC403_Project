using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace MyGameLibrary.UI
{
    // a custom control to make changes to the textbox
    // referenced https://www.codeproject.com/Articles/3107/Simple-Label-Gradient and http://www.java2s.com/Code/CSharp/2D-Graphics/GradientLabel.htm
    // also referenced https://stackoverflow.com/questions/25012368/c-sharp-labels-textalign-doesnt-work-after-onpaint-override
    public partial class GradientTextbox : Label
    {
        public string contents { get; set; }
        public GradientTextbox()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            // create gradient and apply to background
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Color whiteTransparent = Color.FromArgb(175, Color.White);
            Color pinkTransparent = Color.FromArgb(175, Color.HotPink);
            this.BackColor = Color.Transparent;
            LinearGradientBrush brush = new LinearGradientBrush(rectangle, whiteTransparent, pinkTransparent, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, rectangle);
            brush.Dispose();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // render text
            TextFormatFlags format = TextFormatFlags.Left | TextFormatFlags.WordBreak;
            TextRenderer.DrawText(e.Graphics, contents, Font, ClientRectangle, Color.Black, format);
        }
    }
}
