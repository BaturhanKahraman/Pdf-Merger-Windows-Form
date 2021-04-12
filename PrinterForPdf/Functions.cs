using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;

namespace PrinterForPdf
{
    public class Functions
    {
        public string FileName { get; set; }

        public string PathName { get; set; }

        public PdfDocument NewPdfFile { get; set; }

        public string[] FilePaths { get; set; }

        
        public bool CreateNewPdfFile()
        {

            if (FilePaths == null) return false;
            NewPdfFile = new PdfDocument(new PdfWriter(PathName));
            foreach (var fileName in FilePaths)
            {
                var selectedPdfDocument = new PdfDocument(new PdfReader(fileName));
                int numberOfPages = selectedPdfDocument.GetNumberOfPages();
                selectedPdfDocument.CopyPagesTo(1, numberOfPages, NewPdfFile);
                if (numberOfPages % 2 == 1 && FilePaths.Last() != fileName)
                    NewPdfFile.AddNewPage();
            }
            NewPdfFile.Close();
            return true;
        }



    }
}
