Imports DevExpress.Pdf

Namespace PdfMergeExample

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using pdfDocumentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                pdfDocumentProcessor.CreateEmptyDocument("Merged.pdf")
                pdfDocumentProcessor.AppendDocument("..\..\docs\TextMerge1.pdf")
                pdfDocumentProcessor.AppendDocument("..\..\docs\TextMerge2.pdf")
            End Using
            Call Process.Start(New ProcessStartInfo("Merged.pdf") With {.UseShellExecute = True})
        End Sub
    End Class
End Namespace
