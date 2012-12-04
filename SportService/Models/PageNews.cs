using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportService.Models
{
    public class PageNews
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Href { get; set; }
        public string Img { get; set; }
        public string HeadText { get; set; }
        public string DetailText { get; set; }
    }
}
