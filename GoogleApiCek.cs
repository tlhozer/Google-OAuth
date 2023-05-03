using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Web;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace WebApplication1
{
    public class Deneme
    {
        public static class GoogleHelper
        {
            public static readonly string[] Scopes = { "email", "profile" };
            public static readonly string ClientId = "350077940693-9oh3k57ak13tku86ccu23512on75t104.apps.googleusercontent.com";
            public static readonly string ClientSecret = "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";
            public static readonly string RedirectUri = "https://localhost:44353/WebForm1.aspx";

            public static UserCredential GetUserCredential(string code)
            {
                var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
                {
                    ClientSecrets = new ClientSecrets
                    {
                        ClientId = ClientId,
                        ClientSecret = ClientSecret
                    },
                    Scopes = Scopes,
                    DataStore = new FileDataStore("Drive.Api.Auth.Store")
                });

                var token = flow.ExchangeCodeForTokenAsync("n", code, RedirectUri, System.Threading.CancellationToken.None).Result;
                var credential = new UserCredential(flow, "user", token);
                return credential;
            }

            public static string GetGoogleLoginUrl()
            {
                var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
                {
                    ClientSecrets = new ClientSecrets
                    {
                        ClientId = ClientId,
                        ClientSecret = ClientSecret
                    },
                    Scopes = Scopes,
                    DataStore = new FileDataStore("Drive.Api.Auth.Store")
                });

                var uri2 = flow.CreateAuthorizationCodeRequest(RedirectUri).Build();
                return uri2.AbsoluteUri;
            }
        }

    }
}