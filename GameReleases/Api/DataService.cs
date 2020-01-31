using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api.Core
{
    public class DataService
    {
        public static async Task<List<Game>> GetDataFromSearch(string api_key)
        {
            string apiBaseURL = "https://api-v3.igdb.com/games/";
            var apiClient = new HttpClient()
            {
                BaseAddress = new Uri(apiBaseURL)
            };
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiClient.BaseAddress);

            requestMessage.Headers.Add("Accept", "application/json");
            requestMessage.Headers.Add("user-key", api_key);

            requestMessage.Content = new StringContent("fields name;" +
                                                       "limit 500; ", Encoding.UTF8, "application/json");

            var response = apiClient.SendAsync(requestMessage).Result;

            List<Game> gameData = null;
            if (response != null)
            {
                string responseAsJson = await response.Content.ReadAsStringAsync();
                gameData = JsonConvert.DeserializeObject<List<Game>>(responseAsJson);
            }
            return gameData;
        }
        public static async Task<List<Game>> GetDataFromGame(string api_key, string first_date, string second_date)
        {
            string apiBaseURL = "https://api-v3.igdb.com/games/";
            var apiClient = new HttpClient()
            {
                BaseAddress = new Uri(apiBaseURL)
            };

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiClient.BaseAddress); // 1577836800 1580515199

            requestMessage.Headers.Add("Accept", "application/json");
            requestMessage.Headers.Add("user-key", api_key);
            // 1577836800
            requestMessage.Content = new StringContent("fields name, summary, release_dates.human,platforms.slug, platforms.name, first_release_date, cover.url;" +
                                                       "where first_release_date >= " + first_date +
                                                       " & first_release_date <= " + second_date + ";" +
                                                       "sort first_release_date asc;" +
                                                       "limit 250; ", Encoding.UTF8, "application/json");

            var response = apiClient.SendAsync(requestMessage).Result;

            List<Game> gameData = null;
            if (response != null)
            {
                string responseAsJson = await response.Content.ReadAsStringAsync();
                gameData = JsonConvert.DeserializeObject<List<Game>>(responseAsJson);
            }
            return gameData;
        }
        public static async Task<List<Game>> GetDataForJanuary2020(string api_key)
        {
            string apiBaseURL = "https://api-v3.igdb.com/games/";
            var apiClient = new HttpClient()
            {
                BaseAddress = new Uri(apiBaseURL)
            };

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiClient.BaseAddress);

            requestMessage.Headers.Add("Accept", "application/json");
            requestMessage.Headers.Add("user-key", api_key);
            
            requestMessage.Content = new StringContent("fields name, summary, platforms.name, first_release_date, cover.url, genres.name, involved_companies.company.name;" +
                                                       "where first_release_date >= 1577836800 & first_release_date <= 1580515199;" +
                                                       "sort first_release_date asc;" +
                                                       "limit 500; ", Encoding.UTF8, "application/json");

            var response = await apiClient.SendAsync(requestMessage);

            List<Game> gameData = null;
            if (response != null)
            {
                string responseAsJson = await response.Content.ReadAsStringAsync();
                gameData = JsonConvert.DeserializeObject<List<Game>>(responseAsJson);
            }
            return gameData;
        }
        public static async Task<List<Game>> GetDataForFebruary2020(string api_key)
        {
            string apiBaseURL = "https://api-v3.igdb.com/games/";
            var apiClient = new HttpClient()
            {
                BaseAddress = new Uri(apiBaseURL)
            };

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiClient.BaseAddress);

            requestMessage.Headers.Add("Accept", "application/json");
            requestMessage.Headers.Add("user-key", api_key);

            requestMessage.Content = new StringContent("fields name, summary, platforms.name, first_release_date, cover.url, genres.name, involved_companies.company.name;" +
                                                       "where first_release_date >= 1580515200 & first_release_date <= 1583020799;" +
                                                       "sort first_release_date asc;" +
                                                       "limit 500; ", Encoding.UTF8, "application/json");

            var response =  await apiClient.SendAsync(requestMessage);

            List<Game> gameData = null;
            if (response != null)
            {
                string responseAsJson = await response.Content.ReadAsStringAsync();
                gameData = JsonConvert.DeserializeObject<List<Game>>(responseAsJson);
            }
            return gameData;
        }
        public static async Task<List<Game>> GetDataForMarch2020(string api_key)
        {
            string apiBaseURL = "https://api-v3.igdb.com/games/";
            var apiClient = new HttpClient()
            {
                BaseAddress = new Uri(apiBaseURL)
            };

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiClient.BaseAddress);

            requestMessage.Headers.Add("Accept", "application/json");
            requestMessage.Headers.Add("user-key", api_key);

            requestMessage.Content = new StringContent("fields name, summary, platforms.name, first_release_date, cover.url, genres.name, involved_companies.company.name;" +
                                                       "where first_release_date >= 1583020800 & first_release_date <= 1585612800;" +
                                                       "sort first_release_date asc;" +
                                                       "limit 500; ", Encoding.UTF8, "application/json");

            var response = await apiClient.SendAsync(requestMessage);

            List<Game> gameData = null;
            if (response != null)
            {
                string responseAsJson = await response.Content.ReadAsStringAsync();
                gameData = JsonConvert.DeserializeObject<List<Game>>(responseAsJson);
            }
            return gameData;
        }
        public static async Task<List<Game>> GetDataForJanFebMarch2020(string api_key)
        {
            string apiBaseURL = "https://api-v3.igdb.com/games/";
            var apiClient = new HttpClient()
            {
                BaseAddress = new Uri(apiBaseURL)
            };

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiClient.BaseAddress);

            requestMessage.Headers.Add("Accept", "application/json");
            requestMessage.Headers.Add("user-key", api_key);

            requestMessage.Content = new StringContent("fields name, summary, platforms.name, first_release_date, cover.url, genres.name;" +
                                                       "where first_release_date >= 1577836800 & first_release_date <= 1585612800;" +
                                                       "sort first_release_date asc;" +
                                                       "limit 500; ", Encoding.UTF8, "application/json");

            var response = await apiClient.SendAsync(requestMessage);

            List<Game> gameData = null;
            if (response != null)
            {
                string responseAsJson = await response.Content.ReadAsStringAsync();
                gameData = JsonConvert.DeserializeObject<List<Game>>(responseAsJson);
            }
            return gameData;
        }
    }
}
