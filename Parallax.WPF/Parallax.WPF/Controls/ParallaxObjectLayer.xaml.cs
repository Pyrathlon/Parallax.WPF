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
    /// Interaction logic for ParallaxObjectLayer.xaml
    /// </summary>
    public partial class ParallaxObjectLayer : ParallaxLayer
    {


        public static readonly DependencyProperty ObjectSourceProperty = DependencyProperty.Register("ObjectSource", typeof(FrameworkElement), typeof(ParallaxObjectLayer), new PropertyMetadata(null));
        public FrameworkElement ObjectSource { get => (FrameworkElement)GetValue(ObjectSourceProperty); set => SetValue(ObjectSourceProperty, value); }





        public ParallaxObjectLayer()
        {
            InitializeComponent();
        }
    }
}
