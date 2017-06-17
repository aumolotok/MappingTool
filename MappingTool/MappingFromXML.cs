using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MappingTool
{
    class MappingFromXML
    {
        public string xpath;
        public MappingFromXML() { }

        public MappingFromXML(XElement innernode)
        {
            string xpath = "";

            var Array = innernode.AncestorsAndSelf().ToArray(); // List to Array, список предков

            for (int i = Array.Count() - 1; i >= 0; i--)
            {
                xpath = string.Join(@"/", xpath, Array[i].Name);
                //Console.WriteLine(Array[i].Name + @"/"); // Вывод предков в обратном порядке (как в Xpath)
            }

            this.xpath = xpath;
        }
    }
}
