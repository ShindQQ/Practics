using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;

namespace Practic5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string filename = @"C:\Users\user\source\repos\Practics\Practic5\TelephoneBook.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(filename, Encoding.UTF8);

            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.IndentChar = '\t';
            xmlWriter.Indentation = 1;
            xmlWriter.QuoteChar = '\'';


            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartElement("Phone");
            xmlWriter.WriteString("0896754321");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString("Name1");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartElement("Phone");
            xmlWriter.WriteString("0896754322");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString("Name2");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartElement("Phone");
            xmlWriter.WriteString("0896754323");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Name");
            xmlWriter.WriteString("Name3");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.Close();


            FileStream stream = new FileStream(filename, FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                Console.WriteLine($"{xmlReader.NodeType}, {xmlReader.Name}, {xmlReader.Value}");
            }

            xmlReader.Close();
            stream.Close();

            var document = new XPathDocument(filename);
            XPathNavigator navigator = document.CreateNavigator();

            XPathNodeIterator iterator1 = navigator.Select("MyContacts/Contact/Phone");

            foreach (var item in iterator1)
            {
                Console.WriteLine(item);
            }
        }
    }
}