using System.Text;
using System.Xml;
using System.Xml.Linq;

//static IEnumerable<XElement> Process(StreamReader stream)
static void Process(StreamReader stream)
{
    using (XmlReader reader = XmlReader.Create(stream))
    {
        while (reader.Read())
        {
            //Console.WriteLine($"{reader.NodeType}: {reader.Name}");
            switch (reader.NodeType)
            {
                case XmlNodeType.Whitespace:
                    break;
                case XmlNodeType.SignificantWhitespace:
                    break;
                case XmlNodeType.Element:
                    Console.WriteLine(reader.Name);
                    break;
                case XmlNodeType.Text:
                    Console.WriteLine(reader.Value);
                    break;
                case XmlNodeType.Attribute:
                    break;
                case XmlNodeType.EndElement:
                    break;
                case XmlNodeType.Comment:
                    break;
                case XmlNodeType.XmlDeclaration:
                    break;
                case XmlNodeType.ProcessingInstruction:
                    break;
                case XmlNodeType.EntityReference:
                    break;
                case XmlNodeType.EndEntity:
                    break;
                case XmlNodeType.CDATA:
                    break;
                case XmlNodeType.Document:
                    break;
                case XmlNodeType.DocumentFragment:
                    break;
                case XmlNodeType.DocumentType:
                    break;
                case XmlNodeType.Notation:
                    break;
                case XmlNodeType.None:
                    break;
            }
        }
    }
    return;
}


using var file = new FileStream(
        @"oscal_metadata_metaschema.xml",
        FileMode.Open,
        FileAccess.Read
    );
using var stream = new StreamReader(file, Encoding.UTF8);

Process(stream);
//string content = await sr.ReadToEndAsync();
//Console.WriteLine(content);