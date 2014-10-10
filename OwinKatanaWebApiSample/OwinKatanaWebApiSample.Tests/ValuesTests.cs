using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Owin.Testing;
using System.Collections.Generic;
using System.Net;

namespace OwinKatanaWebApiSample.Tests
{
    [TestClass]
    public class ValuesTests
    {
        TestServer _server;

        [TestInitialize]
        public void SetUp()
        {
            _server = TestServer.Create<StartUp>();
        }

        [TestMethod]
        public void Values_Get()
       { 
            var response = _server.HttpClient.GetAsync("/values").Result;
            var result = response.Content.ReadAsStringAsync().Result;

            var values = JsonHelper.JsonDeserialize<IEnumerable<string>>(result);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(2, values.ToList().Count);
        }

        [TestMethod]
        public void Values_Get_by_id()
        {
            var response = _server.HttpClient.GetAsync("/values/123").Result;
            var result = response.Content.ReadAsStringAsync().Result;

            var value = JsonHelper.JsonDeserialize<string>(result);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(value.Contains("123"));
        }
    }
}
