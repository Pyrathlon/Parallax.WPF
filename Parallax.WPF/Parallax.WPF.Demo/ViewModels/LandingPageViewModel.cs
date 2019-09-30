using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;


namespace Parallax.WPF.Demo.ViewModels
{
   public class LandingPageViewModel
    {


        private ResourceDictionary availableBackgroundsResourceDictionary;
        private ObservableCollection<BitmapImage> availableBackgroundImages;
        public   LandingPageViewModel()
        {
            availableBackgroundsResourceDictionary.Source = new Uri("/Static/StaticImages.xaml");

            availableBackgroundImages.Add(availableBackgroundsResourceDictionary.OfType<BitmapImage>().FirstOrDefault());
            MessageBox.Show((availableBackgroundImages.Count).ToString(), "");


        }

    }
}
