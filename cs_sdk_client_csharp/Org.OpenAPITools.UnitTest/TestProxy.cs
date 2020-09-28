using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            proxy.Configuration.AccessToken = "Token " + (string)authResponse["key"];
            //proxy.Configuration.AccessToken = "Token 0595158830857aafd0b1ff8f10fab6e498c37259";
            proxy.Configuration.Username = "Administrator";            

            var usrDetail = proxy.RestAuthUserGET();
            Assert.IsNotNull(usrDetail);
        }
    }
}
