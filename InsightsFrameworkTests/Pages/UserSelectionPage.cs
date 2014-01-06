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
        private static FrameworkElement UserScopeOk
        {
            get{return App.Find.ByName("OKButton");}
        }

        private static FrameworkElement UserScopeCancel
        {
            get{return App.Find.ByName("CancelButton");}
        }

        public static void UserScopeSelection(String username, String dataset, String profile)
        {
            SamplesHomePage.MenuUserProfileSelection.User.Click();
            User(username).User.Click();
            Dataset(dataset).User.Click();
            Profile(profile).User.Click();
            UserScopeOk.User.Click();
        }
        
        private static FrameworkElement User(string username)
        {
            var popup = App.Find.ByType("UserScopeSelectionDialog");
            IList<FrameworkElement> comboboxes = popup.Find.AllByType("ComboBox"); ;
            comboboxes[0].User.Click();
            return App.Find.ByTextContent(username);
        }
        private static FrameworkElement Dataset(string dataset)
        {
            var popup = App.Find.ByType("UserScopeSelectionDialog");
            IList<FrameworkElement> comboboxes = popup.Find.AllByType("ComboBox"); ;
            comboboxes[1].User.Click();
            return App.Find.ByTextContent(dataset);
        }
        private static FrameworkElement Profile(string profile)
        {
            var popup = App.Find.ByType("UserScopeSelectionDialog");
            IList<FrameworkElement> comboboxes = popup.Find.AllByType("ComboBox"); ;
            comboboxes[2].User.Click();
            return App.Find.ByTextContent(profile);
        }
    }
}
