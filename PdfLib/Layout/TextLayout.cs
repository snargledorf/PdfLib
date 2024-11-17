using PdfLib.Drawing;
using PdfLib.Elements;

namespace PdfLib.Layout;

internal class TextLayout(
    IReadOnlyCollection<Line> lines,
    Point point,
    Size contentSize,
    Margins margins,
    Font font,
    StringFormat format,
    Brush brush,
    Pen? borderPen)
    : BorderElementLayout(point, contentSize, margins, borderPen), ITextLayout
{
    public IReadOnlyCollection<Line> Lines { get; } = lines;
    public StringFormat Format { get; } = format;
    public Brush Brush { get; } = brush;
    public Font Font { get; } = font;
}