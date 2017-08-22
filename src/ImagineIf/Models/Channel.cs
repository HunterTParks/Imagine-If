using Discord.Net.Rest;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImagineIf.Models
{
    public class Channel
    {
        public int id { get; set; }
        public int type { get; set; }
        public int guild_id { get; set; }
        public int Position { get; set; }
        public List<Overwrite> Permission_Overwrites { get; set; }
        public string name { get; set; }
        public string Topic { get; set; }
        public int Bitrate { get; set; }
        public int User_Limit { get; set; }
        public List<ApplicationUser> Recipients { get; set; }
        public string Icon { get; set; }
        public int Owner_Id { get; set; }
        public int Application_Id { get; set; }

        public static List<DiscordMessage> GetMessages()
        {
            var client = new RestClient("https://discordapp.com/api/v6");
            var request = new RestRequest("/channels/348697779436126209/messages");
            client.Authenticator = new HttpBasicAuthenticator("349610917966905345", "Ho_POj-p6Ex-cCLZW-f3NxDg9bDqKZvJ");
            var response = new RestSharp.RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestSharp.RestResponse;
            }).Wait();

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var messageList = JsonConvert.DeserializeObject<List<DiscordMessage>>(jsonResponse["messages"].ToString());
            return messageList;
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}
