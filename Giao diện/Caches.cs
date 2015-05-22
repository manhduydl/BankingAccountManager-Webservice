using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Giao_diện
{
    public class Caches
    {
        static XmlDocument doc = new XmlDocument();

        public static void caches_image(string s)
        {
            doc.Load("Resources/caches_data.xml");
            XmlElement goc = doc.DocumentElement;
            XmlElement i = (XmlElement)goc.SelectSingleNode("Image");
            if (i.GetAttribute("data") != s)
            {
                i.SetAttribute("data", s);
                doc.Save("Resources/caches_data.xml");
            }
        }
    
        public static void caches_start(string s)
        {
            doc.Load("Resources/caches_data.xml");
            XmlElement goc = doc.DocumentElement;
            int i = 0;
            foreach (XmlElement e in goc.SelectNodes("//taikhoan"))
            {
                if (e.GetAttribute("Tentk") == s)
                {
                    i = -1;
                    break;
                }
            }
            if (i != -1)
            {
                XmlElement tempt = doc.CreateElement("taikhoan");
                tempt.SetAttribute("Tentk", s);
                goc.AppendChild(tempt);

                doc.Save("Resources/caches_data.xml");
            }
        }

        public static string load_image()
        {

            doc.Load("Resources/caches_data.xml");
            XmlElement goc = doc.DocumentElement;
            XmlElement i = (XmlElement)goc.SelectSingleNode("Image");
            return i.GetAttribute("data");
        }

        public static List<string> load_caches()
        {
            
            doc.Load("Resources/caches_data.xml");
            XmlElement goc = doc.DocumentElement;
            List<string> L=new List<string>();
            foreach (XmlElement e in goc.SelectNodes("//taikhoan"))
            {
                L.Add(e.GetAttribute("Tentk"));
            }
            return L;
        }
    }
}
