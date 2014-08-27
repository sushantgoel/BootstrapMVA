using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semantic_Bootstrap_2.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string BandName { get; set; }
        public List<Track> Tracks { get; set; }
        public string ExpertReview { get; set; }
    }
}