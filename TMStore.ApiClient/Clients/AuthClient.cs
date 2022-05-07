﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMStore.ApiClient.Helpers;
using TMStore.ApiClient.Models;

namespace TMStore.ApiClient.Clients
{
    public class AuthClient : IAuthClient
    {
        private RestClient client = ClientHelper.GetClient();

        public bool Login(string email, string password)
        {
            try
            {
                if (email.IsEmpty())
                {
                    throw new Exception("Chưa cugn cấp email");
                }
                if (password.IsEmpty())
                {
                    throw new Exception("Chưa cung cấp password");
                }
                var body = new AuthRequest
                {
                    email = email,
                    password = password
                };
                var request = new RestRequest(ClientHelper.GetBaseUrl() + "v1/_Auth", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(body);
                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = JsonHelper.ConvertJsonToObject<AuthModel>(response.Content);
                    ClientHelper.SetToken(result.token);
                    return true;
                }
                else
                {
                    throw new Exception(response.Content);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
