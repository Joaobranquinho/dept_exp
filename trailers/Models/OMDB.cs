using System;
using System.Collections.Generic;

namespace trailers.Models
{
    public class OMDB
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
        public string Url { get; set; }
        public string Plot { get; set; }
    }
    public class RootObject
    {
        public int totalResults { get; set; }
        public List<OMDB> Search { get; set; }
        public bool Response { get; set; }
    }
}
