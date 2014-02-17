﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Demo.TestModel;
using Swd.Core.Pages;

namespace Demo.TestProject.Smoke
{
    [TestClass]
    public class Smoke_test_for_each_pageobject
    {

        public void PageTest<PAGE>(PAGE page) where PAGE : MyPageBase, new()
        {
            // Implement Dispose inside page object in order to do cleanup
            using (page)
            {
                page.Invoke();
                page.VerifyExpectedElementsAreDisplayed();
            }
        }

        
        // Add testMethods for your new pages here:
        // *PageName*_VerifyExpectedElements()

        [TestMethod]
        public void TwitterLoginPage_VerifyExpectedElements()
        {
            PageTest(MyPages.TwitterLoginPage);
        }

        [TestMethod]
        public void TwitterMainPage_VerifyExpectedElements()
        {
            PageTest(MyPages.TwitterMainPage);
        }

        [TestMethod]
        public void TwitterAccountPage_VerifyExpectedElements()
        {
            PageTest(MyPages.TwitterAccountPage);
        }


    }
}
