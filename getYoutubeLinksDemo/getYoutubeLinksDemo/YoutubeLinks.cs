using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;


    class YoutubeLink
    {
        static WebClient getPage = new WebClient();
        const string PATTERN = @"""/watch+(?<link>.+\S)""";
        Regex regex = new Regex(PATTERN, RegexOptions.IgnoreCase);


        public string[] getTopVideos(string pageLink)
        {
            string downloadPage = getPage.DownloadString(pageLink);
            string[] mcArray = new string[10];
            MatchCollection MC = regex.Matches(downloadPage);

            for (int i = 0; i < 6; i++)
            {
                if (i == 1 || i == 3 || i == 5)
                {
                    mcArray[i] = Convert.ToString(MC[i]);
                }
            }
            string[] topVideos = new string[3];
            string link1 = "www.youtube.com" + mcArray[1].Substring(1, mcArray[1].Length - 2);
            string link2 = "www.youtube.com" + mcArray[3].Substring(1, mcArray[3].Length - 2);
            string link3 = "www.youtube.com" + mcArray[5].Substring(1, mcArray[3].Length - 2);
            topVideos[0] = link1;
            topVideos[1] = link2;
            topVideos[2] = link3;
            return topVideos;
            
        }
    }

