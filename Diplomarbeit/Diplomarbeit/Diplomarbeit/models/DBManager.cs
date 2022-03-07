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
        private static string server = "10.10.209.34";
        private static string port = "5000";
        

        public static async Task<API_Request> getEmptyValuation(string key)
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":5000/api/fragen/" + key);

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

            var url = "http://" + server + ":" + port + "/api/antworten/post";

            var response = await _client.PostAsync(url, data);
            if (response.IsSuccessStatusCode) return true;
            else return false;
        }

        public static async Task<bool> feedbackExists(string teacherID, string TeacherKey)
        {
            HttpResponseMessage response = await _client.GetAsync("http://" + server + ":" + port + "/api/feedback");
            if (response.IsSuccessStatusCode)
            {
                string responseJSON = await response.Content.ReadAsStringAsync();
                responseJSON = "[" + responseJSON + "]";
                List<Feedback> fed = JsonConvert.DeserializeObject<List<Feedback>>(responseJSON);
                foreach (Feedback f in fed)
                {
                    if (f.teacherId == teacherID && f.TeacherKey == TeacherKey)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

    }
}
