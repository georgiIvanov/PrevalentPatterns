using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class WebPageScraper : ICloneable
    {
        string title;
        int headerTagCount;
        string firstHeaderTagContents;

        public WebPageScraper(string url)
        {
            var client = new WebClient();
            Scrape(client.DownloadString(url));
        }

        private void Scrape(string page)
        {
            title = "Fake title";
            headerTagCount = 3;
            firstHeaderTagContents = "Fake header text";
        }

        internal void PrintPageData()
        {
            Console.WriteLine("Title: {0}, Header Count: {1}, First Header {2}", title, headerTagCount, firstHeaderTagContents);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
