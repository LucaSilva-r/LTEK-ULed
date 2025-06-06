using Avalonia;
using Avalonia.Controls;
using Avalonia.Data.Core;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Media;
using LTEK_ULed.Code;
using LTEK_ULed.Converters;
using System;

namespace LTEK_ULed.Controls;

public partial class SegmentSettings : UserControl
{
    private Segment? segment;
    public SegmentSettings()
    {
        InitializeComponent();
    }
    
    public static readonly StyledProperty<string> SegmentNameProperty =
        AvaloniaProperty.Register<SegmentView, string>(nameof(SegmentName), defaultValue: "Segment Name", defaultBindingMode: Avalonia.Data.BindingMode.TwoWay);

    public string SegmentName
    {
        get => GetValue(SegmentNameProperty);
        set => SetValue(SegmentNameProperty, value);
    }

    public static readonly StyledProperty<int> SegmentLengthProperty =
        AvaloniaProperty.Register<SegmentView, int>(nameof(SegmentLength), defaultBindingMode: Avalonia.Data.BindingMode.TwoWay);

    public int SegmentLength
    {
        get => GetValue(SegmentLengthProperty);
        set => SetValue(SegmentLengthProperty, value);
    }

    private void ContextMenu_Closed(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
    }
}