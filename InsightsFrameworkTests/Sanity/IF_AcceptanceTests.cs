using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Controls.Xaml;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.TestTemplates;
using NUnit.Framework;
using InsightsFrameworkTests.Pages;

namespace InsightsFrameworkTests.Sanity
{
    [TestFixture]
    class UiAcceptanceTests :TestBase
    {
        [Test]
        public void VerifySampleLoads()
        {
            LoadSamples();
            Assert.IsNotNull(SamplesHomePage.MenuHome, "Home menu item not displayed");
            Assert.IsNotNull(SamplesHomePage.MenuStoryBoard, "Storyboard menu item not displayed");
            Assert.IsNotNull(SamplesHomePage.MenuAnalytics, "Analytics menu item not displayed");
            Assert.IsNotNull(SamplesHomePage.MenuUserProfileSelection, "User Profile menu item not displayed");
        }

        [Test]
        public void VerifyPublisherLoads()
        {
            LoadPublisher();
            Assert.IsNotNull(PublisherHomePage.MenuHome, "Home menu item not displayed");
            Assert.IsNotNull(PublisherHomePage.MenuPublisher, "Publisher menu item not displayed");
        }

        [Test]
        public void VerifyStoryBoardLoads()
        {
            LoadSamples();
            SamplesHomePage.OpenStoryBoard();
        }
        
    }
}
