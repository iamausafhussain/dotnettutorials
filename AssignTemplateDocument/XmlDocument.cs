namespace AssignTemplateDocument
{
    internal class XmlDocument : Document
    {
        public override void PrintBody()
        {
            Console.WriteLine("XmlDocument Printing Body");
        }
        public override void PrintHeader()
        {
            Console.WriteLine("XmlDocument Printing Header");
        }
        public override void PrintFooter()
        {
            Console.WriteLine("XmlDocument Printing Footer");
        }
    }
}
