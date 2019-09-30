using Parallax.WPF.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Parallax.WPF.Controls.Base
{
    public class ParallaxLayer : UserControl
    {
        public static readonly DependencyProperty isActiveProperty = DependencyProperty.Register("isActive", typeof(bool), typeof(ParallaxLayer), new PropertyMetadata(true));
        public bool isActive { get => (bool)GetValue(isActiveProperty); set => SetValue(isActiveProperty, value); }

        public static readonly DependencyProperty HorizontalWeightProperty = DependencyProperty.Register("HorizontalWeight", typeof(int), typeof(ParallaxLayer), new PropertyMetadata(100));
        public int HorizontalWeight { get => (int)GetValue(HorizontalWeightProperty); set => SetValue(HorizontalWeightProperty, value); }

        public static readonly DependencyProperty VerticalWeightProperty = DependencyProperty.Register("VerticalWeight", typeof(int), typeof(ParallaxLayer), new PropertyMetadata(100));
        public int VerticalWeight { get => (int)GetValue(VerticalWeightProperty); set => SetValue(VerticalWeightProperty, value); }

        public static readonly DependencyProperty MouseAwarenessProperty = DependencyProperty.Register("MouseAwareness", typeof(MouseAwarenessEnum), typeof(ParallaxLayer), new PropertyMetadata(MouseAwarenessEnum.Both));
        public MouseAwarenessEnum MouseAwareness { get => (MouseAwarenessEnum)GetValue(MouseAwarenessProperty); set => SetValue(MouseAwarenessProperty, value); }

        public static readonly DependencyProperty MouseTargetBehaviourProperty = DependencyProperty.Register("MouseTargetBehaviour", typeof(MouseTargetBehaviourEnum), typeof(ParallaxLayer), new PropertyMetadata(MouseTargetBehaviourEnum.Leave));
        public MouseTargetBehaviourEnum MouseTargetBehaviour { get => (MouseTargetBehaviourEnum)GetValue(MouseTargetBehaviourProperty); set => SetValue(MouseTargetBehaviourProperty, value); }

    }
}
