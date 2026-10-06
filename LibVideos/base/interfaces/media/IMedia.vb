''' <summary>
''' Interface for media types.
''' </summary>
Public Interface IMedia
    Inherits IContent
    Inherits IReproductible
    ''' <summary>
    ''' Gets or sets the genres of the audio media.
    ''' </summary>
    ''' <returns></returns>
    Property Genres As IList(Of IGenere)
    ''' <summary>
    ''' Gets or sets the title of the media.
    ''' </summary>
    ''' <returns></returns>
    Property Title As String

    ''' <summary>
    ''' Gets or sets the format of the media.
    ''' </summary>
    ''' <returns></returns>
    Property Language As String
    ''' <summary>
    ''' Gets or sets the thumbnail image of the media.
    ''' </summary>
    ''' <returns></returns>
    Property Thumbnail As IContent


End Interface
