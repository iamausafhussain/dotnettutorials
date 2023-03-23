namespace AssignBuilderPrinter
{
    public class RtfPrinter : AbsPrinter
    {
        string header;
        string content;
        string footer;

        public RtfPrinter(string header, string content, string footer)
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
        public void GetTempRtfPath()
        {
            Console.WriteLine("Get template rtf path");
        }
    }
}
