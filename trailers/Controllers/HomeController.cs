using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trailers.Models;
using System.Net.Http;
using Newtonsoft.Json;


using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;


namespace trailers.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<String> getInfo(String search)
        {
            var responseString  = await client.GetStringAsync("http://www.omdbapi.com/?apikey=a3b8657b&type=movie&s=" + search);
            return responseString;
            
        }
        public async Task<String> getPlot(String imdb)
        {
            var responseString  = await client.GetStringAsync("http://www.omdbapi.com/?apikey=a3b8657b&i=" + imdb);
            return responseString;
            
        }

        public async Task<string> Run(String searchQuery)
        {
            //Console.Write(this.GetType().ToString());
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCM4yscR28cZVCytUZUTwDVGWSPq44rfUk",
                ApplicationName = "dept"
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = searchQuery; // Replace with your search term.
            searchListRequest.MaxResults = 1;
            searchListRequest.Type = "video";

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = await searchListRequest.ExecuteAsync();

            List<string> videos = new List<string>();
            List<string> channels = new List<string>();
            List<string> playlists = new List<string>();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels, and playlists.
            try{
                return searchListResponse.Items[0].Id.VideoId;
            }
            catch{
                return "error";
            }
        }



        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Trailer()
        {   

            String movieName = Request.Form["movie-name"];
            String search = getInfo(Request.Form["movie-name"]).Result;
            RootObject result = JsonConvert.DeserializeObject<RootObject>(search);
            var movie = result.Search[0];
            String plot = getPlot(movie.imdbID).Result;

            movie = JsonConvert.DeserializeObject<OMDB>(plot);
            
            try
            {
                search = movie.Title + " offitial trailer" + movie.Year;
                Console.WriteLine(search);

                movie.Url =  new HomeController().Run(search).Result;
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                Console.WriteLine("Error: " + e.Message);
                }
            }

            
            return Json(JsonConvert.SerializeObject(movie, Formatting.Indented));

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
