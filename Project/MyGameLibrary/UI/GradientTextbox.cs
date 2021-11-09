using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace MyGameLibrary.UI
{
    // a custom control to make changes to the textbox
    // referenced https://social.msdn.microsoft.com/Forums/en-US/fbdd1e74-4ad9-40ae-9458-3339640948c3/how-to-give-gradient-color-for-text-background?forum=csharplanguage
    // also referenced https://www.codeproject.com/Articles/3107/Simple-Label-Gradient and http://www.java2s.com/Code/CSharp/2D-Graphics/GradientLabel.htm
    public partial class GradientTextbox : Label
    {
        public GradientTextbox()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rectangle = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.HotPink, LinearGradientMode.Vertical);
            Brush textbrush = new SolidBrush(ForeColor);
            e.Graphics.FillRectangle(brush, rectangle);
            e.Graphics.DrawString(Text, Font, textbrush, Location);
            brush.Dispose();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            TextFormatFlags format = TextFormatFlags.Left | TextFormatFlags.WordBreak;
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, format);
        }

    }
}
