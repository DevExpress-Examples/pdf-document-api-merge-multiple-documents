using DevExpress.Pdf;

namespace PdfMergeExample
{

    class Program
    {
        static void Main(string[] args)
        {

            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor())
            {
                pdfDocumentProcessor.CreateEmptyDocument("..\\..\\docs\\Merged.pdf");
                pdfDocumentProcessor.AppendDocument("..\\..\\docs\\TextMerge1.pdf");
                pdfDocumentProcessor.AppendDocument("..\\..\\docs\\TextMerge2.pdf");
                pdfDocumentProcessor.SaveDocument("Merged.pdf");
            }
            System.Diagnostics.Process.Start("Merged.pdf");
        }

    }
}
