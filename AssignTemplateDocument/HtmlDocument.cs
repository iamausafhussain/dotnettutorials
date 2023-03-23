namespace AssignTemplateDocument
{
    internal class HtmlDocument : Document
    {
        public override void PrintBody()
        {
            Console.WriteLine("HtmlDocument Printing Body");
        }
        public override void PrintHeader()
        {
            Console.WriteLine("HtmlDocument Printing Header");
        }
        public override void PrintFooter()
        {
            Console.WriteLine("HtmlDocument Printing Footer");
        }
    }
}
