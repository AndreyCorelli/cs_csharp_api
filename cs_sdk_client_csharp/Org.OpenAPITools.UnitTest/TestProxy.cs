using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.UnitTest
{
    [TestFixture]
    public class TestProxy
    {
        [Test]
        public void TestConnection()
        {
            var conf = new Client.Configuration(
                new Dictionary<string, string>(),
                new Dictionary<string, string>(),
                new Dictionary<string, string>(),
                "https://dev.contraxsuite.com");
            var proxy = new DefaultApi(conf);
            var appVars = proxy.CommonAppVariablesGET();
            Assert.IsNotNull(appVars);
        }

        [Test]
        public void TestAuth()
        {
            var conf = new Client.Configuration(
                new Dictionary<string, string>(),
                new Dictionary<string, string>(),
                new Dictionary<string, string>(),
                "https://dev.contraxsuite.com");
            var proxy = new DefaultApi(conf);
            var usrData = new InlineObject70("Administrator", // user
                "developers-dev@lexpredict.com", // email
                "Administrator"); // password
            var resp = proxy.RestAuthLoginPOST(usrData) as JObject;
            var authResponse = resp.ToObject<Dictionary<string, object>>();
            Assert.IsNotNull(resp);
            var apiKey = (string)authResponse["key"];
            var apiToken = $"Token {apiKey}";
            //proxy.Configuration.AccessToken = apiToken;
            proxy.Configuration.ApiKey["Authorization"] = apiToken;

            var projects = proxy.ProjectProjectsRecentGET();
            Assert.IsNotNull(projects);
        }
    }
}
