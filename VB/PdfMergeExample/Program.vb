Imports DevExpress.Pdf

Namespace PdfMergeExample

    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using pdfDocumentProcessor As New PdfDocumentProcessor()
                pdfDocumentProcessor.CreateEmptyDocument("..\..\docs\Merged.pdf")
                pdfDocumentProcessor.AppendDocument("..\..\docs\TextMerge1.pdf")
                pdfDocumentProcessor.AppendDocument("..\..\docs\TextMerge2.pdf")
            End Using
        End Sub
    End Class
End Namespace
