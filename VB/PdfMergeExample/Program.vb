Imports DevExpress.Pdf

Namespace PdfMergeExample

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using pdfDocumentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                pdfDocumentProcessor.CreateEmptyDocument("Merged.pdf")
                pdfDocumentProcessor.AppendDocument("..\..\docs\TextMerge1.pdf")
                pdfDocumentProcessor.AppendDocument("..\..\docs\TextMerge2.pdf")
            End Using

            System.Diagnostics.Process.Start("Merged.pdf")
        End Sub
    End Class
End Namespace
