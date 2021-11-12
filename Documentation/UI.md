# GradientTextbox (inherits from Label)
# Class variables
## contents (string)
The contents of the textbox to be displayed

# Functions
## GradientTextbox (no parameters)
Constructor for the gradient textbox which sets the userpaint flag to true.
## OnPaintBackground (override void, one parameter: PaintEventArgs e)
Overrides the Label’s OnPaintBackground function to add a gradient background using a LinearGradientBrush.
## OnPaint (override void, one parameter: PaintEventArgs e)
Overrides the Label’s OnPaint function to display text on top of the gradient.

# DoubleBufferedPanel (inherits from Panel)
# Functions
## DoubleBufferedPanel (no parameters)
The constructor for the DoubleBufferedPanel which sets DoubleBuffered to true when the panel is created.
