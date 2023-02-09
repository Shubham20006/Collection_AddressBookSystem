using AddressBookSystem;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTest
{
    public class RestSharpAddressBookTest
    {

        [TestClass]
        public class RestSharpTestCase
        {
            RestClient client;

            [TestInitialize]
            public void Setup()
            {
                client = new RestClient("http://localhost:4000");

            }

            private IRestResponse getEmployeeList()
            {
                RestRequest request = new RestRequest("/Contacts", Method.GET);

                IRestResponse response = client.Execute(request);
                return response;
            }

            [TestMethod]
            public void onCallingGetAi_ReturnEmployeeList()
            {
                IRestResponse response = getEmployeeList();

                Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
                List<AddressModel> dataresponse = JsonConvert.DeserializeObject<List<AddressModel>>(response.Content);

                Assert.AreEqual(7, dataresponse.Count);
            }

            [TestMethod]
            public void givenEmployee_OnPost_ShouldReturnAddEmployee()
            {AddressModel ad=new AddressModel();
                RestRequest request = new RestRequest("/Contacts", Method.POST);
                System.Text.Json.Nodes.JsonObject jsonObject = new System.Text.Json.Nodes.JsonObject();

              
                jsonObject.Add("FirstName", "shivani");
                jsonObject.Add("LastName" , "jadhav");
                jsonObject.Add("Address" , "95 street");
                jsonObject.Add("City" ,"nagar");
                jsonObject.Add("State" , "MP");
                jsonObject.Add("zip" ,"86525");
                jsonObject.Add("PhoneNum" ,"7456892564");
                jsonObject.Add("Email" , "Shivani458@gmail.com");
                jsonObject.Add("Type" ,"Friends");
                jsonObject.Add("Date " , "11/08/2021");

                request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.Created);

                AddressModel dataresponse = JsonConvert.DeserializeObject<AddressModel>(response.Content);

                Assert.AreEqual("shivani", dataresponse.FirstName);
                Assert.AreEqual("MP", dataresponse.State);

                Console.WriteLine(response.Content);
            }

            [TestMethod]
            public void deleteEmployee()
            {
                RestRequest request = new RestRequest("/Contacts/6", Method.DELETE);

                IRestResponse response = client.Execute(request);

                Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
                Console.WriteLine(response.Content);
            }

            [TestMethod]
            public void givenEmployee_OnPut_ShouldReturnAddEmployee()
            {
                RestRequest request = new RestRequest("/Contacts/1", Method.PUT);
                System.Text.Json.Nodes.JsonObject jsonObject = new System.Text.Json.Nodes.JsonObject();

                jsonObject.Add("FirstName", "shubham");
                jsonObject.Add("City", "Nanded");

                request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);

                AddressModel dataresponse = JsonConvert.DeserializeObject<AddressModel>(response.Content);

                Assert.AreEqual("shubham", dataresponse.FirstName);
                Assert.AreEqual("Nanded", dataresponse.City);

                Console.WriteLine(response.Content);
            }
        }
    }
}
