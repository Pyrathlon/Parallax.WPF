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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parallax.WPF.Controls.Container
{
    /// <summary>
    /// Interaction logic for ScrollParallaxContainer.xaml
    /// </summary>
    public partial class ScrollParallaxContainer : UserControl
    {

        DoubleAnimation verticalAnimation = new DoubleAnimation();
        bool isScrolling = false;
        Point oldMousePosition;





        public ScrollParallaxContainer()
        {
            InitializeComponent();
            Scroller.ScrollChanged += scrollChanged;
            verticalAnimation.Completed += ScrollFinished;
                verticalAnimation.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 200));

        }

        private void ScrollFinished(object sender, EventArgs e)
        {
            
                isScrolling = false;
            
        }

        private void scrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (isScrolling)
                return;
           
            Console.WriteLine(e.VerticalOffset);
            e.Handled = true;
           
            lmao.Offset = (Scroller.ScrollableHeight / e.VerticalOffset) ;

            verticalAnimation.From = Scroller.VerticalOffset;
            verticalAnimation.To = Scroller.VerticalOffset  +20;
          
        }

        private void sp_MouseMove(object sender, MouseEventArgs e)
        {
            Point newMousePosition = Mouse.GetPosition((StackPanel)sender);
            
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                if (newMousePosition.Y < oldMousePosition.Y)
                   Scroller.ScrollToVerticalOffset(Scroller.VerticalOffset + 1);
                if (newMousePosition.Y > oldMousePosition.Y)
                   Scroller.ScrollToVerticalOffset(Scroller.VerticalOffset - 1);

                if (newMousePosition.X < oldMousePosition.X)
                   Scroller.ScrollToHorizontalOffset(Scroller.HorizontalOffset + 1);
                if (newMousePosition.X > oldMousePosition.X)
                   Scroller.ScrollToHorizontalOffset(Scroller.HorizontalOffset - 1);
            }
            else
            {
                 oldMousePosition = newMousePosition;
            }
        }
    }
}
