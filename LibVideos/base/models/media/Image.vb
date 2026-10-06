

''' <summary>
''' Represents an image media content with properties such as resolution, size, and format.
''' </summary>
Public Class Image
    Inherits MediaContent
    Implements IVisualContent


#Region "Properties"

    ''' <summary>
    ''' Gets or sets the resolution of the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property Resolution As System.Drawing.Size Implements IVisualContent.Resolution

    ''' <summary>
    ''' Gets the format of the image, which is always EFormat.Image.
    ''' </summary>
    ''' <returns></returns>
    Public Overrides ReadOnly Property Format As EFormat
        Get
            Return EFormat.Image
        End Get

    End Property

#End Region

#Region "Methods"
    ''' <summary>
    ''' Loads the image from the specified file path and retrieves its properties.
    ''' </summary>
    ''' <param name="filepath"></param>
    Private Sub GetImageProperties(filepath As String)
        Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filepath)
        Me.Resolution = New System.Drawing.Size(img.Width, img.Height)
    End Sub
    ''' <summary>
    ''' Loads the image from the specified file path and retrieves its properties.
    ''' </summary>
    ''' <param name="filepath"></param>
    Public Overrides Sub LoadFromFile(filepath As String)
        MyBase.LoadFromFile(filepath)
        GetImageProperties(filepath)
    End Sub

#End Region
#Region "Constructors"

    ''' <summary>
    ''' Initializes a new instance of the Image class with the specified file path.
    ''' </summary>
    ''' <param name="filepath"></param>
    Public Sub New(filepath As String)
        LoadFromFile(filepath)
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the Image class.
    ''' </summary>
    Public Sub New()

    End Sub

#End Region



End Class