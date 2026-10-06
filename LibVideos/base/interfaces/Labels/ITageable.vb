''' <summary>
''' Interface for objects that can be tagged with labels.
''' </summary>
Public Interface ITageable
    ''' <summary>
    ''' Gets or sets the list of tags associated with the object.
    ''' </summary>
    ''' <returns></returns>
    Property Tags As List(Of ITag)
End Interface