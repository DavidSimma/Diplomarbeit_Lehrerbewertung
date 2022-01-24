using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Diplomarbeit.models
{
    static class DBManager
    {
        private static HttpClient _client = new HttpClient();
        private static string server = "localhost";
        
        public static async Task<bool> keyExists(string key)
        {
            HttpResponseMessage response = await _client.GetAsync("http://"+server+":56928/api/fragen/" + key);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public static async Task<API_Request> getEmptyValuation(string key)
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":56928/api/fragen/" + key);

            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<API_Request>(responseJSON);
            }
            else
            {
                return null;
            }
        }

        public static async Task<bool> sendFilledValuation(API_Template a)
        {
            var json = JsonConvert.SerializeObject(a);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://" + server + ":56928/api/antworten/post";

            var response = await _client.PostAsync(url, data);
            if (response.IsSuccessStatusCode) return true;
            else return false;
        }

        public static async Task<bool> feedbackExists(string formularID, string TeacherKey)
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":56928/api/feedback");
            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();

                List<Feedback> fed = JsonConvert.DeserializeObject<List<Feedback>>(responseJSON);
                foreach (Feedback f in fed)
                {
                    if (f.teacherId == formularID && f.teacherKey == TeacherKey)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

    }
}
