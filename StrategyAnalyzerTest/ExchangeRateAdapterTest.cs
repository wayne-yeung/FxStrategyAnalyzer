﻿using FXStrategy.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FXEntities;
using System.Collections.Generic;

namespace StrategyAnalyzerTest
{
    
    
    /// <summary>
    ///This is a test class for ExchangeRateAdapterTest and is intended
    ///to contain all ExchangeRateAdapterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ExchangeRateAdapterTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetExchangeRates
        ///</summary>
        //[TestMethod()]
        //public void GetExchangeRatesTest()
        //{
        //    FXEntities.FXEntities fxEntities = new FXEntities.FXEntities(); // TODO: Initialize to an appropriate value
        //    ExchangeRateAdapter target = new ExchangeRateAdapter(fxEntities); // TODO: Initialize to an appropriate value
        //    string baseCurrencyCode = "SEK";
        //    string variableCurrencyCode = "USD"; 
        //    var actual = target.GetExchangeRates(baseCurrencyCode, variableCurrencyCode);
        //}
    }
}