''' <summary>
''' Interface for audio media types.
''' </summary>
Public Interface IAudio
    Inherits IMedia

    ''' <summary>
    ''' Gets or sets the bitrate of the audio media.
    ''' </summary>
    ''' <returns></returns>
    Property AudioBitrate As Integer
End Interface
