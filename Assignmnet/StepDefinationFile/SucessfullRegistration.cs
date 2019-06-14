using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Assignmnet.StepDefinationFile
{
    [Binding]
    public class CheckingApiResponseSteps
    {
        RestClient client;
        RestRequest request;
        [Given(@"We use client and request")]
        public void GivenWeUseClientAndRequest()
        {
            client = new RestClient("https://reqres.in/.");
            request = new RestRequest("/api/register", Method.POST);
        }
        
        [Given(@"Add Parameter")]
        public void GivenAddParameter()
        {
            request.AddParameter("email", "eve.holt@reqres.in");
            request.AddParameter("password", "pistol");
        }
        
        [When(@"Get the Response")]
        public void WhenGetTheResponse()
        {
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
            Deser deserializedProduct = JsonConvert.DeserializeObject<Deser>(content);

            Assert.AreEqual(deserializedProduct.error, "Missing password");

            Console.ReadLine();
        }
        
        [Then(@"Generate the token")]
        public void ThenGenerateTheToken()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
