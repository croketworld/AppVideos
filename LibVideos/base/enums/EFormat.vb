''' <summary>
''' The EFormat enumeration defines the different formats that can be used in the application.
''' </summary>
<Flags>
Public Enum EFormat As Long
    ''' <summary>
    ''' Represents an unknown format.
    ''' </summary>
    Unknown = 0
    ''' <summary>
    ''' Represents a video format.
    ''' </summary>
    Video = 1
    ''' <summary>
    ''' Represents an audio format.
    ''' </summary>
    Audio = 2
    ''' <summary>
    ''' Represents an image format.
    ''' </summary>
    Image = 4
End Enum
