'#Region "#Reference"
Imports DevExpress.Pdf

' ...
'#End Region  ' #Reference
Namespace PdfMergeExample

'#Region "#Code"
    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Dim pdfDocumentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
            pdfDocumentProcessor.LoadDocument("..\..\docs\TextMerge1.pdf")
            pdfDocumentProcessor.AppendDocument("..\..\docs\TextMerge2.pdf")
            pdfDocumentProcessor.SaveDocument("..\..\docs\Merged.pdf")
        End Sub
    End Class
'#End Region  ' #Code
End Namespace
