''' <summary>
''' Interface for objects that can be modified, providing properties to track the last modification date and the user who made the modification.
''' </summary>
Public Interface IModifiable
    ''' <summary>
    ''' Gets or sets the date and time when the object was last modified.
    ''' </summary>
    ''' <returns></returns>
    Property ModifiedDate As DateTime
    ''' <summary>
    ''' Gets or sets the identifier of the user who last modified the object.
    ''' </summary>
    ''' <returns></returns>
    Property ModifiedBy As String
End Interface