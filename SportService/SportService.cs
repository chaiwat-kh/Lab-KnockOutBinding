using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Driver;
using SportService.Models;

namespace SportService
{
    public class SportService : ISportService
    {
        public SportService()
        {
        }

        private MongoServer returnMongoServer()
        {
            //var connectionString = "mongodb://localhost/?safe=true";
            var connectionString = "mongodb://localhost:27017";
            return MongoServer.Create(connectionString);
        }

        public IList<PageNews> GetData()
        {
            IList<PageNews> pageNews = new List<PageNews>();
            var server = returnMongoServer();
            var database = server.GetDatabase("testdb");
            var collection = database.GetCollection("example");

            var iList = collection.FindAll().ToList();
            foreach (var item in iList)
            {
                pageNews.Add(new PageNews
                {
                    Id = (int)item["Id"],
                    Url = item["Url"].ToString(),
                    Href = item["Href"].ToString(),
                    HeadText = item["HeadText"].ToString(),
                    Img = item["Img"].ToString(),
                    DetailText = item["DetailText"].ToString(),
                });
            }
            return pageNews;
        }
    }
}
