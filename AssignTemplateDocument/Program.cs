namespace AssignTemplateDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document xml = new XmlDocument();
            xml.Print();

            Document html = new HtmlDocument();
            html.Print();
        }
    }

    public abstract class Document
    {
        public void Print()
        {
            PrintBody();
            PrintFooter();
            PrintHeader();
        }

        public abstract void PrintBody();
        public abstract void PrintFooter();
        public abstract void PrintHeader();

    }
}