''' <summary>
''' Interface for video media types.
''' </summary>
Public Interface IVideo
    Inherits IAudio
    Inherits IVisualContent
    ''' <summary>
    ''' Gets or sets the bitrate of the video media.
    ''' </summary>
    ''' <returns></returns>
    Property VideoBitrate As Integer



End Interface