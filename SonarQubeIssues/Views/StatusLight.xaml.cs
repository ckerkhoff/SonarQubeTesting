using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SonarQubeTesting.Views
{
    /// <summary>
    /// Interaction logic for StatusLight.xaml
    /// </summary>
    public partial class StatusLight : UserControl
    {
        public static readonly DependencyProperty BackgroundColorProperty =
            DependencyProperty.Register(
            "BackgroundColor",
            typeof(Color),
            typeof(StatusLight),
            new PropertyMetadata(Colors.Red, new PropertyChangedCallback(StatusLight.BackgroundColorPropertyChanged)));

        public StatusLight()
        {
            InitializeComponent();

            this.backgroundColor.Color = this.BackgroundColor;
        }

        public Color BackgroundColor
        {
            get
            {
                //return (Color)GetValue(BackgroundColorProperty);
                return (Color)GetValue(BackgroundColorProperty);
            }

            set
            {
                this.SetValue(BackgroundColorProperty, value);
            }
        }

        private static void BackgroundColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            StatusLight led = (StatusLight)d;
            led.backgroundColor.Color = (Color)e.NewValue;
        }
    }
}
