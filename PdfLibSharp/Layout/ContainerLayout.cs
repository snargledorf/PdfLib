using PdfLibSharp.Drawing;
using PdfLibSharp.Elements;

namespace PdfLibSharp.Layout;

internal sealed class ContainerLayout(Point point, Size contentSize, Margins margins, Pen? borderPen, IReadOnlyList<ILayout> children)
    : BorderElementLayout(point, contentSize, margins, borderPen), IContainerLayout
{
    public IReadOnlyList<ILayout> Children { get; } = children;
}