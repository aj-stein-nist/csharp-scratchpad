using System.Text;
using System.Xml;
using System.Xml.Linq;

//static IEnumerable<XElement> Process(StreamReader stream)
static void Process(StreamReader stream, XmlReaderSettings? settings)
{
    using (XmlReader reader = XmlReader.Create(stream, settings))
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
                            Console.WriteLine($"Element: {reader.Name}");
                    if (reader.IsEmptyElement)
                    {
                        Console.WriteLine($"EndElement: {reader.Name} (self-closing)");
                    }
                    break;
                case XmlNodeType.Text:
                    Console.WriteLine($"Text: \"{reader.Value}\'");
                    break;
                case XmlNodeType.Attribute:
                    Console.WriteLine($"Attribute: {reader.Value}");
                    break;
                case XmlNodeType.EndElement:
                    Console.WriteLine($"EndElement: {reader.Name}");
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
        @"oscal_ssp_metaschema.xml",
        FileMode.Open,
        FileAccess.Read
    );
using var stream = new StreamReader(file, Encoding.UTF8);
XmlReaderSettings settings = new XmlReaderSettings();
settings.DtdProcessing = DtdProcessing.Parse;
Process(stream, settings);
//string content = await sr.ReadToEndAsync();
//Console.WriteLine(content);