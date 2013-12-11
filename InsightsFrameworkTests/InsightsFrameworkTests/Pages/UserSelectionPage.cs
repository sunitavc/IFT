using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using ArtOfTest.WebAii.TestTemplates;

namespace InsightsFrameworkTests.Pages
{
    public class UserSelectionPage : TestBase
    {
        public static void UserScopeSelection(String username, String dataset, String profile)
        {
            userScopeSelectionLink.User.Click();
            User(username).User.Click();
            Dataset(dataset).User.Click();
            Profile(profile).User.Click();
        }

        private static FrameworkElement userScopeSelectionLink = App.Find.ByTextContent("User scope selection");
        private static FrameworkElement User(string username)
        {
            App.Find.ByType("Popup");
            IList<FrameworkElement> comboboxes = App.Find.AllByType("ComboBox"); ;
            comboboxes[0].User.Click();
            return App.Find.ByTextContent(username);
        }
        private static FrameworkElement Dataset(string dataset)
        {
            App.Find.ByType("Popup");
            IList<FrameworkElement> comboboxes = App.Find.AllByType("ComboBox");
            comboboxes[1].User.Click();
            return App.Find.ByTextContent(dataset);
        }
        private static FrameworkElement Profile(string profile)
        {
            App.Find.ByType("Popup");
            IList<FrameworkElement> comboboxes = App.Find.AllByType("ComboBox");
            comboboxes[2].User.Click();
            return App.Find.ByTextContent(profile);
        }
    }
}
