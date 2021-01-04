using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Stock_Viewer
{
    class Stock
    {
        public static List<Stock> stocks = new List<Stock>();

        readonly public string name;
        private string URL;
        private HtmlWeb web = new HtmlWeb();
        private HtmlDocument doc = new HtmlDocument();
        private bool loaded = false;
        public Stock(string stockName)
        {
            
            this.name = stockName;
            //Console.WriteLine(URL);
            //doc = web.Load(URL);
        }
        public string getValue()
        {
            if (!loaded)
            {
                //URL = String.Format("https://finance.yahoo.com/quote/{0}?p={0}&.tsrc=fin-srch", this.name);
                URL = String.Format("https://www.fool.com/quote/nasdaq/random/{0}/", this.name);
                loaded = true;
            }
            doc = web.Load(URL);
            Console.WriteLine(URL);
            var documentNode = doc.DocumentNode;
            //var value = documentNode.SelectSingleNode("//span[@data-reactid=50]").InnerText;
            var value = documentNode.SelectSingleNode("//span[@class='current-price']").InnerText;
            Console.WriteLine(value);
            return value;
            
        }
        public string getChange()
        {
            if (!loaded)
            {
                //URL = String.Format("https://finance.yahoo.com/quote/{0}?p={0}&.tsrc=fin-srch", this.name);
                URL = String.Format("https://www.fool.com/quote/nasdaq/random/{0}/", this.name);
                loaded = true;
            }
            doc = web.Load(URL);
            Console.WriteLine(URL);
            var documentNode = doc.DocumentNode;
            //var value = documentNode.SelectSingleNode("//span[@data-reactid=50]").InnerText;
            try
            {
                var value = documentNode.SelectSingleNode("//span[@class='price-neg']").InnerText;
                value = String.Concat(value.Where(c => !Char.IsWhiteSpace(c)));
                Console.WriteLine(value);
                return value;
            }
            catch (System.NullReferenceException)
            {
                var value = documentNode.SelectSingleNode("//span[@class='price-pos']").InnerText;
                value = String.Concat(value.Where(c => !Char.IsWhiteSpace(c)));
                Console.WriteLine(value);
                return value;
            }      
        }
        public string getVolume()
        {
            if (!loaded)
            {
                //URL = String.Format("https://finance.yahoo.com/quote/{0}?p={0}&.tsrc=fin-srch", this.name);
                URL = String.Format("https://www.fool.com/quote/nasdaq/random/{0}/", this.name);
                loaded = true;
            }
            doc = web.Load(URL);
            Console.WriteLine(URL);
            var documentNode = doc.DocumentNode;
            var value = documentNode.SelectSingleNode("//td[@class='update_volume']").InnerText;
            return value;
        }

    }
}
