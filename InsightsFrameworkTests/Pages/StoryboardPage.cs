using System;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using ArtOfTest.WebAii.Silverlight;


namespace InsightsFrameworkTests.Pages
{
    public class StoryBoardPage : TestBase
    {
        #region Page Objects

        protected static FrameworkElement StoryboardBuilder
        {
            get { return App.Find.ByType("StoryboardExplorer"); }
        }
        public static FrameworkElement StoryboardGroup(string groupName)
        {
            var infoView = StoryboardBuilder.Find.ByTextContent(groupName);
        }

        public static FrameworkElement StoryboardFolder(string groupName, string folderName)
        {
            return null;
        }

        public static FrameworkElement Storyboard(string groupName, string folderName, string storyboardName)
        {
            return null;
        }

        public static FrameworkElement DefaultStoryboard
        {
            get { return null; }
        }
        
       #endregion
        
    }
}
