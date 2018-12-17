using MemoryGame.ViewModels;
using System;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit.Input;
using Microsoft.Kinect.Wpf.Controls;
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

namespace MemoryGame.Views
{
    /// <summary>
    /// Interaction logic for StartMenuView.xaml
    /// </summary>
    public partial class StartMenuView : UserControl
    {

        public StartMenuView()
        {
            InitializeComponent();
            KinectRegion.SetKinectRegion(this, KinectRegionXAML);
            KinectRegionXAML.Loaded += KinectRegionXAML_Loaded;
            KinectRegionXAML.KinectSensor = KinectSensor.GetDefault();
            KinectRegionXAML.KinectSensor.Open();
        }

        private void Play_Clicked_Easy(object sender, RoutedEventArgs e)
        {
            var startMenu = DataContext as StartMenuViewModel;
            startMenu.StartNewGame(4);
        }
        private void Play_Clicked_Medium(object sender, RoutedEventArgs e)
        {
            var startMenu = DataContext as StartMenuViewModel;
            startMenu.StartNewGame(5);
        }
        private void Play_Clicked_Hard(object sender, RoutedEventArgs e)
        {
            var startMenu = DataContext as StartMenuViewModel;
            startMenu.StartNewGame(6);
        }
        private void KinectRegionXAML_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Kinect Loaded");
        }
    }
}
