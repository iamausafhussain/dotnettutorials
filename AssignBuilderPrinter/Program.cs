namespace AssignBuilderPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PdfPrinter pdf = new SystemBuilderPrinter()
                .PrintHeader("pdf header")
                .PrintContent("pdf content")
                .PrintFooter("pdf footer")
                .BuildPdf();
            pdf.PrintHeader();
            pdf.PrintContent();
            pdf.PrintFooter();

            Console.WriteLine();

            HtmlPrinter html = new SystemBuilderPrinter()
                .PrintHeader("html header")
                .PrintContent("html content")
                .PrintFooter("html footer")
                .BuildHtml();
            html.PrintHeader();
            html.PrintContent();
            html.PrintFooter();
        }
    }
}