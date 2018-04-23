#region #Reference
using DevExpress.Pdf;
// ...
#endregion #Reference

namespace PdfMergeExample {
#region #Code
class Program {
    static void Main(string[] args) {
        PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor();
        pdfDocumentProcessor.LoadDocument("..\\..\\docs\\TextMerge1.pdf");
        pdfDocumentProcessor.AppendDocument("..\\..\\docs\\TextMerge2.pdf");
        pdfDocumentProcessor.SaveDocument("..\\..\\docs\\Merged.pdf");
    }
}
#endregion #Code
}
