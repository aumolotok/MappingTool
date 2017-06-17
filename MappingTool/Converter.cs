using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MappingTool
{
   static class Converter
    {
        public static List<XElement> XmlEater(XDocument XDoc)
        {
            List<XElement> ellist = new List<XElement>();

            foreach (XElement element in XDoc.Descendants())
            {
                if (element.Descendants().Count() == 0)
                {
                    ellist.Add(element);
                }
            }
            return ellist;
        }

        public static void ShowXpaths(List<XElement> ellist)
        {
            foreach (XElement el in ellist)
            {
                var Array = el.AncestorsAndSelf().ToArray();
                for (int i = Array.Length - 1; i >= 0; i--)
                {
                    Console.Write(Array[i].Name + @"/");
                }
                Console.WriteLine();
            }

        }





    }
}
