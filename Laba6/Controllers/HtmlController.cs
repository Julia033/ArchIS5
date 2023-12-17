using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace Laba6.Controllers
{
    class HtmlController
    {
        private string html = @"https://dom2tv.ru/byvshie-uchastniki";
        public List<Models.House> GetParticipants()
        {
            List<Models.House> house2s = new List<Models.House>();
            //для загрузки и парсинга
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument Doc = new HtmlDocument();
            try
            {

                //загружает html-страницу и сохраняет результат в doc
                Doc = htmlWeb.Load(html);
            }
            catch
            {
                throw;
            }
            HtmlNodeCollection tr = Doc.DocumentNode.SelectNodes("//ul[@class='members-list out-members-list']/li");
            foreach (HtmlNode td in tr)
            {
                string name = td.SelectNodes(".//div[@class='holder']/div[@class='head']/strong/a").First().InnerText;
                string start = td.SelectNodes(".//div[@class='holder']/div/span[@class='marker01']").First().InnerText;
                string end = td.SelectNodes(".//div[@class='holder']/div/span[@class='marker02']").First().InnerText;
                Models.House participant = new Models.House
                {
                    Name = name,
                    Start = start,
                    End = end
                };
                house2s.Add(participant);
            }
            return house2s;
        }
    }
}
