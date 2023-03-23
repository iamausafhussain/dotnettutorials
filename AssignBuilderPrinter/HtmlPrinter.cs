namespace AssignBuilderPrinter
{
    public class HtmlPrinter : AbsPrinter
    {
        string header;
        string content;
        string footer;

        public HtmlPrinter(string header, string content, string footer)
        {
            this.header = header;
            this.content = content;
            this.footer = footer;
        }
        public override void PrintHeader()
        {
            Console.WriteLine($"Header: {this.header}");
        }
        public override void PrintContent()
        {
            Console.WriteLine($"Content: {this.content}");
        }
        public override void PrintFooter()
        {
            Console.WriteLine($"Foooter: {this.footer}");
        }
        public void GetTempHtmlPath()
        {
            Console.WriteLine("Get template html path");
        }
    }
}
