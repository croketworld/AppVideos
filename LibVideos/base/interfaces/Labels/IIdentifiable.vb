''' <summary>
''' Represents an object that has an identifier of type T.
''' </summary>
''' <typeparam name="T"></typeparam>
Public Interface IIdentifiable(Of T)
    ''' <summary>
    ''' Gets or sets the identifier of the object.
    ''' </summary>
    ''' <returns></returns>
    Property Id As T
End Interface
''' <summary>
''' Represents an object that has a string identifier.
''' </summary>
Public Interface IIdentifiable
    Inherits IIdentifiable(Of String)
End Interface