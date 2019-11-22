Public Class ListItem

    Public Value As Object
    Public Text As String

    Public Sub New(ByVal NewValue As Object, ByVal NewText As String)
        Value = NewValue
        Text = NewText
    End Sub

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class
