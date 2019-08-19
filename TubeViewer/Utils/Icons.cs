using FontAwesome.WPF;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace TubeViewer.Utils
{
    public class Config
    {
        public const string ApplicationName = "Tube Viewer";
        public static SolidColorBrush Brush(string hexColor)
        {
            try
            {
                return (SolidColorBrush)new BrushConverter().ConvertFromString("#" + hexColor.Trim('#'));
            }
            catch (Exception)
            {
                return (SolidColorBrush)new BrushConverter().ConvertFromString("#000");
            }
        }
        public static SolidColorBrush ColorIcon(string color = "00a9ec")
        {
            return Brush(color);
        }
        public static ImageSource ImageSource(FontAwesomeIcon icon, SolidColorBrush Color)
        {
            return ImageAwesome.CreateImageSource(icon, Color);
        }
        public static ImageSource ImageSource(FontAwesomeIcon FontAwesomeIcon, string Color)
        {
            return ImageSource(FontAwesomeIcon, ColorIcon(Color));
        }
        public static ImageSource ImageSource(FontAwesomeIcon FontAwesomeIcon)
        {
            return ImageSource(FontAwesomeIcon, ColorIcon());
        }
        public static ImageSource ImageSource()
        {
            return ImageSource(FontAwesomeIcon.FontAwesome, ColorIcon());
        }

    }
    /// <summary>
    /// Converts a <see cref="PackIcon{TKind}" /> to an ImageSource.
    /// Use the ConverterParameter to pass a Brush.
    /// </summary>
    //public abstract class PackIconImageSourceConverterBase<TKind> : MarkupExtension, IValueConverter
    //{
    //    /// <summary>
    //    /// Gets or sets the thickness to draw the icon with.
    //    /// </summary>
    //    public double Thickness { get; set; } = 0.25;

    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        if (!(value is TKind))
    //            return null;

    //        var foregroundBrush = parameter as Brush ?? Brushes.Black;
    //        return CreateImageSource(value, foregroundBrush, Thickness);
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override object ProvideValue(IServiceProvider serviceProvider)
    //    {
    //        return this;
    //    }

    //    protected abstract ImageSource CreateImageSource(object value, Brush foregroundBrush, double penThickness);
    //}

    ///// <summary>
    ///// Converts a <see cref="PackIcon{TKind}" /> to an ImageSource.
    ///// Use the ConverterParameter to pass a Brush.
    ///// </summary>
    //public class PackIconImageSourceConverter : MarkupExtension, IValueConverter
    //{
    //    /// <summary>
    //    /// Gets or sets the thickness to draw the icon with.
    //    /// </summary>
    //    public double Thickness { get; set; } = 0.25;

    //    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        if (value is null)
    //            return null;

    //        if (value is PackIconFontAwesomeKind)
    //            return new PackIconFontAwesomeImageSourceConverter { Thickness = Thickness }.Convert(value, targetType, parameter, culture);
    //        if (value is PackIconMaterialKind)
    //            return new PackIconMaterialImageSourceConverter { Thickness = Thickness }.Convert(value, targetType, parameter, culture);
    //        if (value is PackIconMaterialLightKind)
    //            return new PackIconMaterialLightImageSourceConverter { Thickness = Thickness }.Convert(value, targetType, parameter, culture);
    //        if (value is PackIconModernKind)
    //            return new PackIconModernImageSourceConverter { Thickness = Thickness }.Convert(value, targetType, parameter, culture);
    //        if (value is PackIconEntypoKind)
    //            return new PackIconEntypoImageSourceConverter { Thickness = Thickness }.Convert(value, targetType, parameter, culture);
    //        if (value is PackIconOcticonsKind)
    //            return new PackIconOcticonsImageSourceConverter { Thickness = Thickness }.Convert(value, targetType, parameter, culture);

    //        return null;
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override object ProvideValue(IServiceProvider serviceProvider)
    //    {
    //        return this;
    //    }
    //}

    //public class PackIconEntypoImageSourceConverter : PackIconImageSourceConverterBase<PackIconEntypoKind>
    //{
    //    protected override ImageSource CreateImageSource(object value, Brush foregroundBrush, double penThickness)
    //    {
    //        var packIcon = new PackIconEntypo { Kind = (PackIconEntypoKind)value };

    //        var geometryDrawing = new GeometryDrawing
    //        {
    //            Geometry = Geometry.Parse(packIcon.Data),
    //            Brush = foregroundBrush,
    //            Pen = new Pen(foregroundBrush, penThickness)
    //        };

    //        var drawingGroup = new DrawingGroup { Children = { geometryDrawing }, Transform = new ScaleTransform(1, -1) };

    //        return new DrawingImage { Drawing = drawingGroup };
    //    }
    //}

    //public class PackIconFontAwesomeImageSourceConverter : PackIconImageSourceConverterBase<PackIconFontAwesomeKind>
    //{
    //    protected override ImageSource CreateImageSource(object value, Brush foregroundBrush, double penThickness)
    //    {
    //        var packIcon = new PackIconFontAwesome { Kind = (PackIconFontAwesomeKind)value };

    //        var geometryDrawing = new GeometryDrawing
    //        {
    //            Geometry = Geometry.Parse(packIcon.Data),
    //            Brush = foregroundBrush,
    //            Pen = new Pen(foregroundBrush, penThickness)
    //        };

    //        var drawingGroup = new DrawingGroup { Children = { geometryDrawing }, Transform = new ScaleTransform(1, -1) };

    //        return new DrawingImage { Drawing = drawingGroup };
    //    }
    //}

    //public class PackIconMaterialImageSourceConverter : PackIconImageSourceConverterBase<PackIconMaterialKind>
    //{
    //    protected override ImageSource CreateImageSource(object value, Brush foregroundBrush, double penThickness)
    //    {
    //        var packIcon = new PackIconMaterial { Kind = (PackIconMaterialKind)value };

    //        var geometryDrawing = new GeometryDrawing
    //        {
    //            Geometry = Geometry.Parse(packIcon.Data),
    //            Brush = foregroundBrush,
    //            Pen = new Pen(foregroundBrush, penThickness)
    //        };

    //        var drawingGroup = new DrawingGroup { Children = { geometryDrawing } };

    //        return new DrawingImage { Drawing = drawingGroup };
    //    }
    //}

    //public class PackIconMaterialLightImageSourceConverter : PackIconImageSourceConverterBase<PackIconMaterialLightKind>
    //{
    //    protected override ImageSource CreateImageSource(object value, Brush foregroundBrush, double penThickness)
    //    {
    //        var packIcon = new PackIconMaterialLight { Kind = (PackIconMaterialLightKind)value };

    //        var geometryDrawing = new GeometryDrawing
    //        {
    //            Geometry = Geometry.Parse(packIcon.Data),
    //            Brush = foregroundBrush,
    //            Pen = new Pen(foregroundBrush, penThickness)
    //        };

    //        var drawingGroup = new DrawingGroup { Children = { geometryDrawing } };

    //        return new DrawingImage { Drawing = drawingGroup };
    //    }
    //}

    //public class PackIconModernImageSourceConverter : PackIconImageSourceConverterBase<PackIconModernKind>
    //{
    //    protected override ImageSource CreateImageSource(object value, Brush foregroundBrush, double penThickness)
    //    {
    //        var packIcon = new PackIconModern { Kind = (PackIconModernKind)value };

    //        var geometryDrawing = new GeometryDrawing
    //        {
    //            Geometry = Geometry.Parse(packIcon.Data),
    //            Brush = foregroundBrush,
    //            Pen = new Pen(foregroundBrush, penThickness)
    //        };

    //        var drawingGroup = new DrawingGroup { Children = { geometryDrawing } };

    //        return new DrawingImage { Drawing = drawingGroup };
    //    }
    //}

    //public class PackIconOcticonsImageSourceConverter : PackIconImageSourceConverterBase<PackIconOcticonsKind>
    //{
    //    protected override ImageSource CreateImageSource(object value, Brush foregroundBrush, double penThickness)
    //    {
    //        var packIcon = new PackIconOcticons { Kind = (PackIconOcticonsKind)value };

    //        var geometryDrawing = new GeometryDrawing
    //        {
    //            Geometry = Geometry.Parse(packIcon.Data),
    //            Brush = foregroundBrush,
    //            Pen = new Pen(foregroundBrush, penThickness)
    //        };

    //        var drawingGroup = new DrawingGroup { Children = { geometryDrawing } };

    //        return new DrawingImage { Drawing = drawingGroup };
    //    }
    //}
}
