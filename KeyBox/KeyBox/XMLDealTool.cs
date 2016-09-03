using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace KeyBox
{
    class XMLDealTool
    {
        public static bool setKeyPath(string keypath) 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"config.xml");
            XmlNode root = null;
            root = doc.DocumentElement;

            XmlNode xmlNode = root.SelectSingleNode("path");
            xmlNode.InnerText = keypath;
            doc.Save(@"config.xml");
            return true;
        }

        public static string getKeyPath()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"config.xml");
            XmlNode root = null;
            root = doc.DocumentElement;

            XmlNode xmlNode = root.SelectSingleNode("path");

            return xmlNode.InnerText;
        }

        public static string getUrlPath()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"config.xml");
            XmlNode root = null;
            root = doc.DocumentElement;

            XmlNode xmlNode = root.SelectSingleNode("url");

            return xmlNode.InnerText;
        }
    }
}
