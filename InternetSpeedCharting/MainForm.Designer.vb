<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.chartSpeeds = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.nudMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.chartSpeeds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtOutput.Location = New System.Drawing.Point(0, 424)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(800, 245)
        Me.txtOutput.TabIndex = 0
        '
        'chartSpeeds
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartSpeeds.ChartAreas.Add(ChartArea2)
        Me.chartSpeeds.Dock = System.Windows.Forms.DockStyle.Top
        Legend2.Name = "Legend1"
        Me.chartSpeeds.Legends.Add(Legend2)
        Me.chartSpeeds.Location = New System.Drawing.Point(0, 0)
        Me.chartSpeeds.MinimumSize = New System.Drawing.Size(800, 365)
        Me.chartSpeeds.Name = "chartSpeeds"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartSpeeds.Series.Add(Series2)
        Me.chartSpeeds.Size = New System.Drawing.Size(800, 365)
        Me.chartSpeeds.TabIndex = 1
        Me.chartSpeeds.Text = "Speed"
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnStart.Location = New System.Drawing.Point(122, 381)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(203, 381)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'nudMinutes
        '
        Me.nudMinutes.Location = New System.Drawing.Point(12, 384)
        Me.nudMinutes.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudMinutes.Name = "nudMinutes"
        Me.nudMinutes.Size = New System.Drawing.Size(54, 20)
        Me.nudMinutes.TabIndex = 4
        Me.nudMinutes.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Test Frequency:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "minutes"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 669)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudMinutes)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.chartSpeeds)
        Me.Controls.Add(Me.txtOutput)
        Me.Name = "MainForm"
        Me.Text = "Speedtest!"
        CType(Me.chartSpeeds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
    Friend WithEvents chartSpeeds As DataVisualization.Charting.Chart
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents nudMinutes As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
