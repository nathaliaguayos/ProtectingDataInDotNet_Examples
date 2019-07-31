using System;
using System.Xml;
using System.IO;

namespace DotNet_XMLInjectionMitigation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create some objects
            XmlDocument testXmlDocument = new XmlDocument();
            XmlNode testXmlNode = testXmlDocument.CreateElement("testXmlNodeName");


            //LOOK HERE: Safely add data to the XML document
            //NO XML INJECTION HERE
            testXmlNode.InnerText = "\r\n<XML>DATA INJECTED</XML>\r\n";

            //Add the infected XML node to the XML document
            testXmlDocument.AppendChild(testXmlNode);

            //Convert XML document to a string
            StringWriter testStringWriter = new StringWriter();
            XmlWriter testXmlWriter = XmlWriter.Create(testStringWriter);
            testXmlDocument.WriteTo(testXmlWriter);
            testXmlWriter.Flush();
            String xmlOutput = testStringWriter.GetStringBuilder().ToString();

            //Print the XML Document string to the console
            Console.WriteLine(xmlOutput);
            Console.Read();
        }
    }
}
