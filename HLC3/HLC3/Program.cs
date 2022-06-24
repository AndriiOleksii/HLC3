using HLC3;
using Newtonsoft.Json;
using RestSharp;

string API_SECRET = "jqrVveuIQNWI5p1h6dA7Vw";
string M_ID = "G-ZQPGRQ2YB5";
string CLIENT_ID = "1277594820.1633351942";
string UA_HEADER = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.0.0 Safari/537.36";

// Test logic - тут буде відбуватися виклик до апі/бази, яка має цю інфу
var ratio = 35;

var jsonData = JsonConvert.SerializeObject(new DataModel()
{
    client_id = CLIENT_ID,
    events = new List<DataModelEvent>()
    {
        new DataModelEvent()
        {
            name = "test",
            parameters = new ParamsObject()
            {
                ratio = ratio.ToString()
            }
        }
    }
});

var restClient = new RestSharp.RestClient();

var restCall = new RestSharp.RestRequest($"https://www.google-analytics.com/mp/collect?measurement_id={M_ID}&api_secret={API_SECRET}", 
    Method.Post);

restCall.AddHeader("User-Agent", UA_HEADER);

restCall.AddJsonBody(jsonData);

await restClient.ExecuteAsync(restCall);