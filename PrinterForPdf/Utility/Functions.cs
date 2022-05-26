using System.Drawing.Printing;
using iText.Kernel.Pdf;
using PrinterForPdf.Entity;
using System.Linq;

namespace PrinterForPdf.Utility
{
    public static class Functions
    {
        public static bool CreateNewPdfFile(PrintObject printObject)
        {
            if (printObject.FilePaths == null) return false;
            printObject.NewPdfFile = new PdfDocument(new PdfWriter(printObject.PathName));
            foreach (var fileName in printObject.FilePaths)
            {
                var pdfReader = new PdfReader(fileName);
                pdfReader.SetUnethicalReading(true);
                var selectedPdfDocument = new PdfDocument(pdfReader);
                int numberOfPages = selectedPdfDocument.GetNumberOfPages();
                selectedPdfDocument.CopyPagesTo(1, numberOfPages, printObject.NewPdfFile);
                if (numberOfPages % 2 == 1 && printObject.FilePaths.Last() != fileName)
                    printObject.NewPdfFile.AddNewPage();
            }
            printObject.NewPdfFile.Close();
            return true;
        }
    }
}
