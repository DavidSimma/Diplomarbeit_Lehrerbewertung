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
        private static string server = "localhost";

        public async Task<Formular> GetFormularByID(string id)
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":56928/api/fragen/" + id);

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

        public async Task<List<Formular>> GetAllFormular()
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":56928/api/fragen");

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Formular>>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Feedback>> GetAllFeedback()
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":56928/api/feedback");

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Feedback>>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Ergebnis>> GetErgebnisByKey(string key)
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":56928/api/antworten/" + key);

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Ergebnis>>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Ergebnis>> GetKey()
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":56928/api/antworten/key");

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Ergebnis>>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> SendFilledData(Formular formular)
        {
            var json = JsonConvert.SerializeObject(formular);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://" + server + ":56928/api/fragen/post";

            var response2 = await _client.PostAsync(url, data);
            if (response2.Content.ReadAsStringAsync().Result.Equals("true"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> SendFilledDataFeedback(Feedback feedback)
        {
            var json = JsonConvert.SerializeObject(feedback);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://" + server + ":56928/api/feedback/post";

            var response2 = await _client.PostAsync(url, data);
            if (response2.Content.ReadAsStringAsync().Result.Equals("true"))
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
