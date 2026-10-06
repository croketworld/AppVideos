Public Class Image
    Implements IImage
    Public Property Id As String Implements IIdentifiable(Of String).Id
    Public Property Name As String Implements IContent.Name
    Public Property Path As String Implements IContent.Path
    Public Property Size As Long Implements IContent.Size
    Public Property Description As String Implements IContent.Description
    Public Property Resolution As System.Drawing.Size Implements IImage.Resolution
    Public Property CreatedDate As Date Implements ICreatable.CreatedDate
    Public Property CreatedBy As String Implements ICreatable.CreatedBy

    Public ReadOnly Property Format As EFormat Implements IContent.Format
        Get
            Return EFormat.Image
        End Get
    End Property
End Class