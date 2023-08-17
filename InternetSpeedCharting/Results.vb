
Public Class Rootobject
    Public Property type As String
    Public Property timestamp As Date
    Public Property ping As Ping
    Public Property download As Download
    Public Property upload As Upload
    Public Property packetLoss As Integer
    Public Property isp As String
    Public Property _interface As _Interface
    Public Property server As Server
    Public Property result As Result
End Class

Public Class Ping
    Public Property jitter As Single
    Public Property latency As Single
    Public Property low As Single
    Public Property high As Single
End Class

Public Class Download
    Public Property bandwidth As Single
    Public Property bytes As Single
    Public Property elapsed As Single
    Public Property latency As Latency
End Class

Public Class Latency
    Public Property iqm As Single
    Public Property low As Single
    Public Property high As Single
    Public Property jitter As Single
End Class

Public Class Upload
    Public Property bandwidth As Single
    Public Property bytes As Single
    Public Property elapsed As Single
    Public Property latency As Latency1
End Class

Public Class Latency1
    Public Property iqm As Single
    Public Property low As Single
    Public Property high As Single
    Public Property jitter As Single
End Class

Public Class _Interface
    Public Property internalIp As String
    Public Property name As String
    Public Property macAddr As String
    Public Property isVpn As Boolean
    Public Property externalIp As String
End Class

Public Class Server
    Public Property id As Integer
    Public Property host As String
    Public Property port As Integer
    Public Property name As String
    Public Property location As String
    Public Property country As String
    Public Property ip As String
End Class

Public Class Result
    Public Property id As String
    Public Property url As String
    Public Property persisted As Boolean
End Class
