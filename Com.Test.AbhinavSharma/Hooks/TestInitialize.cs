using System;
using System.Configuration;
using TechTalk.SpecFlow;
using Com.Test.AbhinavSharma.Base;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System.Text;
using OpenQA.Selenium.Chrome;
using Com.Test.AbhinavSharma.PageObject;
using Com.Test.AbhinavSharma.Steps;

namespace Com.Test.AbhinavSharma.Hooks
{
    [Binding]
    class TestInitialize
    {

        public Settings _settings;
        TestInitialize(Settings settings) => _settings = settings;

        [BeforeScenario]
        public void TestSetup()
        {
            _settings.indexPage = new IndexPage(_settings);
            _settings.myAccountPage = new MyAccountPage(_settings);

        }

        [AfterScenario]
        public void TestTearDown()
        {
            _settings.configurations.driver.Quit();

        }
    }
}