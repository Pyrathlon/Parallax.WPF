using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parallax.WPF.Controls
{
    /// <summary>
    /// Interaction logic for ParallaxImageLayer.xaml
    /// </summary>
    public partial class ParallaxImageLayer : Base.ParallaxLayer
    {
        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(ParallaxImageLayer), new PropertyMetadata(null));
        public ImageSource ImageSource { get => (ImageSource)GetValue(ImageSourceProperty); set => SetValue(ImageSourceProperty, value); }

        public ParallaxImageLayer()
        {
            InitializeComponent();
        }
    }
}
