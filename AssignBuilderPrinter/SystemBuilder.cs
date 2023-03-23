namespace AssignBuilderPrinter
{
    internal class SystemBuilderPrinter
    {
        string header;
        string content;
        string footer;
        public SystemBuilderPrinter PrintHeader(string header)
        {
            this.header = header;
            return this;
        }
        public SystemBuilderPrinter PrintContent(string content)
        {
            this.content = content;
            return this;
        }
        public SystemBuilderPrinter PrintFooter(string footer)
        {
            this.footer = footer;
            return this;
        }
        public PdfPrinter BuildPdf()
        {
            return new PdfPrinter(this.header, this.content, this.footer);
        }
        public HtmlPrinter BuildHtml()
        {
            return new HtmlPrinter(this.header, this.content, this.footer);
        }
        public RtfPrinter BuildRtf()
        {
            return new RtfPrinter(this.header, this.content, this.footer);
        }
    }
}
