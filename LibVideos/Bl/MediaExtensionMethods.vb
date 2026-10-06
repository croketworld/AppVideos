''' <summary>
''' Provides extension methods for the MediaContent class.
''' </summary>
Public Module MediaExtensionMethods

    ''' <summary>
    ''' Retrieves the properties of a media content item from the specified file path and updates the MediaContent object accordingly.
    ''' </summary>
    ''' <param name="mediacontent">The MediaContent object to update.</param>
    ''' <param name="filepath">The file path of the media content item.</param>
    ''' <param name="description">The description of the media content item.</param>
    ''' <param name="releaseDate">The release date of the media content item.</param>
    ''' <param name="tags">The tags associated with the media content item.</param>
    ''' <param name="categories">The categories associated with the media content item.</param>
    ''' <param name="createdBy">The user who created the media content item.</param>
    Public Sub GetFileProperties(mediacontent As MediaContent,
                                 filepath As String,
                                 Optional description As String = "",
                                 Optional releaseDate As Date = Nothing,
                                 Optional tags As List(Of ITag) = Nothing,
                                 Optional categories As List(Of ICategory) = Nothing,
                                 Optional createdBy As String = "")
        Dim fileinf As New IO.FileInfo(filepath)
        mediacontent.Path = filepath

        mediacontent.Tags = tags
        mediacontent.Categories = categories
        mediacontent.Description = description
        mediacontent.ReleaseDate = releaseDate
        mediacontent.Size = fileinf.Length
        mediacontent.Name = fileinf.Name
        mediacontent._format = GetFormatFromExtension(fileinf.Extension)
        mediacontent.CreatedDate = fileinf.CreationTime
        mediacontent.CreatedBy = If(String.IsNullOrEmpty(createdBy), Environment.UserName, createdBy)
    End Sub
    ''' <summary>
    ''' Determines the media format based on the file extension.
    ''' </summary>
    ''' <param name="extension">The file extension.</param>
    ''' <returns>The media format.</returns>
    Public Function GetFormatFromExtension(extension As String) As EFormat
        Dim exte As String = extension.ToLower()
        If exte.StartsWith(".") Then exte = exte.Substring(1)
        Select Case exte
            Case "png", "jpg", "jpeg", "gif", "bmp", "tiff", "webp"
                Return EFormat.Image
            Case "mp4", "avi", "mov", "mkv", "flv", "wmv", "webm"
                Return EFormat.Video
            Case "mp3", "wav", "flac", "aac", "ogg", "wma", "m4a"
                Return EFormat.Audio
            Case Else
                Return EFormat.Unknown
        End Select

    End Function
End Module
