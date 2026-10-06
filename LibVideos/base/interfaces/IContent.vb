''' <summary>
''' Represents a content item in the system.
''' </summary>
Public Interface IContent
    Inherits ICreatable
    Inherits IIdentifiable(Of Integer)
    Inherits IDescriptible
    Inherits ISizeable
    Inherits IPatheable
    Inherits INameable
    Inherits ICategorizable
    Inherits ITageable
    Inherits IDatable

    ''' <summary>
    ''' Gets the format of the content item.
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property Format As EFormat

End Interface
