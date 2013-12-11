using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.TestTemplates;
using InsightsFrameworkTests.Pages;
using TechTalk.SpecFlow;

namespace InsightsFrameworkTests.Step_Definitions
{
    [Binding]
    public class InsightsFrameworkNavigationSteps : TestBase
    {
        [Given(@"I am logged in to Insights Framework as a developer")]
        [Given(@"a developer ""(.*)"" with a dataset ""(.*)"" with profile ""(.*)""")]
        public void SelectUserProfile(string user, string dataset, string profile)
        {
            Mgr.LaunchNewBrowser();
            Mgr.ActiveBrowser.Window.Maximize();
            Mgr.ActiveBrowser.NavigateTo(AppUrl);
            //Wait since it takes a while to load Insights
            System.Threading.Thread.Sleep(20000);
            App = Mgr.ActiveBrowser.SilverlightApps()[0];
            UserSelectionPage.UserScopeSelection(user, dataset, profile);
        }

    [When(@"I navigate to ""(.*)"" Landing Page")]
        public void NavigateToLandingPage(string navigationPath)
    {
        InsightsFrameworkMenuPage.navigateToLandingPage(navigationPath);

    }

}
