''' <summary>
''' Interface for objects that can be categorized.
''' </summary>
Public Interface ICategorizable
    ''' <summary>
    ''' Gets or sets the categories associated with the object.
    ''' </summary>
    ''' <returns></returns>
    Property Categories As List(Of ICategory)
End Interface