using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Driver;
using SportService.Models;
using MongoDB.Driver.Builders;

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

        public IList<PageNews> GetGridData()
        {
            IList<PageNews> pageNews = new List<PageNews>();
            var server = returnMongoServer();
            var database = server.GetDatabase("testdb");
            var collection = database.GetCollection("example");

            var iList = collection.FindAll().SetSortOrder(SortBy.Descending("_id"));
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

        public PageNews GetFullCol()
        {
            PageNews pageNew = new PageNews();

            var server = returnMongoServer();
            var database = server.GetDatabase("testdb");
            var collection = database.GetCollection("example");

            Random rand = new Random();
            int toSkip = rand.Next(0, (int)collection.Count());

            var ret = collection.FindAll().Skip(toSkip).FirstOrDefault();
            if (ret != null)
            {
                pageNew.Id = (int)ret["Id"];
                pageNew.Url = ret["Url"].ToString();
                pageNew.Href = ret["Href"].ToString();
                pageNew.HeadText = ret["HeadText"].ToString();
                pageNew.Img = ret["Img"].ToString();
                pageNew.DetailText = ret["DetailText"].ToString();
            }

            return pageNew;
        }

        public IList<PageNews> GetThirdCols()
        {
            IList<PageNews> pageNews = new List<PageNews>();
            var server = returnMongoServer();
            var database = server.GetDatabase("testdb");
            var collection = database.GetCollection("example");

            Random rand = new Random();
            int toSkip = rand.Next(0, (int)collection.Count() - 3);

            var iList = collection.FindAll().Skip(toSkip).Take(3).ToList();

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

        public PageNews GetTwoInThirdCols()
        {
            PageNews pageNew = new PageNews();

            var server = returnMongoServer();
            var database = server.GetDatabase("testdb");
            var collection = database.GetCollection("example");

            Random rand = new Random();
            int toSkip = rand.Next(0, (int)collection.Count());

            var ret = collection.FindAll().Skip(toSkip).FirstOrDefault();
            if (ret != null)
            {
                pageNew.Id = (int)ret["Id"];
                pageNew.Url = ret["Url"].ToString();
                pageNew.Href = ret["Href"].ToString();
                pageNew.HeadText = ret["HeadText"].ToString();
                pageNew.Img = ret["Img"].ToString();
                pageNew.DetailText = ret["DetailText"].ToString();
            }

            return pageNew;
        }

        public PageNews GetSideBox()
        {
            PageNews pageNew = new PageNews();

            var server = returnMongoServer();
            var database = server.GetDatabase("testdb");
            var collection = database.GetCollection("example");

            Random rand = new Random();
            int toSkip = rand.Next(0, (int)collection.Count());

            var ret = collection.FindAll().Skip(toSkip).FirstOrDefault();
            if (ret != null)
            {
                pageNew.Id = (int)ret["Id"];
                pageNew.Url = ret["Url"].ToString();
                pageNew.Href = ret["Href"].ToString();
                pageNew.HeadText = ret["HeadText"].ToString();
                pageNew.Img = ret["Img"].ToString();
                pageNew.DetailText = ret["DetailText"].ToString();
            }

            return pageNew;
        }

        public IList<object> GetHomePageData()
        {
            IList<object> lists = new List<object>();

            lists.Add(GetFullCol());
            lists.Add(GetThirdCols());
            lists.Add(GetTwoInThirdCols());
            lists.Add(GetSideBox());

            return lists;
        }

    }
}
