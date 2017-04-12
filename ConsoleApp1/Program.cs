using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadData();
        }

        private static void ReadData()
        {
            WebClient web = new WebClient();
            string s = web.DownloadString(new Uri("http://...", UriKind.Absolute));
            XmlSerializer xml = new XmlSerializer(typeof(RssClass));
            RssClass res = xml.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(s))) as RssClass; 
        }
    }
}
