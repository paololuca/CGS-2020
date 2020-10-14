using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using HtmlAgilityPack;

namespace WindowsFormsApplication1
{
    public static class HemaRatingsHelper
    {
        public static async void SyncFigthersAsync()
        {
            var response = await getResponse("https://hemaratings.com/fighters/");

            List<HtmlNode> figtherNodes = GetNodes(response);

            List<HemaRatingsFighter> hemaFigthers = new List<HemaRatingsFighter>();

            foreach (var node in figtherNodes)
            {
                var li = node.Descendants("td").ToList();

                if (li.Count > 0)
                {
                    var name_surname = li[0].InnerText;
                    string nationality = GetNationality(li);
                    var figtherId = Convert.ToInt32(li[0].Descendants("a").ToList()[0].GetAttributeValue("href", null).Split('/').ElementAt(3));
                    int clubId = GetClubId(li);

                    hemaFigthers.Add(new HemaRatingsFighter
                    {
                        Id = figtherId,
                        IdClub = clubId,
                        Name = name_surname,
                        Nationality = nationality
                    });
                }

            }
        }

        private static int GetClubId(List<HtmlNode> li)
        {
            try
            {
                return Convert.ToInt32(li[2].Descendants("a").ToList()[0].GetAttributeValue("href", null).Split('/').ElementAt(3));
            }
            catch
            {
                return -1;
            }
        }

        private static string GetNationality(List<HtmlNode> li)
        {
            try
            {
                return li[1].Descendants("i").ToList()[0].GetAttributeValue("title", null);
            }
            catch
            {
                return "";
            }
        }

        public static async void SyncClubsAsync()
        {
            var response = await getResponse("https://hemaratings.com/clubs/");
            String source = Encoding.GetEncoding("utf-8").GetString(response, 0, response.Length - 1);
            source = System.Net.WebUtility.HtmlDecode(source);
            HtmlDocument resultat = new HtmlDocument();
            resultat.LoadHtml(source);

            List<HtmlNode> clubNodes = GetNodes(response);            

            foreach (var node in clubNodes)
            {
                var li = node.Descendants("td").ToList();

            }
        }

        private static List<HtmlNode> GetNodes(byte[] response)
        {
            String source = Encoding.GetEncoding("utf-8").GetString(response, 0, response.Length - 1);
            source = System.Net.WebUtility.HtmlDecode(source);
            HtmlDocument resultat = new HtmlDocument();
            resultat.LoadHtml(source);

            List<HtmlNode> figtherNodes = resultat.DocumentNode.Descendants().
                Where(x => (x.Name == "tr")).ToList();
            return figtherNodes;
        }

        private static async System.Threading.Tasks.Task<byte[]> getResponse(string url)
        {
            HttpClient http = new HttpClient();
            var response = await http.GetByteArrayAsync(url);
            return response;
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.AppSettings["HemaRatingsDB"];
        }
    }   

}
