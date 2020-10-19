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
        public const String MASCHILE = "MASCHILE";
        public const String FEMMINILE = "FEMMINILE";
        public const String TEST = "TEST";

        private const string fightersUrl = "https://hemaratings.com/fighters/";
        private const string clubsUrl = "https://hemaratings.com/clubs/";

        public static async void SyncFigthersAsync()
        {
            ProgressBar p = new ProgressBar();
            p.SetProgressBarTitle("Fighters");

            var response = await GetResponse(fightersUrl);

            List<HtmlNode> figtherNodes = GetNodes(response);

            List<HemaRatingsFighter> hemaFigthers = new List<HemaRatingsFighter>();

            p.InizializeProgressBar(1, figtherNodes.Count);
            p.Show();
            int i = 1;

            foreach (var node in figtherNodes)
            {
                p.IncrementProgressBar(i++);

                var li = node.Descendants("td").ToList();

                if (li.Count > 0)
                {
                    var name_surname = li[0].InnerText;
                    string nationality = GetNationality(li);
                    var figtherId = GetId(li);
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

            p.Close();
            p.Dispose();

            InsertFightersIntoDB(hemaFigthers);
        }
        

        public static async void SyncClubsAsync()
        {
            ProgressBar p = new ProgressBar();
            p.SetProgressBarTitle("Clubs");

            var response = await GetResponse(clubsUrl);
            
            List<HtmlNode> clubNodes = GetNodes(response);

            List<HemaRatingsClub> hemaClubs = new List<HemaRatingsClub>();

            p.InizializeProgressBar(1, clubNodes.Count);
            p.Show();
            int i = 1;

            foreach (var node in clubNodes)
            {
                p.IncrementProgressBar(i++);

                var li = node.Descendants("td").ToList();

                if(li.Count > 0)
                {
                    var clubName = li[0].InnerText.Replace("\r\n", "").Trim();
                    var clubId = GetId(li);
                    var country = GetCountry(li);
                    var state = GetState(li);
                    var city = GetCity(li);

                    hemaClubs.Add(new HemaRatingsClub
                    {
                        Id = clubId,
                        Name = clubName,
                        Country = country,
                        State = state,
                        City = city
                    });
                }

            }

            p.Close();
            p.Dispose();
        }




        #region Parsing
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

        private static async System.Threading.Tasks.Task<byte[]> GetResponse(string url)
        {
            HttpClient http = new HttpClient();
            var response = await http.GetByteArrayAsync(url);
            return response;
        }

        private static int GetId(List<HtmlNode> li)
        {
            try
            {
                return Convert.ToInt32(li[0].Descendants("a").ToList()[0].GetAttributeValue("href", null).Split('/').ElementAt(3));
            }
            catch
            {
                return -1;
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

        private static string GetCity(List<HtmlNode> li)
        {
            try
            {
                return li[3].InnerText;
            }
            catch
            {
                return "";
            }
        }

        private static string GetState(List<HtmlNode> li)
        {
            try
            {
                return li[2].InnerText;
            }
            catch
            {
                return "";
            }
        }

        private static string GetCountry(List<HtmlNode> li)
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
        #endregion

        #region DataBase 

        private static string GetConnectionString()
        {
            if (GetDbType() == TEST)
                return ConfigurationManager.AppSettings["SqlDBTest"];
            else if (GetDbType() == FEMMINILE)
                return ConfigurationManager.AppSettings["SqlDBFemale"];
            else
                return ConfigurationManager.AppSettings["SqlDB"];
        }
        private static string GetDbType()
        {
            string dbType = ConfigurationManager.AppSettings["DataBase"].ToString().ToUpper();

            if (dbType == "MASCHILE")
                return MASCHILE;
            else if (dbType == "FEMMINILE")
                return FEMMINILE;
            else
                return TEST;
        }
        //TODO: l'inserimento deve essere in delta
        private static void InsertFightersIntoDB(List<HemaRatingsFighter> hemaFigthers)
        {
            //throw new NotImplementedException();
        }
        #endregion

    }   

}
