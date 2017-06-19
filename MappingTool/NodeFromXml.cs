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
        public string xpathFormMapping { get; set; } 
        public string value { get; set; }
        public List<XElement> ancestors { get; set; }    

        public NodeFromXml() { }

        public NodeFromXml(XElement innernode)
        {
            string xpath = null;
            ancestors = innernode.AncestorsAndSelf().ToList();

            var Array = innernode.AncestorsAndSelf().ToArray(); // List to Array, список предков

            for (int i = Array.Count() - 1; i >= 0; i--)
            {
                if (xpath != null)
                    xpath = string.Join(@"/", xpath, Array[i].Name);
                else
                    xpath = Array[i].Name.ToString();
            }

            this.xpathFormMapping = xpath;

            value = innernode.Value;
        }
    }
}
