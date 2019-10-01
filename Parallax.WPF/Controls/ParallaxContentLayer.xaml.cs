using Parallax.WPF.Controls.Base;
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
    /// Interaction logic for ParallaxContentLayer.xaml
    /// </summary>
    public partial class ParallaxContentLayer : ParallaxLayer
    {


        public static readonly DependencyProperty ContentSourceProperty = DependencyProperty.Register("ContentSource", typeof(FrameworkElement), typeof(ParallaxContentLayer), new PropertyMetadata(null));
        public FrameworkElement ContentSource { get => (FrameworkElement)GetValue(ContentSourceProperty); set => SetValue(ContentSourceProperty, value); }





        public ParallaxContentLayer()
        {
            InitializeComponent();
        }
    }
}
