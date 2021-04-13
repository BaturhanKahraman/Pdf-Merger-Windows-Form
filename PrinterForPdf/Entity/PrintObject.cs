using iText.Kernel.Pdf;

namespace PrinterForPdf.Entity
{
    public class PrintObject
    {

        public string PathName { get; set; }

        public PdfDocument NewPdfFile { get; set; }

        public string[] FilePaths { get; set; }


    }
}
