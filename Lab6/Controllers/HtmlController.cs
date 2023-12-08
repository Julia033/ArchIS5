using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;


namespace Lab6.Controllers
{
    public class HtmlController
    {
        private string html = @"https://dom2tv.ru/byvshie-uchastniki";
        public List<Models.House3> GetParticipants()
        {
            List<Models.House3> house2s = new List<Models.House3>();
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument Doc = new HtmlDocument();
            try
            {
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
                Models.House3 participant = new Models.House3
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
