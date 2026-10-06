Imports System.Drawing

''' <summary>
''' Represents a video content item.
''' </summary>
Public Class Video
    Inherits MediaContent
    Implements IVisualContent
    Implements IVideo

#Region "Properties"

    ''' <summary>
    ''' Gets or sets the resolution of the video.
    ''' </summary>
    ''' <returns></returns>
    Public Property Resolution As Size Implements IVisualContent.Resolution
    ''' <summary>
    ''' Gets or sets the bitrate of the video.
    ''' </summary>
    ''' <returns></returns>
    Public Property VideoBitrate As Integer Implements IVideo.VideoBitrate
    ''' <summary>
    ''' Gets or sets the bitrate of the audio associated with the video.
    ''' </summary>
    ''' <returns></returns>
    Public Property AudioBitrate As Integer Implements IAudio.AudioBitrate
    ''' <summary>
    ''' Gets or sets the genres associated with the video.
    ''' </summary>
    ''' <returns></returns>
    Public Property Genres As IList(Of IGenere) Implements IMedia.Genres
    ''' <summary>
    ''' Gets or sets the title of the video.
    ''' </summary>
    ''' <returns></returns>
    Public Property Title As String Implements IMedia.Title
    ''' <summary>
    ''' Gets or sets the language of the video.
    ''' </summary>
    ''' <returns></returns>
    Public Property Language As String Implements IMedia.Language
    ''' <summary>
    ''' Gets or sets the thumbnail image associated with the video.
    ''' </summary>
    ''' <returns></returns>
    Public Property Thumbnail As IContent Implements IMedia.Thumbnail
    ''' <summary>
    ''' Gets or sets the duration of the video.
    ''' </summary>
    ''' <returns></returns>
    Public Property Duration As TimeSpan Implements IReproductible.Duration


#End Region


#Region "Methods"
    ''' <summary>
    ''' Loads the image from the specified file path and retrieves its properties.
    ''' </summary>
    ''' <param name="filepath"></param>
    Private Sub GetVideoProperties(filepath As String)
        ''TODO: Implement logic to extract video properties such as resolution, bitrate, duration, etc.
    End Sub

    ''' <summary>
    ''' Loads the video from the specified file path and retrieves its properties.
    ''' </summary>
    ''' <param name="filepath"></param>
    Public Overrides Sub LoadFromFile(filepath As String)
        MyBase.LoadFromFile(filepath)
        GetVideoProperties(filepath)
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
