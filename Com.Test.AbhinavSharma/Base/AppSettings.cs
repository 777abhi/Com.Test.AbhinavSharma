using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Com.Test.AbhinavSharma.Base

{
    public class AppSettings
    {
        public string baseUrl { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public IWebDriver driver { get; set; }
     }



}

