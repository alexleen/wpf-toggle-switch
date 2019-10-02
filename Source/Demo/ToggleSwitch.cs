using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfToggleSwitch
{
    public class ToggleSwitch : ToggleButton
    {
        public double ButtonWidth
        {
            get => (double)GetValue(ButtonWidthProperty);
            set => SetValue(ButtonWidthProperty, value);
        }

        public static readonly DependencyProperty ButtonWidthProperty = DependencyProperty.Register(nameof(ButtonWidth), typeof(double), typeof(ToggleSwitch), new PropertyMetadata(0.0));

        public string OnLabel
        {
            get => (string)GetValue(OnLabelProperty);
            set => SetValue(OnLabelProperty, value);
        }

        public static readonly DependencyProperty OnLabelProperty = DependencyProperty.Register(nameof(OnLabel), typeof(string), typeof(ToggleSwitch), new PropertyMetadata(string.Empty));

        public string OffLabel
        {
            get => (string)GetValue(OffLabelProperty);
            set => SetValue(OffLabelProperty, value);
        }

        public static readonly DependencyProperty OffLabelProperty = DependencyProperty.Register(nameof(OffLabel), typeof(string), typeof(ToggleSwitch), new PropertyMetadata(string.Empty));
    }
}
