
''' <summary>
''' Interface for audio media types.
''' </summary>
''' <summary>
''' Interface for song media types.
''' </summary>
Public Interface ISong
    Inherits IAudio
    ''' <summary>
    ''' Gets or sets the album of the song.
    ''' </summary>
    ''' <returns></returns>
    Property Album As String
    ''' <summary>
    ''' Gets or sets the artist of the song.
    ''' </summary>
    ''' <returns></returns>
    Property Artist As String
    ''' <summary>
    ''' Gets or sets the release year of the song.
    ''' </summary>
    ''' <returns></returns>
    Property MetaData As IDictionary(Of String, String)
End Interface