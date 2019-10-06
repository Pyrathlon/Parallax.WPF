using Parallax.WPF.Controls.Base;
using Parallax.WPF.Enum;
using Parallax.WPF.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

    public partial class MouseAwareParallaxContainer : Base.ParallaxContainer
    {

        private FrameworkElement MouseMoveTarget;
        public MouseAwareParallaxContainer()
        {
            InitializeComponent();
            this.Layers = new ObservableCollection<ParallaxLayer>();
            this.LayoutUpdated += LayoutUpdatedHandler; 
        }

        private void LayoutUpdatedHandler(object sender, EventArgs e)
        {            
            if (HookOnParent && ParentElement != null)
            {
                MouseMoveTarget = ParentElement;
            }
            else
            {
                MouseMoveTarget = this;
            }
            MouseMoveTarget.MouseMove += MouseMoveHandler;
            this.LayoutUpdated -= LayoutUpdatedHandler;
        }

        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (!isActive)
                return;

            Point mouse = e.GetPosition(MouseMoveTarget);
            foreach (Base.ParallaxLayer layer in Layers)
            {

                if (!layer.isActive)
                    return;

                double xoffset = layer.HorizontalWeight * Constants.WEIGHTCONSTANT;
                double yoffset = layer.VerticalWeight * Constants.WEIGHTCONSTANT;

                double newX = 0;
                double newY = 0;

                if (layer.MouseTargetBehaviour == MouseTargetBehaviourEnum.Leave)
                {
                    newX = layer.ActualHeight - ((mouse.X / xoffset)) - layer.ActualHeight;
                    newY = layer.ActualWidth - ((mouse.Y / yoffset)) - layer.ActualWidth;
                }

                if (layer.MouseTargetBehaviour == MouseTargetBehaviourEnum.Follow)
                {
                    newX = layer.ActualHeight - ((mouse.X / -xoffset)) - layer.ActualHeight;
                    newY = layer.ActualWidth - ((mouse.Y / -yoffset)) - layer.ActualWidth;
                }


                if (!(layer.RenderTransform is TranslateTransform))
                    layer.RenderTransform = new TranslateTransform(newX, newY);
                else
                {
                    TranslateTransform transform = (TranslateTransform)layer.RenderTransform;
                    if (layer.MouseAwareness == MouseAwarenessEnum.Horizontal | layer.MouseAwareness == MouseAwarenessEnum.Both)
                        transform.X = newX;
                    if (layer.MouseAwareness == MouseAwarenessEnum.Vertical | layer.MouseAwareness == MouseAwarenessEnum.Both)
                        transform.Y = newY;
                }



            }



        }
    }
}
