using DevExpress.Pdf;

namespace PdfMergeExample
{

    class Program
    {
        static void Main(string[] args)
        {

            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor())
            {
                pdfDocumentProcessor.CreateEmptyDocument("Merged.pdf");
                pdfDocumentProcessor.AppendDocument("..\\..\\docs\\TextMerge1.pdf");
                pdfDocumentProcessor.AppendDocument("..\\..\\docs\\TextMerge2.pdf");
                
            }
            System.Diagnostics.Process.Start("Merged.pdf");
        }

    }
}
