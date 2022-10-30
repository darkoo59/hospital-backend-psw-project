﻿using IntegrationLibrary.Core.Model;
using IntegrationLibrary.Core.Repository;
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IntegrationLibrary.Core.Service
{
    public class BloodService : IBloodService
    {
        private readonly IUserService _userService;
        private static readonly HttpClient _httpClient = new HttpClient();

        public BloodService(IUserService userService) {
            _userService = userService;
        }


        public async Task<Boolean> CheckBloodTypeAvailability(BloodTypesEnum bloodType, string apiKey, float bloodQuantity, string email)
        {
            User user = _userService.GetBy(email);
            string ret;
            string url;
            if (bloodQuantity == 0)
            {
                url = "http://" + user.Server + "/api/blood/type?bloodType=" + bloodType;
            }
            else
            {
                url = "http://" + user.Server + "/api/blood/type/quantity";
            }

            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("ApiKey", apiKey);
            HttpResponseMessage response = await _httpClient.SendAsync(requestMessage);

            if (response.StatusCode.Equals(System.Net.HttpStatusCode.Unauthorized))
            {
                throw new Exception("API key is not valid");
            }else if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error while communicating with ISA server");
            }

            ret = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<bool>(ret);
        }
        
        public static async Task<string> GenerateApiKey(User user)
        {
            HttpContent content = new StringContent(user.Email);
            HttpResponseMessage response = await _httpClient.PostAsync("http://" + user.Server + "/api/key/create", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error while communicating with ISA server");
            }

            string ret = await response.Content.ReadAsStringAsync();
            return ret;
        }

    }
}
