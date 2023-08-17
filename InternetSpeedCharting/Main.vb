Imports System.Web.Script.Serialization
Imports System.Windows.Forms.DataVisualization.Charting

Module Main
    Private TestingThread As Threading.Thread
    Private AbortTesting As Boolean = False
    Private Form As MainForm
    Private Frequency As Integer
    Public DownloadSeries As Series
    Public UploadSeries As Series

    Public Sub Initialize(ByRef currentForm As MainForm)
        Form = currentForm
        SetupChart()
    End Sub

    Public Sub StartTesting(inputFrequency As Single)
        AbortTesting = False
        TestingThread = New Threading.Thread(AddressOf TestingRoutine)
        TestingThread.IsBackground = True
        TestingThread.Start()
        Frequency = inputFrequency * 60000
    End Sub

    Public Sub StopTesting()
        AbortTesting = True
        TestingThread.Abort()
    End Sub

    Private Sub TestingRoutine()
        Dim speedTest As New Process()
        Dim speedTestInfo As New ProcessStartInfo("speedtest.exe", "-f json")
        speedTestInfo.RedirectStandardOutput = True
        speedTestInfo.UseShellExecute = False
        speedTestInfo.CreateNoWindow = True
        speedTest.StartInfo = speedTestInfo

        While Not AbortTesting
            Try
                speedTest.Start()

                Dim output As String
                Using reader As IO.StreamReader = speedTest.StandardOutput
                    output = reader.ReadToEnd()

                    Dim outputResults As Rootobject = New JavaScriptSerializer().Deserialize(Of Rootobject)(output)
                    If outputResults IsNot Nothing Then

                        Form.WriteToOutput($"{outputResults.timestamp} Download: {outputResults.download.bandwidth}, Upload: {outputResults.upload.bandwidth}")
                        Form.chartSpeeds.Invoke(Sub()
                                                    DownloadSeries.Points.AddXY(outputResults.timestamp, outputResults.download.bandwidth / 100000)
                                                    UploadSeries.Points.AddXY(outputResults.timestamp, outputResults.upload.bandwidth / 100000)
                                                End Sub)
                    Else
                        Form.WriteToOutput("Results were nothing")
                    End If
                End Using
            Catch ex As Exception
                Form.WriteToOutput($"Error: {ex.ToString}")
            End Try
            Threading.Thread.Sleep(Frequency)
        End While

    End Sub

    Public Sub SetupChart()
        DownloadSeries = New Series
        UploadSeries = New Series

        DownloadSeries.Name = "Download Speeds"
        UploadSeries.Name = "Upload Speeds"

        DownloadSeries.ChartType = SeriesChartType.Line
        UploadSeries.ChartType = SeriesChartType.Line

        Form.chartSpeeds.Series.Clear()
        Form.chartSpeeds.Series.Add(DownloadSeries)
        Form.chartSpeeds.Series.Add(UploadSeries)
    End Sub
End Module
