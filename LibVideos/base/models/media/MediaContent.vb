''' <summary>
''' Represents a media content item in the system, such as an image, video, or audio file. This class provides properties and methods to manage media content, including loading from a file, retrieving file properties, and converting to a System.Drawing.Image object.
''' </summary>
Public MustInherit Class MediaContent
    Implements IContent
    Implements IComparable(Of IContent)

#Region "Properties"

    ''' <summary>
    ''' Gets or sets the unique identifier for the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property Id As Integer Implements IIdentifiable(Of Integer).Id
    ''' <summary>
    ''' Gets or sets the name of the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String Implements IContent.Name
    ''' <summary>
    ''' Gets or sets the file path of the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property Path As String Implements IContent.Path
    ''' <summary>
    ''' Gets or sets the size of the image in bytes.
    ''' </summary>
    ''' <returns></returns>
    Public Property Size As Long Implements IContent.Size
    ''' <summary>
    ''' Gets or sets the description of the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property Description As String Implements IContent.Description

    ''' <summary>
    ''' Gets or sets the creation date of the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property CreatedDate As Date Implements ICreatable.CreatedDate
    ''' <summary>
    ''' Gets or sets the creator of the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property CreatedBy As String Implements ICreatable.CreatedBy
    ''' <summary>
    ''' Gets or sets the last modified date of the image.
    ''' </summary>
    ''' <returns></returns>
    Public Overridable ReadOnly Property Format As EFormat Implements IContent.Format
        Get
            Return _format
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the categories associated with the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property Categories As List(Of ICategory) Implements ICategorizable.Categories
    ''' <summary>
    ''' Gets or sets the tags associated with the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property Tags As List(Of ITag) Implements ITageable.Tags
    ''' <summary>
    ''' Gets or sets the release date of the image.
    ''' </summary>
    ''' <returns></returns>
    Public Property ReleaseDate As Date Implements IDatable.ReleaseDate


    Friend _format As EFormat

#End Region

#Region "Methods"

    Public Overridable Sub LoadFromFile(filepath As String)
        If IO.File.Exists(filepath) Then

            MediaExtensionMethods.GetFileProperties(Me, filepath)
        End If
    End Sub





#End Region

#Region "operators"

    ''' <summary>
    ''' Converts the current image instance to a System.Drawing.Image object.
    ''' </summary>
    ''' <returns></returns>
    Public Function ToImage() As System.Drawing.Image
        Return System.Drawing.Image.FromFile(Me.Path)
    End Function


    ''' <summary>
    ''' Compares the current image instance with another image instance based on their unique identifiers.
    ''' </summary>
    ''' <param name="other">The image instance to compare with the current image instance.</param>
    ''' <returns></returns>
    Public Function CompareTo(other As IContent) As Integer Implements IComparable(Of IContent).CompareTo
        If other Is Nothing Then Return 1
        Return Me.Id.CompareTo(other.Id)
    End Function


    ''' <summary>
    ''' Returns a string representation of the image, which is its file path.
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return Me.Path
    End Function
    ''' <summary>
    ''' Returns the hash code for the image, which is based on its unique identifier.
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function GetHashCode() As Integer
        Return Me.Id
    End Function
    ''' <summary>
    ''' Determines whether the specified object is equal to the current image instance.
    ''' </summary>
    ''' <param name="obj">The object to compare with the current image instance.</param>
    ''' <returns></returns>
    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function


#End Region

End Class
