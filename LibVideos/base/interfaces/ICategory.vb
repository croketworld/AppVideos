''' <summary>
''' Represents a category that can be assigned to videos. A category is a type of tag that is used to group videos together based on their content or theme.
''' </summary>
Public Interface ICategory
    Inherits ITag
    Inherits IIdentifiable(Of Short)

End Interface
