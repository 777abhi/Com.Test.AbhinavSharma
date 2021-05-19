using Com.Test.AbhinavSharma.PageObject;
using Com.Test.AbhinavSharma.Steps;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Com.Test.AbhinavSharma.Base

{
    public class Settings
    {
        public AppSettings configurations { get; set; }
        public IndexPage indexPage;
        public MyAccountPage myAccountPage;

        

        Settings()
        {
            //Read settings from JSON file and parse to class object 
            using (StreamReader r = new StreamReader("appSettings.json"))
            {
                string json = r.ReadToEnd();
                configurations = JsonConvert.DeserializeObject<AppSettings>(json);
            }

            configurations.driver = new ChromeDriver();
            configurations.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
            configurations.driver.Manage().Window.Maximize();
        }

    }
}

