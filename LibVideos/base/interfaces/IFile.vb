''' <summary>
''' Interface for a file object that represents a file in the file system. It inherits from the IContent interface and adds properties specific to files, such as Extension, IsReadOnly, and IsHidden.
''' </summary>
Public Interface IFile
    Inherits IContent
    ''' <summary>
    ''' Gets or sets the file extension (e.g., ".txt", ".jpg"). This property is used to identify the type of file based on its extension.
    ''' </summary>
    ''' <returns></returns>
    Property Extension As String
    ''' <summary>
    ''' Gets or sets a value indicating whether the file is read-only. A read-only file cannot be modified or deleted.
    ''' </summary>
    ''' <returns></returns>
    Property IsReadOnly As Boolean
    ''' <summary>
    ''' Gets or sets a value indicating whether the file is hidden. A hidden file is not visible in the file system by default and may require special settings to be viewed.
    ''' </summary>
    ''' <returns></returns>
    Property IsHidden As Boolean

End Interface
