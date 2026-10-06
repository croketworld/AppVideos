''' <summary>
''' This class is used to interact with the ffmpeg library for video processing tasks. It provides methods to perform various operations such as video conversion, compression, and editing using the ffmpeg command-line tool.
''' </summary>
Public Class FfmpegAPI



    Public Shared Function GetFfmpegPath() As String
        ''TODO: check common locations for ffmpeg executable and return the path if found, otherwise return an empty string or throw an exception
        Return "C:\Program Files\ffmpeg\bin\ffmpeg.exe"
    End Function


    ''' <summary>
    ''' Gets the version of the ffmpeg library by loading the ffmpeg executable and retrieving its version information.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetFfmpegVersion() As String
        Dim fflocation As String = GetFfmpegPath()
        Dim ass As System.Reflection.Assembly = Nothing
        Try
            ass = System.Reflection.Assembly.LoadFile(fflocation)
        Catch ex As Exception

        End Try
        If ass IsNot Nothing Then
            Dim version As Version = ass.GetName().Version
            Return $"ffmpeg version {version.ToString()}"
        End If
        Return "ffmpeg not found"
    End Function


    Public Shared Function GetVideoInfo(videoPath As String) As Dictionary(Of String, String)
        ' Implement logic to retrieve video information using ffmpeg
        ' This is a placeholder implementation
        Return New Dictionary(Of String, String) From {
            {"Format", "mp4"},
            {"Resolution", "1920x1080"},
            {"Duration", "00:05:00"}
        }
    End Function

    Public Shared Function GetVideoDuration(videoPath As String) As TimeSpan
        ' Implement logic to retrieve video duration using ffmpeg
        ' This is a placeholder implementation
        Return TimeSpan.Zero
    End Function

    Public Shared Function ConvertVideo(inputPath As String, outputPath As String, format As String) As Boolean
        ' Implement logic to convert video format using ffmpeg
        ' This is a placeholder implementation
        Return True
    End Function

    Public Shared Function AddSubtitle(inputPath As String, outputPath As String, subtitlePath As String) As Boolean
        ' Implement logic to add subtitles to video using ffmpeg
        ' This is a placeholder implementation
        Return True
    End Function

    Public Shared Function AddWatermark(inputPath As String, outputPath As String, watermarkPath As String) As Boolean
        ' Implement logic to add watermark to video using ffmpeg
        ' This is a placeholder implementation
        Return True
    End Function


    Public Shared Function MergeVideos(videoPaths As List(Of String), outputPath As String) As Boolean
        ' Implement logic to merge multiple videos into one using ffmpeg
        ' This is a placeholder implementation
        Return True
    End Function

    Public Shared Function ExtractFrames(inputPath As String, outputFolder As String, frameRate As Integer) As Boolean
        ' Implement logic to extract frames from video using ffmpeg
        ' This is a placeholder implementation
        Return True
    End Function

    Public Shared Function ResizeVideo(inputPath As String, outputPath As String, width As Integer, height As Integer) As Boolean
        ' Implement logic to resize video using ffmpeg
        ' This is a placeholder implementation
        Return True
    End Function


    Public Shared Function ExtractAudio(inputPath As String, outputPath As String) As Boolean
        ' Implement logic to extract audio from video using ffmpeg
        ' This is a placeholder implementation
        Return True
    End Function

    Public Shared Function CompressVideo(inputPath As String, outputPath As String, bitrate As Integer) As Boolean
        ' Implement logic to compress video using ffmpeg
        ' This is a placeholder implementation
        Return True
    End Function

End Class
