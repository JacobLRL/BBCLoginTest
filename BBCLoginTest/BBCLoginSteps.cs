using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace BBCLoginTest
{
    [Binding]
    public class BBCLoginSteps
    {
        [Given]
        public void Given_I_am_on_the_login_page()
        {
            WebBrowser.Current.GoTo("https://account.bbc.com/signin");
        }
        
        [When]
        public void When_I_enter_incorrect_credentials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_I_should_see_the_appropriate_error()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
