using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.TestTemplates;
using NUnit.Framework;
using TechTalk.SpecFlow;


namespace InsightsFrameworkTests
{
    [Binding]
    public class TestBase : BaseTest
    {
        protected internal const string AppUrl = "http://insightsframework-sandbox.pko.mckinsey.com";
        private static Settings _settings = new Settings();

        protected static internal Manager Mgr
        {
            get;
            private set;
        }
        protected static internal SilverlightApp App
        {
            get;
            set;
        }

        [BeforeFeature]
        public static void BeforeScenario()
        {
            // TODO Need to load these settings from an external config file..this is BAD!
            _settings.Web.EnableSilverlight = true;
            _settings.Web.DefaultBrowser = BrowserType.InternetExplorer;
            _settings.ClientReadyTimeout = 120000;
            _settings.ElementWaitTimeout = 120000;
            _settings.ExecuteCommandTimeout = 30000;
            
            // Launch the application
            Mgr = new Manager(_settings);
            Mgr.Start();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Mgr.ActiveBrowser.Close();
            CleanUp();
        }
    }
}
