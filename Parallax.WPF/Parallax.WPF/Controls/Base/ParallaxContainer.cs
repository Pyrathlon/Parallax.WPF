using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Parallax.WPF.Controls.Base
{
    public class ParallaxContainer : UserControl
    {
        public static readonly DependencyProperty isActiveProperty = DependencyProperty.Register("isActive", typeof(bool), typeof(ParallaxContainer), new PropertyMetadata(true));
        public bool isActive { get => (bool)GetValue(isActiveProperty); set => SetValue(isActiveProperty, value); }

        public static readonly DependencyProperty LayersProperty = DependencyProperty.Register("Layers", typeof(ObservableCollection<ParallaxLayer>), typeof(ParallaxContainer), new PropertyMetadata(new ObservableCollection<ParallaxLayer>()));
        public ObservableCollection<ParallaxLayer> Layers { get => (ObservableCollection<ParallaxLayer>)GetValue(LayersProperty); set => SetValue(LayersProperty, value); }

    }
}
