using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.TestTemplates;
using NUnit.Framework;
using TechTalk.SpecFlow;


namespace InsightsFrameworkTests
{
    [Binding]
    [TestFixture]
    public abstract class TestBase : BaseTest
    {
        #region Members

        protected internal static string SamplesUrl
        {
            get { return Setting.Web.BaseUrl; }
        }

        protected internal static string PublisherUrl
        {
            get { return SamplesUrl + "/Publisher.aspx?UserId=IFUserId&DataSet=Umbrella Corp&Profile=Development"; }
        }

        protected static internal Settings Setting
        {
            get{return GetSettings();}
        }
        protected static internal Manager Mgr
        {
            get;
            private set;
        }
        protected static internal SilverlightApp App
        {
            get;
            private set;
        }
        #endregion

        # region Setup/Teardown
        [BeforeFeature]
        [TestFixtureSetUp]
        public static void BeforeScenario()
        {
            Mgr = new Manager(Setting);
            Mgr.Start();
        }

        [AfterScenario]
        [TearDown]
        public void AfterScenario()
        {
           CleanUp();
           Mgr.ActiveBrowser.Close();
        }

        [TestFixtureTearDown]
        public void TestBaseFixtureTearDown()
        {
            ShutDown();
        }
        #endregion

        #region cleanup
        public new void CleanUp()
        {
            //  
            // Place any additional cleanup here  
            //  
            if (TestContext.CurrentContext.Result.Status == TestStatus.Failed)
            {
                Mgr.Log.WriteLine("Failed Step: " + TestContext.CurrentContext.Test.FullName);
                Mgr.Log.CaptureBrowser(Mgr.ActiveBrowser, TestContext.CurrentContext.Test.FullName);
            }
                
            #region WebAii CleanUp
            // Shuts down WebAii manager and closes all browsers currently running  
            // after each test. This call is ignored if recycleBrowser is set  
            base.CleanUp();
            #endregion
        }
        #endregion

        #region Helper methods

        public void LoadSamples()
        {
            Mgr.LaunchNewBrowser();
            Mgr.ActiveBrowser.NavigateTo(Setting.Web.BaseUrl);
            Mgr.ActiveBrowser.Window.Maximize();
            App = Mgr.ActiveBrowser.SilverlightApps()[0];
        }

        public void LoadPublisher()
        {
            Mgr.LaunchNewBrowser();
            Mgr.ActiveBrowser.NavigateTo(PublisherUrl);
            Mgr.ActiveBrowser.Window.Maximize();
            App = Mgr.ActiveBrowser.SilverlightApps()[0];
        }

        #endregion

    }


}
