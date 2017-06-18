using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MappingTool
{
    class NodeFromXml
    {
        private string xpathFormMapping { get; set; }

        private ;

        public NodeFromXml() { }

        public NodeFromXml(XElement innernode)
        {
            string xpath = "";

            var Array = innernode.AncestorsAndSelf().ToArray(); // List to Array, список предков

            for (int i = Array.Count() - 1; i >= 0; i--)
            {
                xpath = string.Join(@"/", xpath, Array[i].Name);
                //Console.WriteLine(Array[i].Name + @"/"); // Вывод предков в обратном порядке (как в Xpath)
            }

            this.xpathFormMapping = xpath;
        }
    }
}
