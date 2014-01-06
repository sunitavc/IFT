using System;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using ArtOfTest.WebAii.Silverlight;


namespace InsightsFrameworkTests.Pages
{
    public class PublisherHomePage : TestBase
    {
        #region Page Objects

        protected static FrameworkElement Menu
        {
            get { return App.Find.ByType("Menu"); }
        }

        public static FrameworkElement MenuHome
        {
            get { return Menu.Find.ByTextContent("Home"); }
        }

        public static FrameworkElement MenuPublisher
        {
            get { return Menu.Find.ByTextContent("Publisher"); }
        }

        #endregion

        public void OpenPageDefinitions()
        {
            var uri = PublisherUrl + "/Publisher/PageDefinitions";
            Mgr.ActiveBrowser.NavigateTo(uri);
        }

        public void OpenPublicLandingPageBuilder()
        {
            var uri = PublisherUrl + "/Publisher/Landingpages/LandingpageBuilder";
            Mgr.ActiveBrowser.NavigateTo(uri);
        }

        public void OpenPrivateLandingPageBuilder()
        {
            var uri = PublisherUrl + "/Publisher/Landingpages/PrivateLandingpageBuilder";
            Mgr.ActiveBrowser.NavigateTo(uri);
        }

        public void OpenAssignLandingPages()
        {
            var uri = PublisherUrl + "/Publisher/Landingpages/LandingpageAssigner";
            Mgr.ActiveBrowser.NavigateTo(uri);
        }

        public void OpenConfigureLandingPage()
        {
            var uri = PublisherUrl + "/Publisher/Landingpages/LandingpageConfigurator";
            Mgr.ActiveBrowser.NavigateTo(uri);
        }

    }
}
