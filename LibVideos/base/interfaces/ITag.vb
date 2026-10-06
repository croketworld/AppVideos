''' <summary>
''' Represents a tag that can be associated with videos or other media items.
''' </summary>
Public Interface ITag
    Inherits IIdentifiable(Of Integer)
    ''' <summary>
    ''' Gets or sets the name of the tag.
    ''' </summary>
    ''' <returns></returns>
    Property Name As String
    ''' <summary>
    ''' Gets or sets the description of the tag.
    ''' </summary>
    ''' <returns></returns>
    Property Description As String

End Interface
