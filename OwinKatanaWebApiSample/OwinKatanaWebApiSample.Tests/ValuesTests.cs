using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Owin.Testing;
using System.Collections.Generic;
using System.Net;

namespace OwinKatanaWebApiSample.Tests
{
    [TestClass]
    public class ValuesTests
    {
        [TestMethod]
        public void TestMethod1()
       { 
            var server = TestServer.Create<StartUp>();
            var response = server.HttpClient.GetAsync("/values").Result;
            var result = response.Content.ReadAsStreamAsync().Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
