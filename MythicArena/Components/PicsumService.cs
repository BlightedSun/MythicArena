using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MythicArena.Components
{
    public class PicsumService : IPicsumService
    {
        //private readonly PicsumService _httpClient;


        private readonly HttpClient _httpClient;
        public PicsumService(HttpClient httpClient)
        {
            //PicsumService httpClient
            _httpClient = httpClient;
        }

        public async Task<string> GetRandomImageUrl()
        {
            // Get a random image (direct URL)
            return await Task.FromResult("https://picsum.photos/500/500");
        }

        public async Task<string> GetRandomImageWithSize(int width, int height)
        {
            // Get a random image with specific width and height
            return await Task.FromResult($"https://picsum.photos/{width}/{height}");


        }


    }
}
