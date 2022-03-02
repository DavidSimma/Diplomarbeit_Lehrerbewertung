using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Diplomarbeit.Models.db
{
    public class Repository_API : IRepository_API
    {

        public static HttpClient _client = new HttpClient();
        private static string server = "10.10.208.224";
        private static string port = "5000";

        public async Task<Formular> GetFormularByID(string id)              //Geht
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":"+ port + "/api/fragen/" + id);

            if (response.IsSuccessStatusCode)
            {

                string responseJSON = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Formular>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Formular>> GetAllFormular()          //Geht
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server +":"+ port +"/api/fragen");

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();
                responseJSON = "["+ responseJSON +"]";

                return JsonConvert.DeserializeObject<List<Formular>>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> SendFilledData(Formular formular)       //geht
        {
            var json = JsonConvert.SerializeObject(formular);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://" + server + ":" + port + "/api/fragen/post";

            var response2 = await _client.PostAsync(url, data);
            if (response2.Content.ReadAsStringAsync().Result.Equals("1"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Feedback>> GetAllFeedback()          // Geht
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":"+ port +"/api/feedback");

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();
                responseJSON = "[" + responseJSON + "]";

                return JsonConvert.DeserializeObject<List<Feedback>>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Ergebnis>> GetErgebnisByKey(string key)
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":"+ port + "/api/antworten/" + key);

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();
                responseJSON = "[" + responseJSON + "]";

                return JsonConvert.DeserializeObject<List<Ergebnis>>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        /*public async Task<List<Ergebnis>> GetKey()
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":"+ port + "/api/antworten/key");

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();
                responseJSON = "[" + responseJSON + "]";

                return JsonConvert.DeserializeObject<List<Ergebnis>>(responseJSON);
            }
            else
            {
                return null;
            }
        }*/

        public async Task<bool> SendFilledDataFeedback(Feedback feedback)           //geht
        {
            var json = JsonConvert.SerializeObject(feedback);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://" + server + ":"+ port + "/api/feedback/post";

            var response2 = await _client.PostAsync(url, data);
            if (response2.Content.ReadAsStringAsync().Result.Equals("1"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
