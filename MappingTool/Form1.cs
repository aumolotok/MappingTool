using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MappingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("5");
            XDocument XDoc = XDocument.Load(@"C:\GitHub\MappingTool\XMLFile1.xml");
            Console.WriteLine(XDoc);
            //some new code
            // little more
            // and more
            //more
            List<XElement> testlist = Converter.XmlEater(XDoc);
            Converter.ShowXpaths(testlist);
        }

        




   
}

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
//    static public void WR()
//    {
//        //public void WR() { }
//        //XDocument Xdoc = XDocument.Load(@"D:\Tasks\143505877 A2X\1.xml");
//        XDocument Xdoc = XDocument.Load(@"C:\Users\andrey.kolotilo\YandexDisk\C#\XMLfile1.xml");

//        int a = 0;

//        foreach (XElement node in Xdoc.Descendants())
//        {
//            if (node.Descendants().Count() == 0) // Проверяет отсутствие потомков
//            {
//                a++; //счетчик
//                Console.Write(a.ToString() + ".  "); //Вывод счетчика

//                var Array = node.AncestorsAndSelf().ToArray(); // List to Array, список предков

//                for (int i = Array.Count() - 1; i >= 0; i--)
//                {
//                    Console.WriteLine(Array[i].Name + @"/"); // Вывод предков в обратном порядке (как в Xpath)
//                    Console.Write(Array[i]);
//                    Console.ReadKey();
//                }
//                Console.Write(node);
//                Console.WriteLine();
//                Console.WriteLine();

//            }
//        }
//    }
//    static void Main(string[] args)
//    {
//        //Program.WR();
//        XDocument Xdoc = XDocument.Load(@"C:\Users\andrey.kolotilo\YandexDisk\C#\XMLfile1.xml");

//        foreach (XElement node in Xdoc.Descendants())
//        {
//            if (node.Descendants().Count() == 0) // Проверяет отсутствие потомков
//            {
//                MappingFromXML XMLM = new MappingFromXML(node);
//                Console.WriteLine(XMLM.xpath);

//            }
//        }

//        Console.ReadKey();
//    }



//}

//class MappingFromDoc
//{
//    public string field;
//    public string xpath;
//    public string[] attributes;

//    public MappingFromDoc()
//    { }

//    public MappingFromDoc(string field, string xpath, string[] attributes)
//    {
//        this.field = field;
//        this.xpath = xpath;
//        this.attributes = attributes;
//    }
//}

//class MappingFromXML
//{
//    public string xpath;
//    public MappingFromXML() { }

//    public MappingFromXML(XElement innernode)
//    {
//        string xpath = "";

//        var Array = innernode.AncestorsAndSelf().ToArray(); // List to Array, список предков

//        for (int i = Array.Count() - 1; i >= 0; i--)
//        {
//            xpath = string.Join(@"/", xpath, Array[i].Name);
//            //Console.WriteLine(Array[i].Name + @"/"); // Вывод предков в обратном порядке (как в Xpath)
//        }

//        this.xpath = xpath;
//    }
//}
