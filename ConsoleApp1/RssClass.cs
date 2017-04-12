using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConsoleApp1
{

    [XmlRoot(ElementName = "rss")]
    public class RssClass
    {
        [XmlElement(ElementName = "channel")]
        public ChanelClass Channel { get; set; }
    }

    public class ChanelClass
    {
        [XmlElement(ElementName = "Item")]
        public List<ItemClass> Items { get; set; }
    }

    public class ItemClass
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
    }

}
