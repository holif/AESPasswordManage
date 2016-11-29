using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace KeyBox
{
    class XMLDealTool
    {
        private static string configpath = @"../../config.xml";
        public static bool setKeyPath(string keypath) 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(configpath);
            XmlNode root = null;
            root = doc.DocumentElement;

            XmlNode xmlNode = root.SelectSingleNode("path");
            xmlNode.InnerText = keypath;
            doc.Save(configpath);
            return true;
        }

        public static string getKeyPath()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(configpath);
            XmlNode root = null;
            root = doc.DocumentElement;

            XmlNode xmlNode = root.SelectSingleNode("path");

            return xmlNode.InnerText;
        }

        public static string getUrlPath()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(configpath);
            XmlNode root = null;
            root = doc.DocumentElement;

            XmlNode xmlNode = root.SelectSingleNode("url");

            return xmlNode.InnerText;
        }
    }
}
