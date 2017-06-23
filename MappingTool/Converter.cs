﻿using System;
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

        public static XElement ListFromOneVarToOneVar (IEnumerable<XElement> XeIenum)
        {            
                XElement[] Array = XeIenum.ToArray();
                XElement Result = Array[0];
                return Result;           
        }

        public static XElement ListFromOneVarToOneVar(List<XElement> XeIenum)
        {
            XElement[] Array = XeIenum.ToArray();
            XElement Result = Array[0];
            return Result;
        }

        public static bool IsNodeHasSameParent( XNode element1, XNode element2)
        {
            if (element1.Parent == element2.Parent)
                return true;
            else
                return false;
        }

        public static bool IsNodeHasSameParent(XElement element1, XElement element2)
        {
            if (element1.Parent == element2.Parent)
                return true;
            else
                return false;
        }





    }
}
