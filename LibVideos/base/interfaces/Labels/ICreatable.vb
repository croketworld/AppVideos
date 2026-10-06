''' <summary>
''' Interface for objects that can be created and have creation metadata.
''' </summary>
Public Interface ICreatable
    ''' <summary>
    ''' Gets or sets the date and time when the object was created.
    ''' </summary>
    ''' <returns></returns>
    Property CreatedDate As DateTime
    ''' <summary>
    ''' Gets or sets the identifier of the user or entity that created the object.
    ''' </summary>
    ''' <returns></returns>
    Property CreatedBy As String
End Interface
