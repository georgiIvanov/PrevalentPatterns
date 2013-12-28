using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    // Specify the kinds of objects to create using a prototypical
    // instance and create new objects by copying this prototype.

    class Program
    {
        static void Main(string[] args)
        {
            var scraper = new WebPageScraper("http://www.google.com");
            scraper.PrintPageData();

            var scraper2 = scraper.Clone() as WebPageScraper;
            scraper2.PrintPageData();
        }
    }
}
