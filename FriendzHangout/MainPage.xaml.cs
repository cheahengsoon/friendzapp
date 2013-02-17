using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace FriendzHangout
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : FriendzHangout.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            DateTime value = new DateTime();
            greetingOutput.Text = "You have planned " + eventInput.Text + " at " + placeInput.Text + ". Showing below possible means of reaching there ! \n\n" + DateTime.Now;
            bustimings.Text = "\n Bus  55K \n Kumpula \n Coming in " + DateTime.Now.Millisecond / 30 + "  minutes.  *May be delayed due to snow !";
            trainTimings.Text = "\n Train K \n Kerava \n Coming in " + DateTime.Now.Millisecond / 20 + " minutes. * Recomended Route !";
            metroTimings.Text = "\n Metro  \n Ruholahti \n Coming in " + DateTime.Now.Millisecond / 10 + " minutes.";
        }

        private void busTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            trainTimings.Text = "";
            metroTimings.Text = "";

            

        }

        private void trainTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            bustimings.Text = trainTimings.Text;
            trainTimings.Text = "";
            metroTimings.Text = "";

        }

        private void metroTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            bustimings.Text = metroTimings.Text;
            trainTimings.Text = "";
            metroTimings.Text = "";
        }
    }
}
