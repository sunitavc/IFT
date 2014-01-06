using System;
using System.Threading;
using ArtOfTest.WebAii.Silverlight;


namespace InsightsFrameworkTests.Pages
{
    public class SamplesHomePage : TestBase
    {
        #region Page Objects
        protected static FrameworkElement Menu
        {
            get{return App.Find.ByType("Menu");}
        }
        public static FrameworkElement MenuStoryBoard
        {
            get{return Menu.Find.ByTextContent("Storyboard");}
        }

        public static FrameworkElement MenuHome
        {
            get{return Menu.Find.ByTextContent("Home");}
        }

        public static FrameworkElement MenuAnalytics
        {
            get{return Menu.Find.ByTextContent("Analytics");}
        }

        public static FrameworkElement MenuUserProfileSelection
        {
            get{return App.Find.ByTextContent("User scope selection");}
        }
        #endregion

        public static void OpenLandingPage(string path)
        {
            string[] pathStrings = path.Split(new string[] {"->"}, StringSplitOptions.None);
            var uri = String.Concat(SamplesUrl,"/#/", pathStrings[0], "/", "LandingPage/", pathStrings[1], "$Section=", pathStrings[2]);  
            Mgr.ActiveBrowser.NavigateTo(uri);
            Thread.Sleep(500);
            var landingPageHeader = String.Format("Header ={0}", pathStrings[3]);
            var landingPage = App.Find.ByExpression(new XamlFindExpression("XamlTag=Thumbnail", landingPageHeader));
            landingPage.Find.ByExpression(new XamlFindExpression("ButtonText = Open")).User.Click();
        }

        public static void OpenStoryBoard()
        {
            MenuStoryBoard.User.Click();
        }
       
    }

}
