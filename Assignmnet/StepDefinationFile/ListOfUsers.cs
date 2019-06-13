using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Assignmnet.StepDefinationFile
{
    [Binding]
    public class TakingTheListOfUserSteps
    {
        RestClient client;
        RestRequest request;
        [Given(@"We initiate the reuest and response")]
        public void GivenWeInitiateTheReuestAndResponse()
        {
            client = new RestClient("https://reqres.in/.");
            request = new RestRequest("/api/users?page=2", Method.GET);
        }
        
        [When(@"Get the corresponding Rsponse")]
        public void WhenGetTheCorrespondingRsponse()
        {
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
            Deser deserializedProduct = JsonConvert.DeserializeObject<Deser>(content);
            Console.WriteLine("id : {0}", deserializedProduct.id);
            Console.WriteLine("token : {0}", deserializedProduct.token);
            Console.ReadLine();
        }
        
        [Then(@"Generate the tokens")]
        public void ThenGenerateTheTokens()
        {
           //
        }
    }
}
