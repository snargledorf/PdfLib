using PdfLibSharp.Drawing;
using PdfLibSharp.Elements;

namespace PdfLibSharp.Layout;

internal class LineLayout(Point start, Point end, Pen linePen, Size contentSize, Margins margins) 
    : ElementLayout(start, contentSize, margins), ILineLayout
{
    public Pen Pen { get; } = linePen;
    public Point Start { get; } = start;
    public Point End { get; } = end;
}