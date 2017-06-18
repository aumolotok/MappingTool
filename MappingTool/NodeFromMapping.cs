using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MappingTool
{
    class NodeFromMapping
    {
        private string mainXpath { get; set; }
    
        public NodeFromMapping() { }

        public NodeFromMapping( string mainXpath, string necXpath) 
        {
            this.mainXpath = mainXpath;
            Necessary Necnode = new Necessary(necXpath);
            
        }

        class Necessary
        {
            private string necessaryNodeXpath { get; set; }

            public Necessary() { }

            public Necessary(string necessaryNodeXpath)
            {
                this.necessaryNodeXpath = necessaryNodeXpath;
            }
        }
    }
}
