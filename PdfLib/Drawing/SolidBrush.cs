using PdfSharp.Drawing;

namespace PdfLib.Drawing;

public class SolidBrush : Brush
{
    private SolidBrush(XSolidBrush brush) 
        : base(brush)
    {
    }

    public SolidBrush(Color color) 
        : this(new XSolidBrush(color))
    {
    }
}