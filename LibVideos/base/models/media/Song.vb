''' <summary>
''' Represents a song media type.
''' </summary>
Public Class Song
    Inherits Audio
    Implements ISong

#Region "Properties"

    ''' <summary>
    ''' Gets or sets the album name of the song.
    ''' </summary>
    ''' <returns></returns>
    Public Property Album As String Implements ISong.Album

    ''' <summary>
    ''' Gets or sets the artist name of the song.
    ''' </summary>
    ''' <returns></returns>
    Public Property Artist As String Implements ISong.Artist
    ''' <summary>
    ''' Gets or sets the metadata associated with the song.
    ''' </summary>
    ''' <returns></returns>
    Public Property MetaData As IDictionary(Of String, String) Implements ISong.MetaData

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Initializes a new instance of the Image class with the specified file path.
    ''' </summary>
    ''' <param name="filepath">The file path of the image to load.</param>
    Public Sub New(filepath As String, metaData As IDictionary(Of String, String))
        LoadFromFile(filepath)
        Me.Album = metaData.Item("Album")
        Me.Artist = metaData.Item("Artist")
        Me.MetaData = metaData
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the Image class with the specified file path.
    ''' </summary>
    ''' <param name="filepath">The file path of the image to load.</param>
    Public Sub New(filepath As String, album As String, artist As String, metaData As IDictionary(Of String, String))
        LoadFromFile(filepath)
        Me.Album = album
        Me.Artist = artist
        Me.MetaData = metaData
    End Sub


    ''' <summary>
    ''' Initializes a new instance of the Image class with the specified file path.
    ''' </summary>
    ''' <param name="filepath">The file path of the image to load.</param>
    Public Sub New(filepath As String, album As String, artist As String)
        LoadFromFile(filepath)
        Me.Album = album
        Me.Artist = artist
    End Sub

    ''' <summary>
    ''' Initializes a new instance of the Image class with the specified file path.
    ''' </summary>
    ''' <param name="filepath">The file path of the image to load.</param>
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
