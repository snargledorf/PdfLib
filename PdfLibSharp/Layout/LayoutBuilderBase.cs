using PdfLibSharp.Drawing;
using PdfLibSharp.Elements;

namespace PdfLibSharp.Layout;

internal abstract class LayoutBuilderBase(IElement element, Size contentSize) : ILayoutBuilder
{
    public Size OuterSize { get; } = new
    (
        Width: contentSize.Width + element.Margins.Left + element.Margins.Right,
        Height: contentSize.Height + element.Margins.Top + element.Margins.Bottom
    );

    public Size ContentSize { get; } = contentSize;
    public IElement Element { get; } = element;
    
    public abstract ILayout BuildLayout(Rectangle bounds);
}